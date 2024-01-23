namespace Music_Matcher
{
    partial class frmPlaylistSelector
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
            this.grpBoxGuest = new System.Windows.Forms.GroupBox();
            this.btnCancelGuest = new System.Windows.Forms.Button();
            this.btnGuestConfirm = new System.Windows.Forms.Button();
            this.btnGuestSelectFile = new System.Windows.Forms.Button();
            this.grpBoxSettings = new System.Windows.Forms.GroupBox();
            this.btnConfirmUserChoice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlaylistCount = new System.Windows.Forms.Label();
            this.lblTimesPlayed = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxPlaylists = new System.Windows.Forms.ComboBox();
            this.grpBoxPreview = new System.Windows.Forms.GroupBox();
            this.liBoxPlaylistPreview = new System.Windows.Forms.ListBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.grpBoxGuest.SuspendLayout();
            this.grpBoxSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxPreview.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxGuest
            // 
            this.grpBoxGuest.Controls.Add(this.btnCancelGuest);
            this.grpBoxGuest.Controls.Add(this.btnGuestConfirm);
            this.grpBoxGuest.Controls.Add(this.btnGuestSelectFile);
            this.grpBoxGuest.Location = new System.Drawing.Point(14, 5);
            this.grpBoxGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxGuest.Name = "grpBoxGuest";
            this.grpBoxGuest.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxGuest.Size = new System.Drawing.Size(214, 278);
            this.grpBoxGuest.TabIndex = 0;
            this.grpBoxGuest.TabStop = false;
            this.grpBoxGuest.Text = "Guest User";
            // 
            // btnCancelGuest
            // 
            this.btnCancelGuest.Enabled = false;
            this.btnCancelGuest.Location = new System.Drawing.Point(9, 140);
            this.btnCancelGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelGuest.Name = "btnCancelGuest";
            this.btnCancelGuest.Size = new System.Drawing.Size(197, 55);
            this.btnCancelGuest.TabIndex = 2;
            this.btnCancelGuest.Text = "Cancel";
            this.btnCancelGuest.UseVisualStyleBackColor = true;
            this.btnCancelGuest.Click += new System.EventHandler(this.btnCancelGuest_Click);
            // 
            // btnGuestConfirm
            // 
            this.btnGuestConfirm.Enabled = false;
            this.btnGuestConfirm.Location = new System.Drawing.Point(9, 205);
            this.btnGuestConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuestConfirm.Name = "btnGuestConfirm";
            this.btnGuestConfirm.Size = new System.Drawing.Size(197, 55);
            this.btnGuestConfirm.TabIndex = 1;
            this.btnGuestConfirm.Text = "Confirm";
            this.btnGuestConfirm.UseVisualStyleBackColor = true;
            this.btnGuestConfirm.Click += new System.EventHandler(this.btnGuestConfirm_Click);
            // 
            // btnGuestSelectFile
            // 
            this.btnGuestSelectFile.Location = new System.Drawing.Point(9, 37);
            this.btnGuestSelectFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuestSelectFile.Name = "btnGuestSelectFile";
            this.btnGuestSelectFile.Size = new System.Drawing.Size(197, 55);
            this.btnGuestSelectFile.TabIndex = 0;
            this.btnGuestSelectFile.Text = "Choose File";
            this.btnGuestSelectFile.UseVisualStyleBackColor = true;
            this.btnGuestSelectFile.Click += new System.EventHandler(this.btnGuestSelectFile_Click);
            // 
            // grpBoxSettings
            // 
            this.grpBoxSettings.Controls.Add(this.btnConfirmUserChoice);
            this.grpBoxSettings.Controls.Add(this.groupBox1);
            this.grpBoxSettings.Controls.Add(this.btnAddPlaylist);
            this.grpBoxSettings.Controls.Add(this.label1);
            this.grpBoxSettings.Controls.Add(this.cmbBoxPlaylists);
            this.grpBoxSettings.Location = new System.Drawing.Point(237, 5);
            this.grpBoxSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxSettings.Name = "grpBoxSettings";
            this.grpBoxSettings.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxSettings.Size = new System.Drawing.Size(546, 278);
            this.grpBoxSettings.TabIndex = 1;
            this.grpBoxSettings.TabStop = false;
            this.grpBoxSettings.Text = "Settings for ";
            // 
            // btnConfirmUserChoice
            // 
            this.btnConfirmUserChoice.Enabled = false;
            this.btnConfirmUserChoice.Location = new System.Drawing.Point(9, 193);
            this.btnConfirmUserChoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmUserChoice.Name = "btnConfirmUserChoice";
            this.btnConfirmUserChoice.Size = new System.Drawing.Size(151, 67);
            this.btnConfirmUserChoice.TabIndex = 5;
            this.btnConfirmUserChoice.Text = "Select Playlist";
            this.btnConfirmUserChoice.UseVisualStyleBackColor = true;
            this.btnConfirmUserChoice.Click += new System.EventHandler(this.btnConfirmUserChoice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlaylistCount);
            this.groupBox1.Controls.Add(this.lblTimesPlayed);
            this.groupBox1.Controls.Add(this.lblHighScore);
            this.groupBox1.Location = new System.Drawing.Point(211, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(326, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // lblPlaylistCount
            // 
            this.lblPlaylistCount.AutoSize = true;
            this.lblPlaylistCount.Location = new System.Drawing.Point(9, 125);
            this.lblPlaylistCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaylistCount.Name = "lblPlaylistCount";
            this.lblPlaylistCount.Size = new System.Drawing.Size(197, 23);
            this.lblPlaylistCount.TabIndex = 2;
            this.lblPlaylistCount.Text = "Saved Playlists: ";
            // 
            // lblTimesPlayed
            // 
            this.lblTimesPlayed.AutoSize = true;
            this.lblTimesPlayed.Location = new System.Drawing.Point(9, 80);
            this.lblTimesPlayed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimesPlayed.Name = "lblTimesPlayed";
            this.lblTimesPlayed.Size = new System.Drawing.Size(164, 23);
            this.lblTimesPlayed.TabIndex = 1;
            this.lblTimesPlayed.Text = "Times Played: ";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(9, 37);
            this.lblHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(175, 23);
            this.lblHighScore.TabIndex = 0;
            this.lblHighScore.Text = "Highest Score: ";
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.Location = new System.Drawing.Point(9, 128);
            this.btnAddPlaylist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(151, 55);
            this.btnAddPlaylist.TabIndex = 3;
            this.btnAddPlaylist.Text = "Add Playlist";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saved Playlists:";
            // 
            // cmbBoxPlaylists
            // 
            this.cmbBoxPlaylists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPlaylists.FormattingEnabled = true;
            this.cmbBoxPlaylists.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbBoxPlaylists.Location = new System.Drawing.Point(364, 228);
            this.cmbBoxPlaylists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbBoxPlaylists.Name = "cmbBoxPlaylists";
            this.cmbBoxPlaylists.Size = new System.Drawing.Size(171, 31);
            this.cmbBoxPlaylists.TabIndex = 0;
            this.cmbBoxPlaylists.SelectedIndexChanged += new System.EventHandler(this.UpdatePreview);
            // 
            // grpBoxPreview
            // 
            this.grpBoxPreview.Controls.Add(this.liBoxPlaylistPreview);
            this.grpBoxPreview.Location = new System.Drawing.Point(14, 293);
            this.grpBoxPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPreview.Name = "grpBoxPreview";
            this.grpBoxPreview.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxPreview.Size = new System.Drawing.Size(769, 208);
            this.grpBoxPreview.TabIndex = 2;
            this.grpBoxPreview.TabStop = false;
            this.grpBoxPreview.Text = "Preview";
            // 
            // liBoxPlaylistPreview
            // 
            this.liBoxPlaylistPreview.FormattingEnabled = true;
            this.liBoxPlaylistPreview.ItemHeight = 23;
            this.liBoxPlaylistPreview.Location = new System.Drawing.Point(9, 37);
            this.liBoxPlaylistPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.liBoxPlaylistPreview.Name = "liBoxPlaylistPreview";
            this.liBoxPlaylistPreview.Size = new System.Drawing.Size(758, 119);
            this.liBoxPlaylistPreview.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.grpBoxPreview);
            this.pnlContainer.Controls.Add(this.grpBoxSettings);
            this.pnlContainer.Controls.Add(this.grpBoxGuest);
            this.pnlContainer.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnlContainer.Location = new System.Drawing.Point(3, 3);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(797, 517);
            this.pnlContainer.TabIndex = 1;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "\"Text|*.txt|All|*.*\"";
            // 
            // frmPlaylistSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 525);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPlaylistSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Playlist";
            this.Load += new System.EventHandler(this.frmPlaylistSelector_Load);
            this.grpBoxGuest.ResumeLayout(false);
            this.grpBoxSettings.ResumeLayout(false);
            this.grpBoxSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxPreview.ResumeLayout(false);
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBoxGuest;
        private Button btnGuestSelectFile;
        private GroupBox grpBoxSettings;
        private GroupBox grpBoxPreview;
        private Button btnCancelGuest;
        private Button btnGuestConfirm;
        private Button btnAddPlaylist;
        private Label label1;
        private ComboBox cmbBoxPlaylists;
        private ListBox liBoxPlaylistPreview;
        private Panel pnlContainer;
        private Button btnConfirmUserChoice;
        private GroupBox groupBox1;
        private Label lblPlaylistCount;
        private Label lblTimesPlayed;
        private Label lblHighScore;
        private OpenFileDialog ofd;
    }
}