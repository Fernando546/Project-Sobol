using System;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Users
{
    public partial class RemoveUser : Form
    {
        public RemoveUser()
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
            string userID = TXTB_ID.Text.Trim();

            if (string.IsNullOrWhiteSpace(userID))
            {
                MessageBox.Show("User ID cannot be empty");
                return;
            }

            if (!int.TryParse(userID, out int numericUserID) || numericUserID <= 0)
            {
                MessageBox.Show("User ID must be a valid positive number");
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete user with ID: {numericUserID}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                DBRemoveQuery(numericUserID);
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DBRemoveQuery(int id)
        {
            throw new NotImplementedException();
        }
    }
}
