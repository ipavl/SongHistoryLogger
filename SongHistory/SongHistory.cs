﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SongHistory
{
    public partial class SongHistory : Form
    {
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
    }
}