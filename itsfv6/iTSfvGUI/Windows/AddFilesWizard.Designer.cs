﻿namespace iTSfvGUI
{
    partial class AddFilesWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFilesWizard));
            this.gbAlbumTags = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.chkYear = new System.Windows.Forms.Label();
            this.chkGenre = new System.Windows.Forms.Label();
            this.cboAlbumArtist = new System.Windows.Forms.ComboBox();
            this.chkAlbumArtist = new System.Windows.Forms.Label();
            this.lblOf = new System.Windows.Forms.Label();
            this.chkDisc = new System.Windows.Forms.Label();
            this.nudDiscCount = new System.Windows.Forms.NumericUpDown();
            this.nudDiscNumber = new System.Windows.Forms.NumericUpDown();
            this.chkAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lbTracks = new System.Windows.Forms.ListBox();
            this.tvBands = new System.Windows.Forms.TreeView();
            this.tlpApp = new System.Windows.Forms.TableLayoutPanel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.chkCopyMusicToLibrary = new System.Windows.Forms.CheckBox();
            this.gbAlbumTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscNumber)).BeginInit();
            this.tlpApp.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAlbumTags
            // 
            this.gbAlbumTags.Controls.Add(this.btnSave);
            this.gbAlbumTags.Controls.Add(this.cboGenre);
            this.gbAlbumTags.Controls.Add(this.nudYear);
            this.gbAlbumTags.Controls.Add(this.chkYear);
            this.gbAlbumTags.Controls.Add(this.chkGenre);
            this.gbAlbumTags.Controls.Add(this.cboAlbumArtist);
            this.gbAlbumTags.Controls.Add(this.chkAlbumArtist);
            this.gbAlbumTags.Controls.Add(this.lblOf);
            this.gbAlbumTags.Controls.Add(this.chkDisc);
            this.gbAlbumTags.Controls.Add(this.nudDiscCount);
            this.gbAlbumTags.Controls.Add(this.nudDiscNumber);
            this.gbAlbumTags.Controls.Add(this.chkAlbum);
            this.gbAlbumTags.Controls.Add(this.txtAlbum);
            this.gbAlbumTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAlbumTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlbumTags.Location = new System.Drawing.Point(3, 363);
            this.gbAlbumTags.Name = "gbAlbumTags";
            this.gbAlbumTags.Size = new System.Drawing.Size(458, 174);
            this.gbAlbumTags.TabIndex = 2;
            this.gbAlbumTags.TabStop = false;
            this.gbAlbumTags.Text = "Disc Tags";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(368, 146);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 22);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboGenre
            // 
            this.cboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(105, 96);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(337, 21);
            this.cboGenre.TabIndex = 7;
            // 
            // nudYear
            // 
            this.nudYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudYear.Location = new System.Drawing.Point(105, 70);
            this.nudYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(337, 20);
            this.nudYear.TabIndex = 5;
            // 
            // chkYear
            // 
            this.chkYear.AutoSize = true;
            this.chkYear.Location = new System.Drawing.Point(63, 73);
            this.chkYear.Name = "chkYear";
            this.chkYear.Size = new System.Drawing.Size(29, 13);
            this.chkYear.TabIndex = 4;
            this.chkYear.Text = "Year";
            // 
            // chkGenre
            // 
            this.chkGenre.AutoSize = true;
            this.chkGenre.Location = new System.Drawing.Point(56, 100);
            this.chkGenre.Name = "chkGenre";
            this.chkGenre.Size = new System.Drawing.Size(36, 13);
            this.chkGenre.TabIndex = 6;
            this.chkGenre.Text = "Genre";
            // 
            // cboAlbumArtist
            // 
            this.cboAlbumArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAlbumArtist.FormattingEnabled = true;
            this.cboAlbumArtist.ItemHeight = 13;
            this.cboAlbumArtist.Location = new System.Drawing.Point(105, 19);
            this.cboAlbumArtist.Name = "cboAlbumArtist";
            this.cboAlbumArtist.Size = new System.Drawing.Size(337, 21);
            this.cboAlbumArtist.Sorted = true;
            this.cboAlbumArtist.TabIndex = 1;
            // 
            // chkAlbumArtist
            // 
            this.chkAlbumArtist.AutoSize = true;
            this.chkAlbumArtist.Location = new System.Drawing.Point(30, 23);
            this.chkAlbumArtist.Name = "chkAlbumArtist";
            this.chkAlbumArtist.Size = new System.Drawing.Size(62, 13);
            this.chkAlbumArtist.TabIndex = 0;
            this.chkAlbumArtist.Text = "Album Artist";
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Location = new System.Drawing.Point(171, 126);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(16, 13);
            this.lblOf.TabIndex = 10;
            this.lblOf.Text = "of";
            // 
            // chkDisc
            // 
            this.chkDisc.AutoSize = true;
            this.chkDisc.Location = new System.Drawing.Point(64, 126);
            this.chkDisc.Name = "chkDisc";
            this.chkDisc.Size = new System.Drawing.Size(28, 13);
            this.chkDisc.TabIndex = 8;
            this.chkDisc.Text = "Disc";
            // 
            // nudDiscCount
            // 
            this.nudDiscCount.Location = new System.Drawing.Point(193, 123);
            this.nudDiscCount.Name = "nudDiscCount";
            this.nudDiscCount.ReadOnly = true;
            this.nudDiscCount.Size = new System.Drawing.Size(60, 20);
            this.nudDiscCount.TabIndex = 11;
            this.nudDiscCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDiscNumber
            // 
            this.nudDiscNumber.Location = new System.Drawing.Point(105, 123);
            this.nudDiscNumber.Name = "nudDiscNumber";
            this.nudDiscNumber.ReadOnly = true;
            this.nudDiscNumber.Size = new System.Drawing.Size(60, 20);
            this.nudDiscNumber.TabIndex = 9;
            this.nudDiscNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkAlbum
            // 
            this.chkAlbum.AutoSize = true;
            this.chkAlbum.Location = new System.Drawing.Point(56, 48);
            this.chkAlbum.Name = "chkAlbum";
            this.chkAlbum.Size = new System.Drawing.Size(36, 13);
            this.chkAlbum.TabIndex = 2;
            this.chkAlbum.Text = "Album";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlbum.Location = new System.Drawing.Point(105, 44);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(337, 20);
            this.txtAlbum.TabIndex = 3;
            // 
            // lbTracks
            // 
            this.lbTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTracks.FormattingEnabled = true;
            this.lbTracks.Location = new System.Drawing.Point(3, 183);
            this.lbTracks.Name = "lbTracks";
            this.lbTracks.Size = new System.Drawing.Size(458, 174);
            this.lbTracks.TabIndex = 1;
            // 
            // tvBands
            // 
            this.tvBands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBands.Location = new System.Drawing.Point(3, 3);
            this.tvBands.Name = "tvBands";
            this.tvBands.Size = new System.Drawing.Size(458, 174);
            this.tvBands.TabIndex = 0;
            this.tvBands.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvBands_NodeMouseClick);
            // 
            // tlpApp
            // 
            this.tlpApp.ColumnCount = 1;
            this.tlpApp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpApp.Controls.Add(this.gbAlbumTags, 0, 2);
            this.tlpApp.Controls.Add(this.tvBands, 0, 0);
            this.tlpApp.Controls.Add(this.lbTracks, 0, 1);
            this.tlpApp.Controls.Add(this.panelButtons, 0, 4);
            this.tlpApp.Controls.Add(this.panelOptions, 0, 3);
            this.tlpApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpApp.Location = new System.Drawing.Point(0, 0);
            this.tlpApp.Name = "tlpApp";
            this.tlpApp.RowCount = 5;
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpApp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpApp.Size = new System.Drawing.Size(464, 601);
            this.tlpApp.TabIndex = 3;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnOk);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(3, 571);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(458, 27);
            this.panelButtons.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(367, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 22);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.chkCopyMusicToLibrary);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOptions.Location = new System.Drawing.Point(3, 543);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(458, 22);
            this.panelOptions.TabIndex = 5;
            // 
            // chkCopyMusicToLibrary
            // 
            this.chkCopyMusicToLibrary.AutoSize = true;
            this.chkCopyMusicToLibrary.Location = new System.Drawing.Point(9, 2);
            this.chkCopyMusicToLibrary.Name = "chkCopyMusicToLibrary";
            this.chkCopyMusicToLibrary.Size = new System.Drawing.Size(127, 17);
            this.chkCopyMusicToLibrary.TabIndex = 3;
            this.chkCopyMusicToLibrary.Text = "Copy to Music Library";
            this.chkCopyMusicToLibrary.UseVisualStyleBackColor = true;
            // 
            // AddFilesWizard
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 601);
            this.Controls.Add(this.tlpApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 640);
            this.Name = "AddFilesWizard";
            this.Text = "AddFilesWizard";
            this.Load += new System.EventHandler(this.AddFilesWizard_Load);
            this.gbAlbumTags.ResumeLayout(false);
            this.gbAlbumTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscNumber)).EndInit();
            this.tlpApp.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbAlbumTags;
        internal System.Windows.Forms.ComboBox cboGenre;
        internal System.Windows.Forms.NumericUpDown nudYear;
        internal System.Windows.Forms.Label chkYear;
        internal System.Windows.Forms.Label chkGenre;
        internal System.Windows.Forms.ComboBox cboAlbumArtist;
        internal System.Windows.Forms.Label chkAlbumArtist;
        internal System.Windows.Forms.Label lblOf;
        internal System.Windows.Forms.Label chkDisc;
        internal System.Windows.Forms.NumericUpDown nudDiscCount;
        internal System.Windows.Forms.NumericUpDown nudDiscNumber;
        internal System.Windows.Forms.Label chkAlbum;
        internal System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.ListBox lbTracks;
        private System.Windows.Forms.TreeView tvBands;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tlpApp;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.CheckBox chkCopyMusicToLibrary;
    }
}