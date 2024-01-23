namespace Music_Matcher
{
    partial class frmTutorial
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
            this.btnSongSkip = new System.Windows.Forms.Button();
            this.btnExtendTimer = new System.Windows.Forms.Button();
            this.btnGetArtist = new System.Windows.Forms.Button();
            this.btnRevealChar = new System.Windows.Forms.Button();
            this.btnNextInfo = new System.Windows.Forms.Button();
            this.txtInfoDisplay = new System.Windows.Forms.RichTextBox();
            this.progressBarTimer = new System.Windows.Forms.ProgressBar();
            this.lblTimerDisplay = new System.Windows.Forms.Label();
            this.progressBarPlaylistProgress = new System.Windows.Forms.ProgressBar();
            this.grpBoxGameDisplay = new System.Windows.Forms.GroupBox();
            this.lblSongsGuessedAmount = new System.Windows.Forms.Label();
            this.lblGuessedSongs = new System.Windows.Forms.Label();
            this.lblRoundScoreValue = new System.Windows.Forms.Label();
            this.lblRoundScore = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblSongNameDisplay = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpBoxGameDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSongSkip);
            this.panel1.Controls.Add(this.btnExtendTimer);
            this.panel1.Controls.Add(this.btnGetArtist);
            this.panel1.Controls.Add(this.btnRevealChar);
            this.panel1.Controls.Add(this.btnNextInfo);
            this.panel1.Controls.Add(this.txtInfoDisplay);
            this.panel1.Controls.Add(this.progressBarTimer);
            this.panel1.Controls.Add(this.lblTimerDisplay);
            this.panel1.Controls.Add(this.progressBarPlaylistProgress);
            this.panel1.Controls.Add(this.grpBoxGameDisplay);
            this.panel1.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(17, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 463);
            this.panel1.TabIndex = 0;
            // 
            // btnSongSkip
            // 
            this.btnSongSkip.Location = new System.Drawing.Point(579, 92);
            this.btnSongSkip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSongSkip.Name = "btnSongSkip";
            this.btnSongSkip.Size = new System.Drawing.Size(359, 38);
            this.btnSongSkip.TabIndex = 12;
            this.btnSongSkip.Text = "Skip Song";
            this.btnSongSkip.UseVisualStyleBackColor = true;
            // 
            // btnExtendTimer
            // 
            this.btnExtendTimer.Location = new System.Drawing.Point(577, 53);
            this.btnExtendTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExtendTimer.Name = "btnExtendTimer";
            this.btnExtendTimer.Size = new System.Drawing.Size(360, 38);
            this.btnExtendTimer.TabIndex = 19;
            this.btnExtendTimer.Text = "Extend Timer";
            this.btnExtendTimer.UseVisualStyleBackColor = true;
            // 
            // btnGetArtist
            // 
            this.btnGetArtist.Enabled = false;
            this.btnGetArtist.Location = new System.Drawing.Point(221, 92);
            this.btnGetArtist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetArtist.Name = "btnGetArtist";
            this.btnGetArtist.Size = new System.Drawing.Size(360, 38);
            this.btnGetArtist.TabIndex = 18;
            this.btnGetArtist.Text = "Reveal Artist Name";
            this.btnGetArtist.UseVisualStyleBackColor = true;
            // 
            // btnRevealChar
            // 
            this.btnRevealChar.Enabled = false;
            this.btnRevealChar.Location = new System.Drawing.Point(221, 53);
            this.btnRevealChar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRevealChar.Name = "btnRevealChar";
            this.btnRevealChar.Size = new System.Drawing.Size(360, 38);
            this.btnRevealChar.TabIndex = 11;
            this.btnRevealChar.Text = "Show First Characters";
            this.btnRevealChar.UseVisualStyleBackColor = true;
            // 
            // btnNextInfo
            // 
            this.btnNextInfo.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextInfo.Location = new System.Drawing.Point(764, 358);
            this.btnNextInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNextInfo.Name = "btnNextInfo";
            this.btnNextInfo.Size = new System.Drawing.Size(164, 100);
            this.btnNextInfo.TabIndex = 10;
            this.btnNextInfo.Text = "Next";
            this.btnNextInfo.UseVisualStyleBackColor = true;
            this.btnNextInfo.Click += new System.EventHandler(this.btnNextInfo_Click);
            // 
            // txtInfoDisplay
            // 
            this.txtInfoDisplay.Font = new System.Drawing.Font("JetBrains Mono Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInfoDisplay.Location = new System.Drawing.Point(4, 358);
            this.txtInfoDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInfoDisplay.Name = "txtInfoDisplay";
            this.txtInfoDisplay.ReadOnly = true;
            this.txtInfoDisplay.Size = new System.Drawing.Size(750, 97);
            this.txtInfoDisplay.TabIndex = 4;
            this.txtInfoDisplay.Text = "";
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarTimer.Location = new System.Drawing.Point(4, 53);
            this.progressBarTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarTimer.Name = "progressBarTimer";
            this.progressBarTimer.Size = new System.Drawing.Size(99, 30);
            this.progressBarTimer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTimer.TabIndex = 2;
            // 
            // lblTimerDisplay
            // 
            this.lblTimerDisplay.AutoSize = true;
            this.lblTimerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimerDisplay.Location = new System.Drawing.Point(111, 53);
            this.lblTimerDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimerDisplay.Name = "lblTimerDisplay";
            this.lblTimerDisplay.Size = new System.Drawing.Size(67, 25);
            this.lblTimerDisplay.TabIndex = 1;
            this.lblTimerDisplay.Text = "00:00";
            // 
            // progressBarPlaylistProgress
            // 
            this.progressBarPlaylistProgress.Location = new System.Drawing.Point(4, 5);
            this.progressBarPlaylistProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarPlaylistProgress.Name = "progressBarPlaylistProgress";
            this.progressBarPlaylistProgress.Size = new System.Drawing.Size(933, 38);
            this.progressBarPlaylistProgress.Step = 11;
            this.progressBarPlaylistProgress.TabIndex = 0;
            // 
            // grpBoxGameDisplay
            // 
            this.grpBoxGameDisplay.Controls.Add(this.lblSongsGuessedAmount);
            this.grpBoxGameDisplay.Controls.Add(this.lblGuessedSongs);
            this.grpBoxGameDisplay.Controls.Add(this.lblRoundScoreValue);
            this.grpBoxGameDisplay.Controls.Add(this.lblRoundScore);
            this.grpBoxGameDisplay.Controls.Add(this.lblArtistName);
            this.grpBoxGameDisplay.Controls.Add(this.label1);
            this.grpBoxGameDisplay.Controls.Add(this.lblScoreValue);
            this.grpBoxGameDisplay.Controls.Add(this.lblSongNameDisplay);
            this.grpBoxGameDisplay.Controls.Add(this.lblScore);
            this.grpBoxGameDisplay.Location = new System.Drawing.Point(4, 123);
            this.grpBoxGameDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxGameDisplay.Name = "grpBoxGameDisplay";
            this.grpBoxGameDisplay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxGameDisplay.Size = new System.Drawing.Size(933, 233);
            this.grpBoxGameDisplay.TabIndex = 3;
            this.grpBoxGameDisplay.TabStop = false;
            this.grpBoxGameDisplay.Text = "Music Matcher";
            // 
            // lblSongsGuessedAmount
            // 
            this.lblSongsGuessedAmount.AutoSize = true;
            this.lblSongsGuessedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSongsGuessedAmount.Location = new System.Drawing.Point(270, 233);
            this.lblSongsGuessedAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSongsGuessedAmount.Name = "lblSongsGuessedAmount";
            this.lblSongsGuessedAmount.Size = new System.Drawing.Size(23, 25);
            this.lblSongsGuessedAmount.TabIndex = 11;
            this.lblSongsGuessedAmount.Text = "0";
            // 
            // lblGuessedSongs
            // 
            this.lblGuessedSongs.AutoSize = true;
            this.lblGuessedSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuessedSongs.Location = new System.Drawing.Point(9, 233);
            this.lblGuessedSongs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuessedSongs.Name = "lblGuessedSongs";
            this.lblGuessedSongs.Size = new System.Drawing.Size(276, 25);
            this.lblGuessedSongs.TabIndex = 10;
            this.lblGuessedSongs.Text = "Songs Guessed Correctly:";
            // 
            // lblRoundScoreValue
            // 
            this.lblRoundScoreValue.AutoSize = true;
            this.lblRoundScoreValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoundScoreValue.Location = new System.Drawing.Point(901, 233);
            this.lblRoundScoreValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoundScoreValue.Name = "lblRoundScoreValue";
            this.lblRoundScoreValue.Size = new System.Drawing.Size(23, 25);
            this.lblRoundScoreValue.TabIndex = 9;
            this.lblRoundScoreValue.Text = "3";
            // 
            // lblRoundScore
            // 
            this.lblRoundScore.AutoSize = true;
            this.lblRoundScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoundScore.Location = new System.Drawing.Point(640, 233);
            this.lblRoundScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoundScore.Name = "lblRoundScore";
            this.lblRoundScore.Size = new System.Drawing.Size(276, 25);
            this.lblRoundScore.TabIndex = 9;
            this.lblRoundScore.Text = "Score from this attempt:";
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Font = new System.Drawing.Font("JetBrains Mono", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblArtistName.Location = new System.Drawing.Point(9, 145);
            this.lblArtistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(224, 31);
            this.lblArtistName.TabIndex = 6;
            this.lblArtistName.Text = "The Stone Roses";
            this.lblArtistName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(330, -35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Timer";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScoreValue.Location = new System.Drawing.Point(901, 15);
            this.lblScoreValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(23, 25);
            this.lblScoreValue.TabIndex = 6;
            this.lblScoreValue.Text = "0";
            // 
            // lblSongNameDisplay
            // 
            this.lblSongNameDisplay.AutoSize = true;
            this.lblSongNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSongNameDisplay.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSongNameDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSongNameDisplay.Location = new System.Drawing.Point(9, 95);
            this.lblSongNameDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSongNameDisplay.Name = "lblSongNameDisplay";
            this.lblSongNameDisplay.Size = new System.Drawing.Size(254, 33);
            this.lblSongNameDisplay.TabIndex = 0;
            this.lblSongNameDisplay.Text = "_ _____ __ ______";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Location = new System.Drawing.Point(820, 15);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(78, 25);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score:";
            // 
            // frmTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 503);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmTutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            this.Load += new System.EventHandler(this.frmTutorial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBoxGameDisplay.ResumeLayout(false);
            this.grpBoxGameDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblScoreValue;
        private Label lblScore;
        private RichTextBox txtInfoDisplay;
        private ProgressBar progressBarTimer;
        private Label lblTimerDisplay;
        private ProgressBar progressBarPlaylistProgress;
        private GroupBox grpBoxGameDisplay;
        private Label lblArtistName;
        private Label label1;
        private Label lblSongNameDisplay;
        private Label lblRoundScoreValue;
        private Label lblRoundScore;
        private Button btnNextInfo;
        private Label lblSongsGuessedAmount;
        private Label lblGuessedSongs;
        private Button btnRevealChar;
        private Button btnGetArtist;
        private Button btnExtendTimer;
        private Button btnSongSkip;
    }
}