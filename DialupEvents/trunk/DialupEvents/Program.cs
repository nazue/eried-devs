using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DialupEvents.Properties;

namespace DialupEvents
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*string language = "en-US";
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
            if (!Convert.ToBoolean(Application.CommonAppDataRegistry.GetValue("LicenseAccepted", 0).ToString()))
            {
                FormLicense licenseWindow = new FormLicense();
                licenseWindow.ShowDialog();
            }*/
            Application.Run(new FormMain());
        }
    }
}