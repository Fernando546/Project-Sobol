using System.Data.SqlTypes;

namespace CRM.Helpers.DatabaseObjects
{
    internal class Employees
    {
        internal SqlInt32 ID;
        internal SqlBoolean Admin;
        internal string Username;
        internal string Password;
    }
}
