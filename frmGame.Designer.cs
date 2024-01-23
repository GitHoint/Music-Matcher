namespace Music_Matcher
{
    partial class frmGame
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
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.btnGetArtist = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblSelectedPlaylist = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnNextSong = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnExtendTimer = new System.Windows.Forms.Button();
            this.btnSongSkip = new System.Windows.Forms.Button();
            this.btnRevealChar = new System.Windows.Forms.Button();
            this.progressBarTimer = new System.Windows.Forms.ProgressBar();
            this.lblTimerDisplay = new System.Windows.Forms.Label();
            this.progressBarPlaylistProgress = new System.Windows.Forms.ProgressBar();
            this.grpBoxGameDisplay = new System.Windows.Forms.GroupBox();
            this.txtInputField = new System.Windows.Forms.TextBox();
            this.lblSongsGuessedAmount = new System.Windows.Forms.Label();
            this.lblGuessedSongs = new System.Windows.Forms.Label();
            this.lblRoundScoreValue = new System.Windows.Forms.Label();
            this.lblRoundScore = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblSongNameDisplay = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.roundTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlDisplay.SuspendLayout();
            this.grpBoxGameDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.btnGetArtist);
            this.pnlDisplay.Controls.Add(this.btnStartGame);
            this.pnlDisplay.Controls.Add(this.lblSelectedPlaylist);
            this.pnlDisplay.Controls.Add(this.lblCurrentUser);
            this.pnlDisplay.Controls.Add(this.btnNextSong);
            this.pnlDisplay.Controls.Add(this.btnQuit);
            this.pnlDisplay.Controls.Add(this.btnExtendTimer);
            this.pnlDisplay.Controls.Add(this.btnSongSkip);
            this.pnlDisplay.Controls.Add(this.btnRevealChar);
            this.pnlDisplay.Controls.Add(this.progressBarTimer);
            this.pnlDisplay.Controls.Add(this.lblTimerDisplay);
            this.pnlDisplay.Controls.Add(this.progressBarPlaylistProgress);
            this.pnlDisplay.Controls.Add(this.grpBoxGameDisplay);
            this.pnlDisplay.Font = new System.Drawing.Font("JetBrains Mono SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pnlDisplay.Location = new System.Drawing.Point(17, 20);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(941, 463);
            this.pnlDisplay.TabIndex = 1;
            // 
            // btnGetArtist
            // 
            this.btnGetArtist.Enabled = false;
            this.btnGetArtist.Location = new System.Drawing.Point(206, 97);
            this.btnGetArtist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetArtist.Name = "btnGetArtist";
            this.btnGetArtist.Size = new System.Drawing.Size(360, 38);
            this.btnGetArtist.TabIndex = 17;
            this.btnGetArtist.Text = "Reveal Artist Name";
            this.btnGetArtist.UseVisualStyleBackColor = true;
            this.btnGetArtist.Click += new System.EventHandler(this.btnGetArtist_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartGame.Location = new System.Drawing.Point(606, 367);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(156, 85);
            this.btnStartGame.TabIndex = 16;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblSelectedPlaylist
            // 
            this.lblSelectedPlaylist.AutoSize = true;
            this.lblSelectedPlaylist.Location = new System.Drawing.Point(13, 412);
            this.lblSelectedPlaylist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedPlaylist.Name = "lblSelectedPlaylist";
            this.lblSelectedPlaylist.Size = new System.Drawing.Size(219, 23);
            this.lblSelectedPlaylist.TabIndex = 15;
            this.lblSelectedPlaylist.Text = "Selected Playlist: ";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(13, 367);
            this.lblCurrentUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(164, 23);
            this.lblCurrentUser.TabIndex = 14;
            this.lblCurrentUser.Text = "Current User: ";
            // 
            // btnNextSong
            // 
            this.btnNextSong.Enabled = false;
            this.btnNextSong.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextSong.Location = new System.Drawing.Point(606, 367);
            this.btnNextSong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(157, 87);
            this.btnNextSong.TabIndex = 13;
            this.btnNextSong.Text = "Next Song";
            this.btnNextSong.UseVisualStyleBackColor = true;
            this.btnNextSong.Click += new System.EventHandler(this.btnNextSong_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.Location = new System.Drawing.Point(771, 367);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(157, 87);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnExtendTimer
            // 
            this.btnExtendTimer.Enabled = false;
            this.btnExtendTimer.Location = new System.Drawing.Point(574, 48);
            this.btnExtendTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExtendTimer.Name = "btnExtendTimer";
            this.btnExtendTimer.Size = new System.Drawing.Size(363, 38);
            this.btnExtendTimer.TabIndex = 11;
            this.btnExtendTimer.Text = "Extend Timer";
            this.btnExtendTimer.UseVisualStyleBackColor = true;
            this.btnExtendTimer.Click += new System.EventHandler(this.btnExtendTimer_Click);
            // 
            // btnSongSkip
            // 
            this.btnSongSkip.Enabled = false;
            this.btnSongSkip.Location = new System.Drawing.Point(574, 97);
            this.btnSongSkip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSongSkip.Name = "btnSongSkip";
            this.btnSongSkip.Size = new System.Drawing.Size(363, 38);
            this.btnSongSkip.TabIndex = 8;
            this.btnSongSkip.Text = "Skip Song";
            this.btnSongSkip.UseVisualStyleBackColor = true;
            this.btnSongSkip.Click += new System.EventHandler(this.btnSongSkip_Click);
            // 
            // btnRevealChar
            // 
            this.btnRevealChar.Enabled = false;
            this.btnRevealChar.Location = new System.Drawing.Point(206, 48);
            this.btnRevealChar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRevealChar.Name = "btnRevealChar";
            this.btnRevealChar.Size = new System.Drawing.Size(360, 38);
            this.btnRevealChar.TabIndex = 7;
            this.btnRevealChar.Text = "Show First Characters";
            this.btnRevealChar.UseVisualStyleBackColor = true;
            this.btnRevealChar.Click += new System.EventHandler(this.btnRevealChar_Click);
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarTimer.Location = new System.Drawing.Point(13, 75);
            this.progressBarTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBarTimer.Name = "progressBarTimer";
            this.progressBarTimer.Size = new System.Drawing.Size(114, 30);
            this.progressBarTimer.Step = -1;
            this.progressBarTimer.TabIndex = 2;
            this.progressBarTimer.Value = 100;
            // 
            // lblTimerDisplay
            // 
            this.lblTimerDisplay.AutoSize = true;
            this.lblTimerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimerDisplay.Location = new System.Drawing.Point(136, 75);
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
            this.progressBarPlaylistProgress.Step = 1;
            this.progressBarPlaylistProgress.TabIndex = 0;
            // 
            // grpBoxGameDisplay
            // 
            this.grpBoxGameDisplay.Controls.Add(this.txtInputField);
            this.grpBoxGameDisplay.Controls.Add(this.lblSongsGuessedAmount);
            this.grpBoxGameDisplay.Controls.Add(this.lblGuessedSongs);
            this.grpBoxGameDisplay.Controls.Add(this.lblRoundScoreValue);
            this.grpBoxGameDisplay.Controls.Add(this.lblRoundScore);
            this.grpBoxGameDisplay.Controls.Add(this.lblArtistName);
            this.grpBoxGameDisplay.Controls.Add(this.label1);
            this.grpBoxGameDisplay.Controls.Add(this.lblScoreValue);
            this.grpBoxGameDisplay.Controls.Add(this.lblSongNameDisplay);
            this.grpBoxGameDisplay.Controls.Add(this.lblScore);
            this.grpBoxGameDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBoxGameDisplay.Location = new System.Drawing.Point(4, 125);
            this.grpBoxGameDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxGameDisplay.Name = "grpBoxGameDisplay";
            this.grpBoxGameDisplay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxGameDisplay.Size = new System.Drawing.Size(933, 232);
            this.grpBoxGameDisplay.TabIndex = 3;
            this.grpBoxGameDisplay.TabStop = false;
            this.grpBoxGameDisplay.Text = "Music Matcher";
            // 
            // txtInputField
            // 
            this.txtInputField.Enabled = false;
            this.txtInputField.Location = new System.Drawing.Point(9, 37);
            this.txtInputField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputField.Name = "txtInputField";
            this.txtInputField.Size = new System.Drawing.Size(334, 31);
            this.txtInputField.TabIndex = 12;
            this.txtInputField.TextChanged += new System.EventHandler(this.CheckInputMatch);
            // 
            // lblSongsGuessedAmount
            // 
            this.lblSongsGuessedAmount.AutoSize = true;
            this.lblSongsGuessedAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSongsGuessedAmount.Location = new System.Drawing.Point(284, 195);
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
            this.lblGuessedSongs.Location = new System.Drawing.Point(0, 195);
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
            this.lblRoundScoreValue.Location = new System.Drawing.Point(893, 195);
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
            this.lblRoundScore.Location = new System.Drawing.Point(609, 195);
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
            this.lblArtistName.Location = new System.Drawing.Point(9, 137);
            this.lblArtistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(168, 31);
            this.lblArtistName.TabIndex = 6;
            this.lblArtistName.Text = "Artist Name";
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
            this.lblScoreValue.Location = new System.Drawing.Point(893, 15);
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
            this.lblSongNameDisplay.Location = new System.Drawing.Point(9, 80);
            this.lblSongNameDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSongNameDisplay.Name = "lblSongNameDisplay";
            this.lblSongNameDisplay.Size = new System.Drawing.Size(268, 33);
            this.lblSongNameDisplay.TabIndex = 0;
            this.lblSongNameDisplay.Text = "Song Title Display";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore.Location = new System.Drawing.Point(811, 15);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(78, 25);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score:";
            // 
            // roundTimer
            // 
            this.roundTimer.Interval = 1000;
            this.roundTimer.Tick += new System.EventHandler(this.roundTimer_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 503);
            this.Controls.Add(this.pnlDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGame";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            this.grpBoxGameDisplay.ResumeLayout(false);
            this.grpBoxGameDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlDisplay;
        private Button btnExtendTimer;
        private Button btnSongSkip;
        private Button btnRevealChar;
        private ProgressBar progressBarTimer;
        private Label lblTimerDisplay;
        private ProgressBar progressBarPlaylistProgress;
        private GroupBox grpBoxGameDisplay;
        private Label lblSongsGuessedAmount;
        private Label lblGuessedSongs;
        private Label lblRoundScoreValue;
        private Label lblRoundScore;
        private Label lblArtistName;
        private Label label1;
        private Label lblScoreValue;
        private Label lblSongNameDisplay;
        private Label lblScore;
        private Label lblSelectedPlaylist;
        private Label lblCurrentUser;
        private Button btnNextSong;
        private Button btnQuit;
        private TextBox txtInputField;
        private Button btnStartGame;
        private System.Windows.Forms.Timer roundTimer;
        private Button btnGetArtist;
    }
}