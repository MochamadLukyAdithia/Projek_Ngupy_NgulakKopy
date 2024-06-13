using Ngupy_NgulakKopy.Views.Pengepul;
using Ngupy_NgulakKopy.Views.Pengepul.Dashboard;
using Ngupy_NgulakKopy.Views.Petani;
using Ngupy_NgulakKopy.Views.Petani.Dashboard;
using Ngupy_NgulakKopy.Views.Pusat.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ngupy_NgulakKopy
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DashboardPengepul());
        }
    }
}
