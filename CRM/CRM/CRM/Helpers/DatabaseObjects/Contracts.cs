using System.Data.SqlTypes;

namespace CRM.Helpers.DatabaseObjects
{
    internal class Contracts
    {
        internal SqlInt32 ID;
        internal SqlInt32 EmployeeID;
        internal SqlInt32 ClientID;
        internal string Type;
        internal string Name;
        internal SqlMoney Cost;
        internal SqlMoney Profit;
        internal SqlMoney FinalProfit;
        internal SqlDateTime SignDate;
        internal SqlDateTime ExpireDate;
    }
}
