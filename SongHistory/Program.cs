using System;
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

            if(File.Exists("Interop.iTunesLib.dll"))
                Application.Run(new SongHistory());
            else
                MessageBox.Show("Interop.iTunesLib.dll could not be found. Please place it in the same folder as " +
                    "SongHistory.exe and restart the application.", "Error");
        }
    }
}
