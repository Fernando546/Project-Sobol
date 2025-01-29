using CRM.Helpers.DataBaseInteraction;
using CRM.Helpers.DataBaseInteraction.Clients;
using CRM.Helpers.DataBaseInteraction.Contracts;
using CRM.Helpers.DatabaseObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Helpers.UserControls
{
    public partial class ClientManager : UserControl
    {
        public ClientManager(bool isAdmin)
        {
            InitializeComponent();

            if (!isAdmin)
            { 
                BTN_Remove.Visible = false;
            }

        }

        private void BTN_Remove_Click(object sender, EventArgs e)
        {
            var removeClient = new RemoveClient();
            removeClient.ShowDialog();
            QueryDBAndFillTable();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            var addClient = new AddClient();
            addClient.ShowDialog();
            QueryDBAndFillTable();
        }

        internal void QueryDBAndFillTable()
        {
            var clients = DataBaseGetter.GetClients();

            if (clients != null)
            {
                DGV_Clients.Rows.Clear();

                foreach (var client in clients)
                {
                    DGV_Clients.Rows.Add(client.ID.ToString(), client.Name, client.LastContact.ToString(), client.Phone, client.EMail);
                }
            }
        }
    }
}
