using System;
using System.Windows.Forms;

namespace TorpTarnak
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static public Dashboard dashboard;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dashboard = new Dashboard();
            Application.Run(dashboard);
        }
    }
}
