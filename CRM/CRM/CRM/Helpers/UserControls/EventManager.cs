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
            var addEvent = new AddEvent();
            addEvent.ShowDialog();
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
                List<Events> events;

                if (_isAdmin)
                {
                    events = DataBaseGetter.GetEventsByClient((int)_clients[CMBX_Clients.SelectedIndex].ID.Value);
                }
                else
                {
                    events = DataBaseGetter.GetEventsByUserAndClient(_userID, (int)_clients[CMBX_Clients.SelectedIndex].ID.Value);
                }

                foreach (var event_ in events)
                {


                    //dodawanie do tabeli
                }
            }
        }

        private void CMBX_Clients_SelectionChangeCommitted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
