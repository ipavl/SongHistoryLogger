using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTunesLib;

namespace SongHistory
{
    public partial class SongHistory : Form
    {
        // The iTunes interface
        IiTunes iTunes = new iTunesAppClass();

        public SongHistory()
        {
            InitializeComponent();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutputFile.Text = fbdFolderBrowser.SelectedPath + "\\songhistory.htm";
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            lblTrack.Text = "Track: " + iTunes.CurrentTrack.Name;
            lblArtist.Text = "Artist: " + iTunes.CurrentTrack.Artist;
            lblAlbum.Text = "Album: " + iTunes.CurrentTrack.Album;
            lblDuration.Text = "Duration: " + iTunes.CurrentTrack.Time;
        }

        /*
         * Writes song information to file every minute when enabled via the logging checkbox
         */
        private void tmrUpdateFile_Tick(object sender, EventArgs e)
        {
            StreamWriter outFile = new StreamWriter(txtOutputFile.Text, true);

            outFile.WriteLine("<tr>");
            outFile.WriteLine("<td>");
            outFile.WriteLine(DateTime.Now);
            outFile.WriteLine("</td>");
            outFile.WriteLine("<td>");
            outFile.WriteLine(iTunes.CurrentTrack.Name);
            outFile.WriteLine("</td>");
            outFile.WriteLine("<td>");
            outFile.WriteLine(iTunes.CurrentTrack.Time);
            outFile.WriteLine("</td>");
            outFile.WriteLine("<td>");
            outFile.WriteLine(iTunes.CurrentTrack.Artist);
            outFile.WriteLine("</td>");
            outFile.WriteLine("<td>");
            outFile.WriteLine(iTunes.CurrentTrack.Album);
            outFile.WriteLine("</td>");
            outFile.WriteLine("</tr>");
            outFile.Close();

            // Update last logged at label
            lblLastLogged.Text = "Last logged at: " + String.Format("{0:MM/dd/yy hh:mm:ss tt}", DateTime.Now);
        }

        /*
         * Toggles the status of if we should be logging song data every minute or not
         */
        private void chkLog_CheckedChanged(object sender, EventArgs e)
        {
            StreamWriter outFile = new StreamWriter(txtOutputFile.Text, true);

            if (!tmrUpdateFile.Enabled)
            {
                // Create table header
                outFile.WriteLine("<table border=\"1\" width=\"100%\">");
                outFile.WriteLine("<tr>");
                outFile.WriteLine("<th width=\"10%\">");
                outFile.WriteLine("Time");
                outFile.WriteLine("</th>");
                outFile.WriteLine("<th width=\"20%\">");
                outFile.WriteLine("Song");
                outFile.WriteLine("</th>");
                outFile.WriteLine("<th width=\"5%\">");
                outFile.WriteLine("Duration");
                outFile.WriteLine("</th>");
                outFile.WriteLine("<th width=\"20%\">");
                outFile.WriteLine("Artist");
                outFile.WriteLine("</th>");
                outFile.WriteLine("<th width=\"20%\">");
                outFile.WriteLine("Album");
                outFile.WriteLine("</th>");
                outFile.WriteLine("</tr>");
                outFile.Close();

                tmrUpdateFile.Enabled = true;
            }
            else
            {
                // End table
                outFile.WriteLine("<table>");
                outFile.Close();

                tmrUpdateFile.Enabled = false;
            }
        }
    }
}