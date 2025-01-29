using System;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Contracts
{
    public partial class RemoveContract : Form
    {
        public RemoveContract()
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
            string contractID = TXTB_ID.Text.Trim();

            if (string.IsNullOrWhiteSpace(contractID))
            {
                MessageBox.Show("Contract ID cannot be empty");
                return;
            }

            if (!int.TryParse(contractID, out int numericContractID) || numericContractID <= 0)
            {
                MessageBox.Show("Contract ID must be a valid positive number");
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete contract with ID: {numericContractID}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                DBRemoveQuery(numericContractID);
                MessageBox.Show("Contract deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DBRemoveQuery(int id)
        {
            throw new NotImplementedException();
        }
    }
}
