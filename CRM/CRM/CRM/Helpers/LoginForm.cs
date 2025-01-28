using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Helpers
{
    internal partial class LoginForm : Form
    {
        private LoginData _loginData;

        internal LoginForm(ref LoginData loginData)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _loginData = loginData;
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            //send query to db
            if (true)
            {
                _loginData.SetData("testname", false, 1, true);
                Close();
            }
            else
            {
                //Account with these credentials doesn't exist
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
