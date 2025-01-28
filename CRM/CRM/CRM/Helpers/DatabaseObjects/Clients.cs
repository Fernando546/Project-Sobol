using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Helpers.DatabaseObjects
{
    internal class Clients
    {
        internal SqlInt64 ID;
        internal string Name;
        internal SqlDateTime LastContact;
        internal string Phone;
        internal string EMail;
    }
}
