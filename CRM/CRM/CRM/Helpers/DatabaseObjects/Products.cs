using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace CRM.Helpers.DatabaseObjects
{
    internal class Products
    {
        internal SqlInt64 ID;
        internal SqlInt64 ContractID;
        internal string Name;
        internal SqlMoney Cost;
        internal SqlBoolean Type;
        internal SqlInt64 Amount;
    }
}
