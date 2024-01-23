namespace Music_Matcher
{
    partial class frmPlaylistSetup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDisplay = new System.Windows.Forms.RichTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.pbDisplay = new System.Windows.Forms.PictureBox();
            this.LiLblTuneMyMusic = new System.Windows.Forms.LinkLabel();
            this.lblLastPage = new System.Windows.Forms.Label();
            this.lblNextPage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDisplay);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.pbDisplay);
            this.panel1.Controls.Add(this.LiLblTuneMyMusic);
            this.panel1.Controls.Add(this.lblLastPage);
            this.panel1.Controls.Add(this.lblNextPage);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 361);
            this.panel1.TabIndex = 0;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(3, 202);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(309, 109);
            this.txtDisplay.TabIndex = 6;
            this.txtDisplay.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(119, 317);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 31);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pbDisplay
            // 
            this.pbDisplay.Location = new System.Drawing.Point(3, 3);
            this.pbDisplay.Name = "pbDisplay";
            this.pbDisplay.Size = new System.Drawing.Size(309, 162);
            this.pbDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDisplay.TabIndex = 4;
            this.pbDisplay.TabStop = false;
            // 
            // LiLblTuneMyMusic
            // 
            this.LiLblTuneMyMusic.AutoSize = true;
            this.LiLblTuneMyMusic.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LiLblTuneMyMusic.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.LiLblTuneMyMusic.Location = new System.Drawing.Point(86, 178);
            this.LiLblTuneMyMusic.Name = "LiLblTuneMyMusic";
            this.LiLblTuneMyMusic.Size = new System.Drawing.Size(140, 21);
            this.LiLblTuneMyMusic.TabIndex = 2;
            this.LiLblTuneMyMusic.TabStop = true;
            this.LiLblTuneMyMusic.Text = "Tune My Music";
            this.LiLblTuneMyMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LiLblTuneMyMusic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LiLblTuneMyMusic_LinkClicked);
            // 
            // lblLastPage
            // 
            this.lblLastPage.AutoSize = true;
            this.lblLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLastPage.Enabled = false;
            this.lblLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblLastPage.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastPage.Location = new System.Drawing.Point(3, 321);
            this.lblLastPage.Name = "lblLastPage";
            this.lblLastPage.Size = new System.Drawing.Size(23, 25);
            this.lblLastPage.TabIndex = 1;
            this.lblLastPage.Text = "<";
            this.lblLastPage.Click += new System.EventHandler(this.lblLastPage_Click);
            // 
            // lblNextPage
            // 
            this.lblNextPage.AutoSize = true;
            this.lblNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNextPage.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNextPage.Location = new System.Drawing.Point(289, 321);
            this.lblNextPage.Name = "lblNextPage";
            this.lblNextPage.Size = new System.Drawing.Size(23, 25);
            this.lblNextPage.TabIndex = 0;
            this.lblNextPage.Text = ">";
            this.lblNextPage.Click += new System.EventHandler(this.lblNextPage_Click);
            // 
            // frmPlaylistSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 380);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlaylistSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist Setup";
            this.Load += new System.EventHandler(this.frmPlaylistSetup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblLastPage;
        private Label lblNextPage;
        private PictureBox pbDisplay;
        private LinkLabel LiLblTuneMyMusic;
        private Button btnOk;
        private RichTextBox txtDisplay;
    }
}