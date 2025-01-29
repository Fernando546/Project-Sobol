using CRM.Helpers.DatabaseObjects;
using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Products
{
    public partial class AddProducts : Form
    {
        DatabaseObjects.Contracts _contract;
        internal AddProducts(DatabaseObjects.Contracts contract)
        {
            InitializeComponent();
            _contract = contract;
            FillTypes();
            FillNames();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                DatabaseObjects.Products product = new DatabaseObjects.Products();

                product.ID = DataBaseGetter.GetMaxID("Products") + 1;
                product.ContractID = _contract.ID;
                product.Name = CMBX_Name.Text;
                product.Cost = SqlMoney.Parse(TXTB_Price.Text);
                product.Type = SqlBoolean.Parse(SelectType(CMBX_Type.Text).ToString());
                product.Amount = SqlInt32.Parse(TXTB_Count.Text);

                if (DBAddQuery(product))
                {
                    MessageBox.Show("Product added successfully");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error adding product");
                }
            }
        }

        private bool ValidateData()
        {
            if (CMBX_Type.SelectedIndex < 0)
            {
                MessageBox.Show("Type is not selected");
                return false;
            }
            else if (!ValidateMoney(TXTB_Price.Text))
            {
                MessageBox.Show("Price is incorrect, should be a valid positive number (eg. 2.11)");
                return false;
            }
            else if (!ValidateAmount(TXTB_Count.Text))
            {
                MessageBox.Show("Count is incorrect, should be a valid positive number (eg. 22)");
                return false;
            }
            else if (CMBX_Name.SelectedIndex < 0)
            {
                MessageBox.Show("Name is not selected");
                return false;
            }

            return true;
        }

        private bool ValidateAmount(string amount)
        {
            try
            {
                var tempAmount = int.Parse(amount);

                if (tempAmount <= 0)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        private bool ValidateMoney(string money)
        {
            try
            {
                var tempMoney = SqlMoney.Parse(TXTB_Price.Text);
                if (tempMoney <= 0)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        private bool SelectType(string type) //from full names to s/b/bs
        {
            switch (type)
            {
                case "Sell":
                    return false;

                case "Buy":
                    return true;

                default:
                    return true;
            }
        }

        private bool DBAddQuery(DatabaseObjects.Products product)
        {
            string query = "INSERT INTO Products (ID, ContractID, Name, Price, Type, Count) VALUES (@ID, @ContractID, @Name, @Cost, @Type, @Amount)";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", product.ID);
                cmd.Parameters.AddWithValue("@ContractID", product.ContractID);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Cost", product.Cost);
                cmd.Parameters.AddWithValue("@Type", product.Type);
                cmd.Parameters.AddWithValue("@Amount", product.Amount);
                cmd.ExecuteNonQuery();
            }
            CalculateContractMoney((int)product.ContractID, product);
            return true;
        }

        private void FillTypes()
        {
            CMBX_Type.Items.Clear();
            CMBX_Type.Items.AddRange(new object[] { "Buy", "Sell" });
        }

        private void FillNames()
        {
            CMBX_Name.Items.Clear();
            CMBX_Name.Items.AddRange(DataBaseGetter.GetProductNames().ToArray());
        }

        private void CalculateContractMoney(int id, DatabaseObjects.Products product)
        {
            string query = "SELECT Cost, Profit, FinalProfit FROM CONTRACTS WHERE ID = @id";

            decimal Cost = 0, Profit = 0, FinalProfit = 0;

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Use if() instead of while() since you're fetching only one row
                    {
                        Cost = reader.GetDecimal(0);
                        Profit = reader.GetDecimal(1);
                        FinalProfit = reader.GetDecimal(2);
                    }
                }
            }

            if (product.Type)
            {
                Cost += (decimal)(product.Cost * product.Amount);
            }
            else
            {
                Profit += (decimal)(product.Cost * product.Amount);
            }

            FinalProfit = Profit-Cost;

            query = "UPDATE CONTRACTS SET Cost = @Cost, Profit = @Profit, FinalProfit = @FinalProfit WHERE ID = @id";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Cost", Cost);
                cmd.Parameters.AddWithValue("@Profit", Profit);
                cmd.Parameters.AddWithValue("@FinalProfit", FinalProfit);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
