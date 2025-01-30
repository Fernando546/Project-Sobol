using System;
using System.Windows.Forms;

namespace CRM.Helpers
{

    internal partial class LoginControl : UserControl
    {
        private LoginData _loginData;
        private Main _parent;
        private bool _debug = true;

        internal LoginControl(LoginData loginData, Main parent)
        {
            InitializeComponent();
            _loginData = loginData;
            _parent = parent;
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            if (_debug)
            {
                Program.DATABASE_SOURCE = "Server=DESKTOP-N5TKGGQ\\SIWZPL8;Database=DB_CRM;Integrated Security=True;";
            }
            else
            {
                Program.DATABASE_SOURCE = "Server=" + TXTB_Server + ";Database=" + TXTB_Database + ";Integrated Security=True;";
            }
            var loginForm = new LoginForm(ref _loginData);
            loginForm.ShowDialog();

            if (_loginData.loginSuccess == true)
            {
                _parent.InitializeAppInterface();
                Dispose();
            }
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
