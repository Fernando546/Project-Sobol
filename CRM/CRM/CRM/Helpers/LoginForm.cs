using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRM.Helpers
{
    internal partial class LoginForm : Form
    {
        private bool debug = true;
        private LoginData _loginData;

        internal LoginForm(ref LoginData loginData)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _loginData = loginData;
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            if(debug)
            {
                _loginData.SetData("test", true, 1, true);
                Close();
            }
            else
            {
                if (QueryDB())
                {
                    Close();
                }
            }
            
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool QueryDB()
        {
            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ID, Username, Admin FROM Employees WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", TXTB_Username.Text);
                        cmd.Parameters.AddWithValue("@Password", TXTB_Password.Text); // Hash the password in real applications

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If user exists
                            {
                                int userID = reader.GetInt32(0); // ID
                                string name = reader.GetString(1); // Username
                                bool Admin = reader.GetBoolean(2); // IsAdmin

                                // Call the SetData method with retrieved values
                                _loginData.SetData(name, Admin, userID, true);
                                MessageBox.Show("Login successful!");
                                return true;
                            }
                            else
                            {
                                _loginData.SetData("", false, 0, false); // Reset data if login fails
                                MessageBox.Show("Invalid username or password.");
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
