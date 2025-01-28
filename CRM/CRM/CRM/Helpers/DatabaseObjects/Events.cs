using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Helpers.DatabaseObjects
{
    internal class Events
    {
        internal SqlInt64 ID;
        internal SqlInt64 ClientID;
        internal SqlInt64 EmployeeID;
        internal SqlDateTime Date;
        internal char Type;
        internal string Description;
    }
}
