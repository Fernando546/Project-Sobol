using System;
using System.Data.SqlClient;
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

                user.ID = DataBaseGetter.GetMaxID("Employees") + 1;
                user.Username = TXTB_Username.Text;
                user.Password = TXTB_Password.Text;
                user.Admin = checkBox1.Checked;

                if (DBAddQuery(user))
                {
                    MessageBox.Show("User added successfully");
                    Close();
                }
                else
                {
                    MessageBox.Show("Error adding user");
                }
            }
        }

        private bool ValidateData()
        {
            if (!ValidateUsername(TXTB_Username.Text))
            {
                MessageBox.Show("Invalid username format: should be 3-20 characters long and contain only letters, digits, and underscores.");
                return false;
            }
            else if (!ValidatePassword(TXTB_Password.Text))
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

        private bool DBAddQuery(DatabaseObjects.Employees user)
        {
            string query = "INSERT INTO Employees (ID, Username, Password, Admin) VALUES (@ID, @Username, @Password, @Admin)";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", user.ID);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Admin", user.Admin);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
    }
}