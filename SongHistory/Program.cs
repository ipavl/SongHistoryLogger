using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongHistory
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process[] iTunesProcess = Process.GetProcessesByName("itunes");

            if (!File.Exists("Interop.iTunesLib.dll"))
            {
                MessageBox.Show("Interop.iTunesLib.dll could not be found. Please place it in the same folder as " +
                    "SongHistory.exe and restart the application.", "Error");
            }
            else
            {
                if (iTunesProcess.Length == 0)  // If iTunes isn't running, try and start it
                {
                    if (File.Exists("c:\\progra~1\\iTunes\\iTunes.exe"))    // Try from the default install location
                    {
                        Process.Start("c:\\progra~1\\iTunes\\iTunes.exe");
                    }
                    else
                    {
                        MessageBox.Show("iTunes does not appear to be running and could not be launched by the program. " +
                            "Please manually start iTunes and restart the application.");
                        Application.Exit();
                    }
                }

                // If everything is good, launch the application
                Application.Run(new SongHistory());
            }
        }
    }
}
