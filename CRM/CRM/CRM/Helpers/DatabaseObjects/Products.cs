using System.Data.SqlTypes;

namespace CRM.Helpers.DatabaseObjects
{
    internal class Products
    {
        internal SqlInt32 ID;
        internal SqlInt32 ContractID;
        internal string Name;
        internal SqlMoney Cost;
        internal SqlBoolean Type;
        internal SqlInt32 Amount;
    }
}
