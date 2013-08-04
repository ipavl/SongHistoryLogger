namespace SongHistory
{
    partial class SongHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongHistory));
            this.lblOutput = new System.Windows.Forms.Label();
            this.fbdFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.grpTrackInfo = new System.Windows.Forms.GroupBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTrack = new System.Windows.Forms.Label();
            this.tmrUpdateInfo = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateFile = new System.Windows.Forms.Timer(this.components);
            this.chkLog = new System.Windows.Forms.CheckBox();
            this.lblLastLogged = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkLookup = new System.Windows.Forms.CheckBox();
            this.chkGenre = new System.Windows.Forms.CheckBox();
            this.chkAlbum = new System.Windows.Forms.CheckBox();
            this.chkArtist = new System.Windows.Forms.CheckBox();
            this.chkDuration = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMinimize = new System.Windows.Forms.CheckBox();
            this.grpTrackInfo.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.notifyIconMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(71, 13);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Output folder:";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(89, 6);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.Size = new System.Drawing.Size(158, 20);
            this.txtOutputFile.TabIndex = 0;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(339, 3);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(63, 24);
            this.cmdBrowse.TabIndex = 1;
            this.cmdBrowse.Text = "Browse...";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // grpTrackInfo
            // 
            this.grpTrackInfo.Controls.Add(this.lblDuration);
            this.grpTrackInfo.Controls.Add(this.lblAlbum);
            this.grpTrackInfo.Controls.Add(this.lblArtist);
            this.grpTrackInfo.Controls.Add(this.lblTrack);
            this.grpTrackInfo.ForeColor = System.Drawing.Color.Blue;
            this.grpTrackInfo.Location = new System.Drawing.Point(12, 39);
            this.grpTrackInfo.Name = "grpTrackInfo";
            this.grpTrackInfo.Size = new System.Drawing.Size(390, 90);
            this.grpTrackInfo.TabIndex = 3;
            this.grpTrackInfo.TabStop = false;
            this.grpTrackInfo.Text = "Current Track Information";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.ForeColor = System.Drawing.Color.Black;
            this.lblDuration.Location = new System.Drawing.Point(6, 68);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(203, 13);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "Duration: Gathering duration information...";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.ForeColor = System.Drawing.Color.Black;
            this.lblAlbum.Location = new System.Drawing.Point(6, 51);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(182, 13);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Album: Gathering album information...";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.ForeColor = System.Drawing.Color.Black;
            this.lblArtist.Location = new System.Drawing.Point(6, 34);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(170, 13);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist: Gathering artist information...";
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.ForeColor = System.Drawing.Color.Black;
            this.lblTrack.Location = new System.Drawing.Point(6, 17);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(177, 13);
            this.lblTrack.TabIndex = 0;
            this.lblTrack.Text = "Track: Gathering track information...";
            // 
            // tmrUpdateInfo
            // 
            this.tmrUpdateInfo.Enabled = true;
            this.tmrUpdateInfo.Interval = 1000;
            this.tmrUpdateInfo.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // tmrUpdateFile
            // 
            this.tmrUpdateFile.Interval = 1000;
            this.tmrUpdateFile.Tick += new System.EventHandler(this.tmrUpdateFile_Tick);
            // 
            // chkLog
            // 
            this.chkLog.AutoSize = true;
            this.chkLog.Enabled = false;
            this.chkLog.Location = new System.Drawing.Point(11, 42);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(108, 17);
            this.chkLog.TabIndex = 1;
            this.chkLog.Text = "Log Songs to File";
            this.chkLog.UseVisualStyleBackColor = true;
            this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
            // 
            // lblLastLogged
            // 
            this.lblLastLogged.AutoSize = true;
            this.lblLastLogged.Location = new System.Drawing.Point(12, 211);
            this.lblLastLogged.Name = "lblLastLogged";
            this.lblLastLogged.Size = new System.Drawing.Size(282, 13);
            this.lblLastLogged.TabIndex = 5;
            this.lblLastLogged.Text = "Last logged at: Not logged yet (enable in Program Options)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "\\songhistory.htm";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkLookup);
            this.grpOptions.Controls.Add(this.chkGenre);
            this.grpOptions.Controls.Add(this.chkAlbum);
            this.grpOptions.Controls.Add(this.chkArtist);
            this.grpOptions.Controls.Add(this.chkDuration);
            this.grpOptions.Controls.Add(this.chkName);
            this.grpOptions.Location = new System.Drawing.Point(12, 135);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(260, 70);
            this.grpOptions.TabIndex = 7;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Include the following:";
            // 
            // chkLookup
            // 
            this.chkLookup.AutoSize = true;
            this.chkLookup.Checked = true;
            this.chkLookup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLookup.Location = new System.Drawing.Point(171, 42);
            this.chkLookup.Name = "chkLookup";
            this.chkLookup.Size = new System.Drawing.Size(86, 17);
            this.chkLookup.TabIndex = 5;
            this.chkLookup.Text = "Song lookup";
            this.chkLookup.UseVisualStyleBackColor = true;
            // 
            // chkGenre
            // 
            this.chkGenre.AutoSize = true;
            this.chkGenre.Checked = true;
            this.chkGenre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenre.Location = new System.Drawing.Point(171, 19);
            this.chkGenre.Name = "chkGenre";
            this.chkGenre.Size = new System.Drawing.Size(55, 17);
            this.chkGenre.TabIndex = 4;
            this.chkGenre.Text = "Genre";
            this.chkGenre.UseVisualStyleBackColor = true;
            // 
            // chkAlbum
            // 
            this.chkAlbum.AutoSize = true;
            this.chkAlbum.Checked = true;
            this.chkAlbum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlbum.Location = new System.Drawing.Point(100, 42);
            this.chkAlbum.Name = "chkAlbum";
            this.chkAlbum.Size = new System.Drawing.Size(55, 17);
            this.chkAlbum.TabIndex = 3;
            this.chkAlbum.Text = "Album";
            this.chkAlbum.UseVisualStyleBackColor = true;
            // 
            // chkArtist
            // 
            this.chkArtist.AutoSize = true;
            this.chkArtist.Checked = true;
            this.chkArtist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkArtist.Location = new System.Drawing.Point(100, 19);
            this.chkArtist.Name = "chkArtist";
            this.chkArtist.Size = new System.Drawing.Size(49, 17);
            this.chkArtist.TabIndex = 2;
            this.chkArtist.Text = "Artist";
            this.chkArtist.UseVisualStyleBackColor = true;
            // 
            // chkDuration
            // 
            this.chkDuration.AutoSize = true;
            this.chkDuration.Checked = true;
            this.chkDuration.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDuration.Location = new System.Drawing.Point(9, 42);
            this.chkDuration.Name = "chkDuration";
            this.chkDuration.Size = new System.Drawing.Size(66, 17);
            this.chkDuration.TabIndex = 1;
            this.chkDuration.Text = "Duration";
            this.chkDuration.UseVisualStyleBackColor = true;
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Checked = true;
            this.chkName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkName.Location = new System.Drawing.Point(9, 19);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(82, 17);
            this.chkName.TabIndex = 0;
            this.chkName.Text = "Song Name";
            this.chkName.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Song History Logger is now running the background. Double click its icon in the s" +
    "ystem try to restore it.";
            this.notifyIcon.BalloonTipTitle = "Song History Logger";
            this.notifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Song History Logger";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(114, 54);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMinimize);
            this.groupBox1.Controls.Add(this.chkLog);
            this.groupBox1.Location = new System.Drawing.Point(278, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Program Options";
            // 
            // chkMinimize
            // 
            this.chkMinimize.AutoSize = true;
            this.chkMinimize.Checked = true;
            this.chkMinimize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMinimize.Location = new System.Drawing.Point(11, 19);
            this.chkMinimize.Name = "chkMinimize";
            this.chkMinimize.Size = new System.Drawing.Size(102, 17);
            this.chkMinimize.TabIndex = 0;
            this.chkMinimize.Text = "Minimize to Tray";
            this.chkMinimize.UseVisualStyleBackColor = true;
            // 
            // SongHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 233);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLastLogged);
            this.Controls.Add(this.grpTrackInfo);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.lblOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SongHistory";
            this.Text = "Song History Logger (www.github.com/ipavl) - v1.4";
            this.Load += new System.EventHandler(this.SongHistory_Load);
            this.Resize += new System.EventHandler(this.SongHistory_Resize);
            this.grpTrackInfo.ResumeLayout(false);
            this.grpTrackInfo.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.notifyIconMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderBrowser;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.GroupBox grpTrackInfo;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.Timer tmrUpdateInfo;
        private System.Windows.Forms.Timer tmrUpdateFile;
        private System.Windows.Forms.CheckBox chkLog;
        private System.Windows.Forms.Label lblLastLogged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkLookup;
        private System.Windows.Forms.CheckBox chkGenre;
        private System.Windows.Forms.CheckBox chkAlbum;
        private System.Windows.Forms.CheckBox chkArtist;
        private System.Windows.Forms.CheckBox chkDuration;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMinimize;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

