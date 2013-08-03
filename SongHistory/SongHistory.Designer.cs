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
            this.grpTrackInfo.SuspendLayout();
            this.grpOptions.SuspendLayout();
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
            this.txtOutputFile.TabIndex = 1;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(339, 3);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(63, 24);
            this.cmdBrowse.TabIndex = 2;
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
            this.lblDuration.Size = new System.Drawing.Size(50, 13);
            this.lblDuration.TabIndex = 3;
            this.lblDuration.Text = "Duration:";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.ForeColor = System.Drawing.Color.Black;
            this.lblAlbum.Location = new System.Drawing.Point(6, 51);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(39, 13);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Album:";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.ForeColor = System.Drawing.Color.Black;
            this.lblArtist.Location = new System.Drawing.Point(6, 34);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(33, 13);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist:";
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.ForeColor = System.Drawing.Color.Black;
            this.lblTrack.Location = new System.Drawing.Point(6, 17);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(38, 13);
            this.lblTrack.TabIndex = 0;
            this.lblTrack.Text = "Track:";
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
            this.chkLog.Location = new System.Drawing.Point(12, 135);
            this.chkLog.Name = "chkLog";
            this.chkLog.Size = new System.Drawing.Size(177, 17);
            this.chkLog.TabIndex = 4;
            this.chkLog.Text = "Log Songs to File (every minute)";
            this.chkLog.UseVisualStyleBackColor = true;
            this.chkLog.CheckedChanged += new System.EventHandler(this.chkLog_CheckedChanged);
            // 
            // lblLastLogged
            // 
            this.lblLastLogged.AutoSize = true;
            this.lblLastLogged.Location = new System.Drawing.Point(212, 136);
            this.lblLastLogged.Name = "lblLastLogged";
            this.lblLastLogged.Size = new System.Drawing.Size(149, 13);
            this.lblLastLogged.TabIndex = 5;
            this.lblLastLogged.Text = "Last logged at: Not logged yet";
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
            this.grpOptions.Location = new System.Drawing.Point(12, 159);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(287, 70);
            this.grpOptions.TabIndex = 7;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Include the following:";
            // 
            // chkLookup
            // 
            this.chkLookup.AutoSize = true;
            this.chkLookup.Checked = true;
            this.chkLookup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLookup.Location = new System.Drawing.Point(193, 42);
            this.chkLookup.Name = "chkLookup";
            this.chkLookup.Size = new System.Drawing.Size(86, 17);
            this.chkLookup.TabIndex = 7;
            this.chkLookup.Text = "Song lookup";
            this.chkLookup.UseVisualStyleBackColor = true;
            // 
            // chkGenre
            // 
            this.chkGenre.AutoSize = true;
            this.chkGenre.Checked = true;
            this.chkGenre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGenre.Location = new System.Drawing.Point(193, 19);
            this.chkGenre.Name = "chkGenre";
            this.chkGenre.Size = new System.Drawing.Size(55, 17);
            this.chkGenre.TabIndex = 5;
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
            // SongHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 241);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLastLogged);
            this.Controls.Add(this.chkLog);
            this.Controls.Add(this.grpTrackInfo);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.lblOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SongHistory";
            this.Text = "Song History Logger (www.github.com/ipavl) - v1.3";
            this.grpTrackInfo.ResumeLayout(false);
            this.grpTrackInfo.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
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
    }
}

