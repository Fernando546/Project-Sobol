using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Helpers
{
    internal class LoginData
    {
        private string _name;
        internal string name 
        { 
            get
            {
                return _name;
            }
            private set 
            {
                _name = value; 
            }
        }

        private bool _isAdmin;
        internal bool isAdmin
        {
            get
            {
                return _isAdmin;
            }
            private set
            {
                _isAdmin = value;
            }
        }

        private bool _loginSuccess;
        internal bool loginSuccess
        {
            get
            {
                return _loginSuccess;
            }
            private set
            {
                _loginSuccess = value;
            }
        }

        private int _ID;
        internal int ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                _ID = value;
            }
        }
       
        internal LoginData()
        {
            loginSuccess = false;
        }

        internal void SetData(string name, bool isAdmin, int ID, bool loginSuccess)
        {
            this.name = name;
            this.isAdmin = isAdmin;
            this.ID = ID;
            this.loginSuccess = loginSuccess;
        }

    }
}
