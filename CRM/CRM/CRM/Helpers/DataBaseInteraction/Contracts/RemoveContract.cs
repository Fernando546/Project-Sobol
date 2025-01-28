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
            //popup czy na pewno
            if (true)
            {
                //sql query
            }
        }
    }
}
