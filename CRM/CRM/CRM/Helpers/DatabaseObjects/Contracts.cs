using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.Helpers.DatabaseObjects
{
    internal class Contracts
    {
        internal SqlInt64 ID;
        internal SqlInt64 EmployeeID;
        internal SqlInt64 ClientID;
        internal string Type;
        internal string Name;
        internal SqlMoney Cost;
        internal SqlMoney Profit;
        internal SqlMoney FinalProfit;
        internal SqlDateTime SignDate;
        internal SqlDateTime ExpireDate;
    }
}
