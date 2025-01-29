using CRM.Enums;
using CRM.Helpers.DataBaseInteraction;
using CRM.Helpers.DataBaseInteraction.Contracts;
using CRM.Helpers.DataBaseInteraction.Events;
using CRM.Helpers.DatabaseObjects;
using System;
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
            if (CMBX_Clients.SelectedIndex >= 0)
            {
                Employees employee = new Employees()
                {
                    ID = _userID
                };

                var addContract = new AddContract(_clients[CMBX_Clients.SelectedIndex],employee);
                addContract.ShowDialog();
                QueryDBAndFillTable();
            }
        }

        private void BTN_Remove_Click(object sender, System.EventArgs e)
        {
            var removeContract = new RemoveContract();
            removeContract.ShowDialog();
            QueryDBAndFillTable();  
        }

        private void QueryDBforClients()
        {
            CMBX_Clients.Items.Clear();
            CMBX_Clients.Text = "";
            CMBX_Clients.SelectedIndex = -1;

            _clients = new List<Clients>();

            _clients = DataBaseGetter.GetClients();

            if (_clients != null)
            {
                foreach (var client in _clients)
                {
                    CMBX_Clients.Items.Add(string.Concat(client.ID.ToString(), " ", client.Name));
                }
            }
        }

        internal void QueryDBAndFillTable() //po kliencie i emp
        {
            QueryDBforClients();
            FillTable();
        }

        private void CMBX_Clients_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {
            if (CMBX_Clients.SelectedIndex >= 0)
            {
                List<Contracts> contracts;

                if (_isAdmin)
                {
                    contracts = DataBaseGetter.GetContractsByClient((int)_clients[CMBX_Clients.SelectedIndex].ID.Value);
                }
                else
                {
                    contracts = DataBaseGetter.GetContractsByUserAndClient(_userID, (int)_clients[CMBX_Clients.SelectedIndex].ID.Value);
                }

                if (contracts != null)
                {
                    DGV_Contracts.Rows.Clear();

                    foreach (var contract in contracts)
                    {
                        //change user id to name
                        DGV_Contracts.Rows.Add(contract.ID.ToString(), contract.EmployeeID.ToString(), contract.ClientID.ToString(), ParseType(contract.Type), contract.Name, contract.Cost.ToString(), contract.Profit.ToString(), contract.FinalProfit.ToString(), contract.SignDate.ToString(), contract.ExpireDate.ToString());
                    }
                }
            }
        }

        private string ParseType(string type)
        {
            ContractTypes parsedType;

            if (!Enum.TryParse<ContractTypes>(type.ToString(), out parsedType))
            {
                return "Unregistered type";
            }

            switch (parsedType)
            {
                case ContractTypes.B:
                    return "Buy";

                case ContractTypes.S:
                    return "Sell";

                case ContractTypes.BS:
                    return "Buy/Sell";

                default:
                    return "Unregistered type";
            }
        }
    }
}
