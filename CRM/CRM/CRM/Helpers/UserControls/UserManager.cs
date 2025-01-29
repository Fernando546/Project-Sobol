using CRM.Helpers.DataBaseInteraction;
using CRM.Helpers.DataBaseInteraction.Clients;
using CRM.Helpers.DataBaseInteraction.Users;
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
    public partial class UserManager : UserControl
    {

        //should query DB to get all users and show them in table on startup and on add/delete user
        public UserManager()
        {
            InitializeComponent();
        }

        private void BTN_Remove_Click(object sender, EventArgs e)
        {
            var removeUser = new RemoveUser();
            removeUser.ShowDialog();
            QueryDBAndFillTable();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            var addUser = new AddClient();
            addUser.ShowDialog();
            QueryDBAndFillTable();
        }

        internal void QueryDBAndFillTable()
        {
            var users = DataBaseGetter.GetEmployees();

            if (users != null)
            {
                DGV_Users.Rows.Clear();

                foreach (var user in users)
                {
                    DGV_Users.Rows.Add(user.ID.ToString(), user.Admin.ToString(), user.Username, user.Password);
                }
            }  
        }
    }
}
