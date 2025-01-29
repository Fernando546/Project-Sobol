using System;
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

                product.ID = 0; //change
                product.ContractID = _contract.ID;
                product.Name = CMBX_Name.Text;
                product.Cost = SqlMoney.Parse(TXTB_Price.Text);
                product.Type = SqlBoolean.Parse(SelectType(CMBX_Type.Text).ToString());
                product.Amount = SqlInt32.Parse(TXTB_Count.Text);

                DBAddQuery(product);
            }
        }

        private bool ValidateData()
        {
            if (CMBX_Type.SelectedIndex < 0)
            {
                MessageBox.Show("Type is not selected");
                return false;
            }
            else if (ValidateMoney(TXTB_Price.Text))
            {
                MessageBox.Show("Amount is incorrect, should be a valid positive number (eg. 2.11)");
                return false;
            }
            else if (ValidateAmount(TXTB_Count.Text))
            {
                MessageBox.Show("Amount is incorrect, should be a valid positive number (eg. 22)");
                return false;
            }
            else if (CMBX_Name.SelectedIndex >= 0)
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
                if(tempMoney <= 0)
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

        private void DBAddQuery(DatabaseObjects.Products product)
        {
            throw new NotImplementedException();
        }

        private void FillTypes()
        {
            CMBX_Type.Items.Clear();
            CMBX_Type.Items.AddRange(new object[] { "Buy", "Sell"});
        }

        private void FillNames()
        {
            CMBX_Name.Items.Clear();
            CMBX_Name.Items.AddRange(DataBaseGetter.GetProductNames().ToArray());
        }
    }
}
