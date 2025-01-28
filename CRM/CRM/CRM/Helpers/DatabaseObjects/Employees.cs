using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Helpers.DatabaseObjects
{
    internal class Employees
    {
        internal SqlInt64 ID;
        internal SqlBoolean Admin;
        internal string Username;
        internal string Password;
    }
}
