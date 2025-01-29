using System;
using System.Data.SqlTypes;
using System.Globalization;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Events
{
    public partial class AddEvent : Form
    {
        DatabaseObjects.Clients _client;
        DatabaseObjects.Employees _employee;

        internal AddEvent(DatabaseObjects.Clients client, DatabaseObjects.Employees employee)
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
                DatabaseObjects.Events event_ = new DatabaseObjects.Events();

                event_.ID = 0; //change
                event_.ClientID = _client.ID;
                event_.EmployeeID = _employee.ID;
                event_.Date = SqlDateTime.Parse(TXTB_Date.Text);
                event_.Type = SelectType(CMBX_Type.Text);
                event_.Description = TXTB_Description.Text;

                DBAddQuery(event_);
            }
        }

        private bool ValidateData()
        {
            if (!ValidateDate(TXTB_Date.Text))
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
            catch
            {
                return false;
            }

            return true;
        }

        private char SelectType(string type) //from full names to s/b/bs
        {
            switch (type)
            {
                case "Dissolution of contract":
                    return '6';

                case "Preeliminary contract arrangement":
                    return '3';

                case "Resigning of contract":
                    return '5';

                case "Signing of contract":
                    return '4';

                case "Emergency contact":
                    return '8';

                case "First contact client-employee":
                    return '2';

                case "First contact employee-client":
                    return '1';

                case "Regulat follow-up contact":
                    return '7';

                default:
                    return '1';
            }
        }

        private void DBAddQuery(DatabaseObjects.Events event_)
        {
            throw new NotImplementedException();
        }

        private void FillTypes()
        {
            CMBX_Type.Items.Clear();
            CMBX_Type.Items.AddRange(new object[] { "Dissolution of contract", "Preeliminary contract arrangement", "Resigning of contract",
            "Signing of contract", "Emergency contact", "First contact client-employee", "First contact employee-client", "Regulat follow-up contact"});
        }
    }
}
