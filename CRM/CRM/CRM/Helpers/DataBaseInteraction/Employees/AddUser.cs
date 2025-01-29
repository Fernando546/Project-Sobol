using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Users
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                DatabaseObjects.Employees user = new DatabaseObjects.Employees();

                user.Username = TXTB_Username.Text;
                user.Password = TXTB_Password.Text;

                DBAddQuery(user);
            }
        }

        private bool ValidateData()
        {
            if (ValidateUsername(TXTB_Username.Text))
            {
                MessageBox.Show("Invalid username format: should be 3-20 characters long and contain only letters, digits, and underscores.");
                return false;
            }
            else if (ValidatePassword(TXTB_Password.Text))
            {
                MessageBox.Show("Invalid password: must be at least 8 characters long and must contain at least one uppercase and lowercase letter, at least one digit, at least one special character");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidateUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            return Regex.IsMatch(username, @"^[a-zA-Z0-9_]{3,20}$");
        }

        public bool ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
            {
                return false;
            }

            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
        }

        private void DBAddQuery(DatabaseObjects.Employees user)
        {
            throw new NotImplementedException();
        }
    }
}
