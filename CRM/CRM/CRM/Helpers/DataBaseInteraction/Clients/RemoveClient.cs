using System;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Clients
{
    public partial class RemoveClient : Form
    {
        public RemoveClient()
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
            string clientID = TXTB_ID.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(clientID))
            {
                MessageBox.Show("Client ID cannot be empty");
                return;
            }

            if (!int.TryParse(clientID, out int numericClientId) || numericClientId <= 0)
            {
                MessageBox.Show("Client ID must be a valid positive number");
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete client with ID: {numericClientId}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                DBRemoveQuery(numericClientId);
                MessageBox.Show("Client deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DBRemoveQuery(int id)
        {
            throw new NotImplementedException();
        }
    }
}
