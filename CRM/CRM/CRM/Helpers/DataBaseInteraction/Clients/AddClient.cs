using System;
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
                client.ID = 0; // change
                client.Name = TXTB_Name.Text;
                client.LastContact = SqlDateTime.Parse(TXTB_LastContact.Text);
                client.Phone = TXTB_Phone.Text;
                client.EMail = TXTB_EMail.Text;

                DBAddQuery(client);
            }
        }

        private bool ValidateData()
        {
            if (TXTB_Name.Text == string.Empty)
            {
                MessageBox.Show("Name field should be filled");
                return false;
            }
            else if (ValidateDate(TXTB_LastContact.Text))
            {
                MessageBox.Show("Date has incorrect format, should be: [yyyy-MM-dd]");
                return false;
            }
            else if (ValidatePhone(TXTB_Phone.Text))
            {
                MessageBox.Show("Phone number is incorrect");
                return false;
            }
            else if (ValidateEmail(TXTB_EMail.Text))
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

        private void DBAddQuery(DatabaseObjects.Clients client)
        {
            throw new NotImplementedException();
        }  
    }
}
