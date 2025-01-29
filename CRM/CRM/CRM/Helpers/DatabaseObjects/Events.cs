using System.Data.SqlTypes;

namespace CRM.Helpers.DatabaseObjects
{
    internal class Events
    {
        internal SqlInt32 ID;
        internal SqlInt32 ClientID;
        internal SqlInt32 EmployeeID;
        internal SqlDateTime Date;
        internal char Type;
        internal string Description;
    }
}
