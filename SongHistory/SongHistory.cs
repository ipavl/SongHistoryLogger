using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTunesLib;

namespace SongHistory
{
    public partial class SongHistory : Form
    {
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
    }
}