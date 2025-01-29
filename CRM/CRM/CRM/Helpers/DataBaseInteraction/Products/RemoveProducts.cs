using System;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Products
{
    public partial class RemoveProducts : Form
    {
        public RemoveProducts()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Remove_Click(object sender, EventArgs e)
        {
            string productID = TXTB_ID.Text.Trim();

            if (string.IsNullOrWhiteSpace(productID))
            {
                MessageBox.Show("Product ID cannot be empty");
                return;
            }

            if (!int.TryParse(productID, out int numericProductID) || numericProductID <= 0)
            {
                MessageBox.Show("Product ID must be a valid positive number");
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete product with ID: {numericProductID}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                DBRemoveQuery(numericProductID);
                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DBRemoveQuery(int id)
        {
            throw new NotImplementedException();
        }
    }
}
