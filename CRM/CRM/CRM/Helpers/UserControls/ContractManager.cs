using CRM.Helpers.DataBaseInteraction;
using CRM.Helpers.DataBaseInteraction.Contracts;
using CRM.Helpers.DataBaseInteraction.Events;
using CRM.Helpers.DatabaseObjects;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRM.Helpers.UserControls
{
    public partial class ContractManager : UserControl
    {
        private bool _isAdmin;
        private List<Clients> _clients;
        private int _userID;

        public ContractManager(bool isAdmin, int userID)
        {
            InitializeComponent();

            _isAdmin = isAdmin;
            _userID = userID;

            if (!isAdmin)
            {
                BTN_Remove.Visible = false;
            }
        }

        private void BTN_Add_Click(object sender, System.EventArgs e)
        {
            var removeContract = new RemoveContract();
            removeContract.ShowDialog();
            QueryDBAndFillTable();
        }

        private void BTN_Remove_Click(object sender, System.EventArgs e)
        {
            var addContract = new AddContract();
            addContract.ShowDialog();
            QueryDBAndFillTable();
        }

        private void QueryDBforClients()
        {
            CMBX_Clients.Items.Clear();
            CMBX_Clients.Text = "";
            CMBX_Clients.SelectedIndex = -1;

            _clients = new List<Clients>();

            _clients = DataBaseGetter.GetClients();

            foreach (var client in _clients)
            {
                CMBX_Clients.Items.Add(client.Name);
            }
        }

        internal void QueryDBAndFillTable() //po kliencie i emp
        {
            QueryDBforClients();

            if (CMBX_Clients.SelectedIndex >= 0)
            {
                List<Contracts> contracts;

                if(_isAdmin)
                {
                    contracts = DataBaseGetter.GetContractsByClient((int)_clients[CMBX_Clients.SelectedIndex].ID.Value);
                }
                else
                {
                    contracts = DataBaseGetter.GetContractsByUserAndClient(_userID, (int)_clients[CMBX_Clients.SelectedIndex].ID.Value);
                }

                foreach (var contract in contracts)
                {
                    //dodawanie do tabeli
                }
            }
        }
    }
}
