/*
 *  Song History Logger
 * 
 *  This program will allow a user to save their iTunes playlist history to file.
 *  Copyright (C) 2013  ipavl <https://www.github.com/ipavl/SongHistoryLogger>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *  
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *  
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        // These will be used for checking to see if we need to update the file.
        private String lastSong;
        private String lastArtist;
        private String lastAlbum;
        private String lastDuration;

        private String lastPlaylist;

        public SongHistory()
        {
            InitializeComponent();
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdFolderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtOutputFile.Text = fbdFolderBrowser.SelectedPath;
            }
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            // Don't enable the logging checkbox if we don't have a output folder speciied.
            if (txtOutputFile.Text.Trim() == "")
            {
                chkLog.Enabled = false;
            }
            else
            {
                chkLog.Enabled = true;
            }

            try
            {
                grpTrackInfo.ForeColor = Color.Blue;
                grpTrackInfo.Text = "Current Track Information";
                lblTrack.Text = "Track: " + iTunes.CurrentTrack.Name;
                lblArtist.Text = "Artist: " + iTunes.CurrentTrack.Artist;
                lblAlbum.Text = "Album: " + iTunes.CurrentTrack.Album;
                lblDuration.Text = "Duration: " + iTunes.CurrentTrack.Time;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                grpTrackInfo.ForeColor = Color.Red;
                grpTrackInfo.Text = "iTunes isn't running or no track is selected!";
            }
        }

        /*
         * Writes song information to file every minute when enabled via the logging checkbox
         */
        private void tmrUpdateFile_Tick(object sender, EventArgs e)
        {
            StreamWriter outFile = new StreamWriter(txtOutputFile.Text + "\\songhistory.htm", true);

            try
            {
                if (txtOutputFile.Text.Trim() == "")
                {
                    grpTrackInfo.ForeColor = Color.Red;
                    grpTrackInfo.Text = "No output folder is selected!";
                    tmrUpdateFile.Enabled = false;
                    chkLog.Checked = false;
                }
                else
                {
                    grpTrackInfo.ForeColor = Color.Blue;
                    grpTrackInfo.Text = "Current Track Information";

                    if (isSongChanged())    // only update if the song is not the same as the last one we logged
                    {
                        // Output song information as HTML table row
                        outFile.WriteLine("<tr>");
                        outFile.WriteLine("<td>");
                        outFile.WriteLine(DateTime.Now);
                        outFile.WriteLine("</td>");

                        // Song name
                        if (chkName.Checked)
                        {
                            outFile.WriteLine("<td>");
                            outFile.WriteLine(iTunes.CurrentTrack.Name);
                            outFile.WriteLine("</td>");
                        }

                        // Song duration
                        if (chkDuration.Checked)
                        {
                            outFile.WriteLine("<td>");
                            outFile.WriteLine(iTunes.CurrentTrack.Time);
                            outFile.WriteLine("</td>");
                        }

                        // Song artist
                        if (chkArtist.Checked)
                        {
                            outFile.WriteLine("<td>");
                            outFile.WriteLine(iTunes.CurrentTrack.Artist);
                            outFile.WriteLine("</td>");
                        }


                        // Album
                        if (chkAlbum.Checked)
                        {
                            outFile.WriteLine("<td>");
                            outFile.WriteLine(iTunes.CurrentTrack.Album);
                            outFile.WriteLine("</td>");
                        }

                        // Genre
                        if (chkGenre.Checked)
                        {
                            outFile.WriteLine("<td>");
                            outFile.WriteLine(iTunes.CurrentTrack.Genre);
                            outFile.WriteLine("</td>");
                        }

                        // Song lookup
                        if (chkLookup.Checked)
                        {
                            outFile.WriteLine("<td>");
                            outFile.WriteLine("<a href=\"https://www.youtube.com/results?search_query=" +
                                iTunes.CurrentTrack.Artist + " " + iTunes.CurrentTrack.Name + " " +
                                iTunes.CurrentTrack.Album + "\">Lookup</a>");
                            outFile.WriteLine("</td>");
                        }

                        outFile.WriteLine("</tr>");

                        // Update last logged at label
                        lblLastLogged.Text = "Last logged at: " + String.Format("{0:MM/dd/yy hh:mm:ss tt}", DateTime.Now);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                tmrUpdateFile.Enabled = false;
                chkLog.Checked = false;
            }
            finally
            {
                outFile.Close();
            }
        }

        /*
         * Toggles the status of if we should be logging song data every minute or not
         */
        private void chkLog_CheckedChanged(object sender, EventArgs e)
        {
            Directory.CreateDirectory(txtOutputFile.Text);  // make sure the output folder exists
            StreamWriter outFile = new StreamWriter(txtOutputFile.Text + "\\songhistory.htm", true);

            try
            {
                if (txtOutputFile.Text.Trim() == "")
                {
                    grpTrackInfo.ForeColor = Color.Red;
                    grpTrackInfo.Text = "No output folder is selected!";
                    tmrUpdateFile.Enabled = false;
                    chkLog.Checked = false;
                }
                else
                {
                    grpTrackInfo.ForeColor = Color.Blue;
                    grpTrackInfo.Text = "Current Track Information";

                    if (!tmrUpdateFile.Enabled)
                    {
                        // Disable the folder selection controls
                        txtOutputFile.ReadOnly = true;
                        cmdBrowse.Enabled = false;

                        // Get playlist information (TODO: Make this update on playlist change)
                        lastPlaylist = iTunes.CurrentPlaylist.Name;
                        outFile.WriteLine("Playlist: " + lastPlaylist + " (" + 
                            iTunes.CurrentPlaylist.Time + " hours long)");

                        // Create table header
                        outFile.WriteLine("<table border=\"1\" width=\"100%\">");
                        outFile.WriteLine("<tr>");

                        // Log time
                        outFile.WriteLine("<th width=\"15%\">");
                        outFile.WriteLine("Time");
                        outFile.WriteLine("</th>");

                        // Song name
                        if (chkName.Checked)
                        {
                            outFile.WriteLine("<th width=\"20%\">");
                            outFile.WriteLine("Song");
                            outFile.WriteLine("</th>");
                        }

                        // Song duration
                        if (chkDuration.Checked)
                        {
                            outFile.WriteLine("<th width=\"5%\">");
                            outFile.WriteLine("Duration");
                            outFile.WriteLine("</th>");
                        }

                        // Song artist
                        if (chkArtist.Checked)
                        {
                            outFile.WriteLine("<th width=\"15%\">");
                            outFile.WriteLine("Artist");
                            outFile.WriteLine("</th>");
                        }

                        // Song album
                        if (chkAlbum.Checked)
                        {
                            outFile.WriteLine("<th width=\"15%\">");
                            outFile.WriteLine("Album");
                            outFile.WriteLine("</th>");
                        }

                        // Genre
                        if (chkGenre.Checked)
                        {
                            outFile.WriteLine("<th width=\"15%\">");
                            outFile.WriteLine("Genre");
                            outFile.WriteLine("</th>");
                        }

                        // Song lookup
                        if (chkLookup.Checked)
                        {
                            outFile.WriteLine("<th width=\"10%\">");
                            outFile.WriteLine("YouTube Search");
                            outFile.WriteLine("</th>");
                            outFile.WriteLine("</tr>");
                        }

                        tmrUpdateFile.Enabled = true;
                        grpOptions.Enabled = false; // disable options since changing them will make the table weird
                    }
                    else
                    {
                        // End table
                        outFile.WriteLine("</table>");

                        tmrUpdateFile.Enabled = false;
                        txtOutputFile.ReadOnly = false;
                        grpOptions.Enabled = true;
                        cmdBrowse.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                tmrUpdateFile.Enabled = false;
                chkLog.Checked = false;
            }
            finally
            {
                outFile.Close();
            }
        }

        /*
         * This function will compare the current song to the last one and return whether or not it is different.
         */
        private Boolean isSongChanged()
        {
            if (iTunes.CurrentTrack.Name != lastSong || iTunes.CurrentTrack.Artist != lastArtist ||
                iTunes.CurrentTrack.Album != lastAlbum || iTunes.CurrentTrack.Time != lastDuration)
            {
                // Save the new song data for later comparison
                lastSong = iTunes.CurrentTrack.Name;
                lastArtist = iTunes.CurrentTrack.Artist;
                lastAlbum = iTunes.CurrentTrack.Album;
                lastDuration = iTunes.CurrentTrack.Time;
                return true;
            }
            else
            {
                // The song is the same
                return false;
            }
        }

        /*
         * Minimize/restore to/from the system tray if enabled.
         */
        private void SongHistory_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                if (chkMinimize.Checked)
                {
                    notifyIcon.Visible = true;
                    notifyIcon.ShowBalloonTip(3000);
                    this.ShowInTaskbar = false;
                }
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }

        /*
         * Notify icon right click options 
         */
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}