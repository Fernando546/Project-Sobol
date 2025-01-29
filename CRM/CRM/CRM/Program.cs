using System;
using System.Windows.Forms;

namespace CRM
{
    internal static class Program
    {
        internal const string DATABASE_SOURCE = "Server=DESKTOP-N5TKGGQ\\SIWZPL8;Database=DB_CRM;Integrated Security=True;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
