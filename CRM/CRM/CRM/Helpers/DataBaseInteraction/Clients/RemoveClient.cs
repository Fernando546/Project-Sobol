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
            if (true)
            {
                //sql query
            }
        }
    }
}
