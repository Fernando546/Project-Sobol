using CRM.Helpers;
using CRM.Helpers.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Main : Form
    {
        private LoginData _loginData;
        private LoginControl _loginControl;
        private ClientManager _clientManager;
        private ContractManager _contractManager;
        private EventManager _eventManager;
        private ProductManager _productManager;
        private UserManager _userManager;

        public Main()
        {
            InitializeComponent();

            _loginData = new LoginData();
            _loginControl = new LoginControl(_loginData, this);
            _loginControl.Parent = this;
            _loginControl.Show();
        }

        internal void InitializeAppInterface()
        {
            menuStrip.Visible = true;

            _clientManager = new ClientManager(_loginData.isAdmin);
            _contractManager = new ContractManager(_loginData.isAdmin, _loginData.ID);
            _eventManager = new EventManager(_loginData.isAdmin, _loginData.ID);
            _productManager = new ProductManager(_loginData.isAdmin, _loginData.ID);
            _userManager = new UserManager();

            _contractManager.Parent = this;
            _clientManager.Parent = this;
            _eventManager.Parent = this;
            _productManager.Parent = this;
            _userManager.Parent = this;

            HideManagers();
        }

        #region Tool Bar
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void manageContractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideManagers();
            _contractManager.Show();
            _contractManager.QueryDBAndFillTable();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideManagers();
            _productManager.Show();
            _productManager.QueryDBAndFillTable();
        }

        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideManagers();
            _clientManager.Show();
            _clientManager.QueryDBAndFillTable();
        }

        private void manageEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideManagers();
            _eventManager.Show();
            _eventManager.QueryDBAndFillTable();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_loginData.isAdmin)
            {
                MessageBox.Show("Clients tab requires administator privilages\nContact your database administrator for further instructions");
            }
            else
            {
                HideManagers();
                _userManager.Show();
                _userManager.QueryDBAndFillTable();
            }
        }

        private void HideManagers()
        {
            _clientManager.Hide();
            _contractManager.Hide();
            _eventManager.Hide();
            _productManager.Hide();
            _userManager.Hide();
        }
        #endregion

    }
}
