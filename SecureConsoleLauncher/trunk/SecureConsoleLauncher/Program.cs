using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SecureConsoleLauncher.Properties;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SecureConsoleLauncher
{
    static class Program
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Boolean runningAsSystem = Environment.UserName==Settings.Default.SystemAccount;

            // Sólo permitir una instancia de la aplicación cuando seamos SYSTEM
            if (runningAsSystem)
            {
                bool instance = false;
                Mutex mutex = new Mutex(true, Application.ProductName, out instance);

                if (!instance)
                {
                    // Buscar instancias de este mismo proceso
                    Process c = Process.GetCurrentProcess();

                    Boolean firstSeen = false;
                    foreach (Process p in Process.GetProcessesByName(c.ProcessName))
                        if (p.Id != c.Id)
                            if (!firstSeen)
                            {
                                firstSeen = true;
                                SetForegroundWindow(p.MainWindowHandle);
                            }
                            else
                                p.Kill();

                    return;
                }
                else
                {
                    Application.Run(new FormMain());
                    GC.KeepAlive(mutex);
                }
            }
            else
            {
                String[] CommandLineArgs = Environment.GetCommandLineArgs();

                // Ejecutar la aplicación cuando no estamos en el escritorio seguro
                try
                {
                    Process.Start(Settings.Default.RunNormally,
                        String.Join(" ", CommandLineArgs, 1, CommandLineArgs.GetUpperBound(0)));
                } catch { }
            }
        }
    }
}