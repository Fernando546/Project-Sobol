using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Clients
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            //id auto inkrementacja? + walidacja
            if (ValidateData())
            {
                DatabaseObjects.Clients client = new DatabaseObjects.Clients();
                client.ID = DataBaseGetter.GetMaxID("Clients") + 1;
                client.Name = TXTB_Name.Text;
                client.LastContact = SqlDateTime.Parse(TXTB_LastContact.Text);
                client.Phone = TXTB_Phone.Text;
                client.EMail = TXTB_EMail.Text;

                if(DBAddQuery(client))
                {
                    MessageBox.Show("Client added successfully");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error adding client");
                }
                
            }
        }

        private bool ValidateData()
        {
            if (TXTB_Name.Text == string.Empty)
            {
                MessageBox.Show("Name field should be filled");
                return false;
            }
            else if (!ValidateDate(TXTB_LastContact.Text))
            {
                MessageBox.Show("Date has incorrect format, should be: [yyyy-MM-dd]");
                return false;
            }
            else if (!ValidatePhone(TXTB_Phone.Text))
            {
                MessageBox.Show("Phone number is incorrect");
                return false;
            }
            else if (!ValidateEmail(TXTB_EMail.Text))
            {
                MessageBox.Show("Email address is incorrect");
                return false;
            }
            else
            {
                return true;
            }
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

        private bool ValidatePhone(string phone)
        {
            if(phone.Length > 0)
            {
                if (phone.ElementAt(0) == '+')
                {
                    phone = phone.Substring(1);
                }

                if (!int.TryParse(phone, out var result))
                {
                    return false;
                }
                else if (result < 0)
                {
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }   
        }

        private bool ValidateEmail(string email)
        {
            if(email.EndsWith("."))
            {
                return false;
            }

            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool DBAddQuery(DatabaseObjects.Clients client)
        {
            string query = "INSERT INTO Clients (ID, Name, LastContact, Phone, EMail) VALUES (@ID, @Name, @LastContact, @Phone, @EMail)";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", client.ID);
                cmd.Parameters.AddWithValue("@Name", client.Name);
                cmd.Parameters.AddWithValue("@LastContact", client.LastContact);
                cmd.Parameters.AddWithValue("@Phone", client.Phone);
                cmd.Parameters.AddWithValue("@EMail", client.EMail);
                cmd.ExecuteNonQuery();
            }

            return true;
        }
    }
}
