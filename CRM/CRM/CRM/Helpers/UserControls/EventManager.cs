using CRM.Enums;
using CRM.Helpers.DataBaseInteraction;
using CRM.Helpers.DataBaseInteraction.Events;
using CRM.Helpers.DatabaseObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CRM.Helpers.UserControls
{
    public partial class EventManager : UserControl
    {
        private bool _isAdmin;
        private List<Clients> _clients;
        private int _userID;

        public EventManager(bool isAdmin, int userID)
        {
            InitializeComponent();

            _isAdmin = isAdmin;
            _userID = userID;

            if (!isAdmin)
            {
                BTN_Remove.Visible = false;
            }
        }

        private void BTN_Remove_Click(object sender, EventArgs e)
        {
            var removeEvent = new RemoveEvent();
            removeEvent.ShowDialog();
            QueryDBAndFillTable();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (CMBX_Clients.SelectedIndex >= 0)
            { 
                Employees employee = new Employees()
                {
                    ID = _userID
                };
                var addEvent = new AddEvent(_clients[CMBX_Clients.SelectedIndex],employee);
                addEvent.ShowDialog();
                QueryDBAndFillTable();
            }
            else
            {
                MessageBox.Show("Client has to be selected first");
            }
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
                    CMBX_Clients.Items.Add(client.Name);
                }
            }
        }

        internal void QueryDBAndFillTable()
        {
            QueryDBforClients();
            FillTable();
        }

        private void CMBX_Clients_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {
            if (CMBX_Clients.SelectedIndex >= 0)
            {
                List<Events> events;

                if (_isAdmin)
                {
                    events = DataBaseGetter.GetEventsByClient((int)_clients[CMBX_Clients.SelectedIndex].ID.Value);
                }
                else
                {
                    events = DataBaseGetter.GetEventsByUserAndClient(_userID, (int)_clients[CMBX_Clients.SelectedIndex].ID.Value);
                }

                if (events != null)
                {
                    DGV_Events.Rows.Clear();

                    foreach (var event_ in events)
                    {
                        //change user id to name
                        DGV_Events.Rows.Add(event_.ID.ToString(), event_.ClientID.ToString(), event_.EmployeeID.ToString(), event_.Date.ToString(), ParseType(event_.Type),event_.Description);
                    }
                }
            }
        }

        private string ParseType(char type)
        {
            EventTypes parsedType;

            if(!Enum.TryParse<EventTypes>(type.ToString(), out parsedType))
            {
                return "Unregistered type";
            }

            switch (parsedType)
            {
                case EventTypes.DissolutionOfContract:
                    return "Dissolution of contract";

                case EventTypes.ContractPreeleminaryArrangement:
                    return "Preeliminary contract arrangement";

                case EventTypes.ContractResigning:
                    return "Resigning of contract";

                case EventTypes.ContractSigning:
                    return "Signing of contract";

                case EventTypes.EmergencyContact:
                    return "Emergency contact";

                case EventTypes.FirstContactCTE:
                    return "First contact client-employee";

                case EventTypes.FirstContactETC:
                    return "First contact employee-client";

                case EventTypes.FollowUpContact:
                    return "Regulat follow-up contact";

                default:
                    return "Unregistered type";
            }
        }
    }
}
