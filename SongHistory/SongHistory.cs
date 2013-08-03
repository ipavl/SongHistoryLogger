/* 
 * SongHistory.cs
 * Date: July 7th, 2013
 * 
 * Copyright (c)2013 ipavl. All rights reserved.
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
                        outFile.WriteLine("Playlist: " + iTunes.CurrentPlaylist.Name);
                        // Create table header
                        outFile.WriteLine("<table border=\"1\" width=\"100%\">");
                        outFile.WriteLine("<tr>");

                        // Log time
                        outFile.WriteLine("<th width=\"12%\">");
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
                            outFile.WriteLine("<th width=\"8%\">");
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
                            outFile.WriteLine("<th width=\"10%\">");
                            outFile.WriteLine("Genre");
                            outFile.WriteLine("</th>");
                        }

                        // Song lookup
                        if (chkLookup.Checked)
                        {
                            outFile.WriteLine("<th width=\"20%\">");
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
                        outFile.WriteLine("<table>");

                        tmrUpdateFile.Enabled = false;
                        grpOptions.Enabled = true;
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
    }
}