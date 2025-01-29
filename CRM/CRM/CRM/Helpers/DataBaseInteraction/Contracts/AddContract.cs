using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Contracts
{
    public partial class AddContract : Form
    {
        DatabaseObjects.Clients _client;
        DatabaseObjects.Employees _employee;
        internal AddContract(DatabaseObjects.Clients client, DatabaseObjects.Employees employee)
        {
            InitializeComponent();
            _client = client;
            _employee = employee;
            FillTypes();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                DatabaseObjects.Contracts contract = new DatabaseObjects.Contracts();
                contract.ID = 0; //change
                contract.EmployeeID = _employee.ID;
                contract.ClientID = _client.ID;
                contract.Type = SelectType(CMBX_Type.Text);
                contract.Name = TXTB_Name.Text;
                contract.Cost = 0;
                contract.Profit = 0;
                contract.FinalProfit = 0;
                contract.SignDate = SqlDateTime.Parse(TXTB_SignDate.Text);
                contract.ExpireDate = SqlDateTime.Parse(TXTB_ExpireDate.Text);

                DBAddQuery(contract);
            }
        }

        private bool ValidateData()
        {
            if(TXTB_Name.Text == string.Empty)
            {
                MessageBox.Show("Name field should be filled");
                return false;
            }
            else if(!ValidateDate(TXTB_SignDate.Text) || !ValidateDate(TXTB_ExpireDate.Text))
            {
                MessageBox.Show("Date has incorrect format, should be: [yyyy-MM-dd]");
                return false;
            }
            else if (CMBX_Type.SelectedIndex < 0)
            {
                MessageBox.Show("Type is not selected");
                return false;
            }

            return true;
        }

        private bool ValidateDate(string date)
        {
            try
            {
                DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        private string SelectType(string type) //from full names to s/b/bs
        {
            switch (type)
            {
                case "Buy":
                    return "B";

                case "Sell":
                    return "S";

                case "Buy/Sell":
                    return "BS";

                default:
                    return "B";
            }
        }
        private void DBAddQuery(DatabaseObjects.Contracts contract)
        {
            throw new NotImplementedException();
        }

        private void FillTypes()
        {
            CMBX_Type.Items.Clear();
            CMBX_Type.Items.AddRange(new object[] { "Buy", "Sell", "Buy/Sell" });
        }
    }
}
