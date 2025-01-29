using CRM.Helpers.DatabaseObjects;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Products
{
    public partial class AddProductName : Form
    {
        public AddProductName()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if(TXTB_Name.Text == string.Empty)
            {
                MessageBox.Show("Name must be at least 3 characters long");
                return;
            }

            var listOfNames = DataBaseGetter.GetProductNames();
            if (listOfNames.Contains(TXTB_Name.Text))
            {
                MessageBox.Show("Product already exists");
                return;
            }

            if (DBAddQuery(TXTB_Name.Text))
            {
                MessageBox.Show("Product name added successfully");
                Close();
            }
            else
            {
                MessageBox.Show("Error adding product name");
            }

        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool DBAddQuery(string name)
        {
            string query = "INSERT INTO ProductNames (ID, Name) VALUES (@ID, @Name)";

            using (SqlConnection conn = new SqlConnection(Program.DATABASE_SOURCE))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ID", DataBaseGetter.GetMaxID("ProductNames") + 1);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.ExecuteNonQuery();
            }
            return true;
        }
    }
}
