using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Helpers.DataBaseInteraction.Clients
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            //id auto inkrementacja? + walidacja
            DatabaseObjects.Clients client = new DatabaseObjects.Clients();
            client.Name = TXTB_Name.Text;
           // client.LastContact = TXTB_LastContact.Text;
            client.Phone = TXTB_Phone.Text;
            client.EMail = TXTB_EMail.Text;
        }
    }
}
