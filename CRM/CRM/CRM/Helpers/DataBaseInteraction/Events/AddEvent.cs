using System;
using System.Data.SqlClient;
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

                event_.ID = DataBaseGetter.GetMaxID("Events") + 1;
                event_.ClientID = _client.ID;
                event_.EmployeeID = _employee.ID;
                event_.Date = SqlDateTime.Parse(TXTB_Date.Text);
                event_.Type = SelectType(CMBX_Type.Text);
                event_.Description = TXTB_Description.Text;

                if (DBAddQuery(event_))
                {
                    MessageBox.Show("Event added successfully");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error adding event");
                }
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

        private bool DBAddQuery(DatabaseObjects.Events event_)
        {
            string query = "INSERT INTO Events (ID, ClientID, EmployeeID, Date, Type, Description) VALUES (@ID, @ClientID, @EmployeeID, @Date, @Type, @Description)";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", event_.ID);
                cmd.Parameters.AddWithValue("@ClientID", event_.ClientID);
                cmd.Parameters.AddWithValue("@EmployeeID", event_.EmployeeID);
                cmd.Parameters.AddWithValue("@Date", event_.Date);
                cmd.Parameters.AddWithValue("@Type", event_.Type);
                cmd.Parameters.AddWithValue("@Description", event_.Description);
                cmd.ExecuteNonQuery();
            }
            return true;
        }

        private void FillTypes()
        {
            CMBX_Type.Items.Clear();
            CMBX_Type.Items.AddRange(new object[] { "Dissolution of contract", "Preeliminary contract arrangement", "Resigning of contract",
            "Signing of contract", "Emergency contact", "First contact client-employee", "First contact employee-client", "Regulat follow-up contact"});
        }
    }
}
