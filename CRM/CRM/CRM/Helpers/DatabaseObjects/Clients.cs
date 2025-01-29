using System.Data.SqlTypes;

namespace CRM.Helpers.DatabaseObjects
{
    internal class Clients
    {
        internal SqlInt32 ID;
        internal string Name;
        internal SqlDateTime LastContact;
        internal string Phone;
        internal string EMail;
    }
}
