using DevExpress.Skins;
using DevExpress.UserSkins;
using marketautomation.casier;
using marketautomation.Clinet;
using marketautomation.Employee;
using marketautomation.Fiche;
using marketautomation.Finance;
using marketautomation.Other;
using marketautomation.Stock;
using marketautomation.Tables;
using marketautomation.Unit;
using marketautomation.watier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace marketautomation
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
            Application.Run(new frmMain());
        }
    }
}