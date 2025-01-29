using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Events
{
    public partial class RemoveEvent : Form
    {
        public RemoveEvent()
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
            string eventID = TXTB_ID.Text.Trim();

            if (string.IsNullOrWhiteSpace(eventID))
            {
                MessageBox.Show("Event ID cannot be empty");
                return;
            }

            if (!int.TryParse(eventID, out int numericEventID) || numericEventID <= 0)
            {
                MessageBox.Show("Event ID must be a valid positive number");
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete event with ID: {numericEventID}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                DBRemoveQuery(numericEventID);
                MessageBox.Show("Event deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DBRemoveQuery(int id)
        {
            throw new NotImplementedException();
        }
    }
}
