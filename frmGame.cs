using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Matcher
{
    public partial class frmGame : Form
    {
        User currentUser = new User();
        Playlist currentPlaylist = new Playlist();

        //-----Game Runtime Variables-----\\
        public int currRoundScore = 3;
        public int totalScore = 0;
        public int skipCount = 3;
        public int exTimerCount = 3;
        public int timerProgress = 30;
        public int playlistProgress = 0;

        //-----Game Setup Operations-----\\
        private void frmGame_Load(object sender, EventArgs e)
        {
            LoginAndPlaylistRetreival();
            if (currentUser.GetUsername() == null)
            {
                lblCurrentUser.Text += "Guest";
            }
            else
            {
                lblCurrentUser.Text += currentUser.GetUsername();
            }
            lblSelectedPlaylist.Text += currentUser.GetPlaylistName();
        }
        public frmGame()
        {
            InitializeComponent();
        }
        public void LoginAndPlaylistRetreival()
        {
            frmGameMenu frmGameMenu = new frmGameMenu();
            frmGameMenu.ShowDialog();
            if (frmGameMenu.DidUserLogin == false)
            {
                currentUser.SetAsGuestUser();
            }
            else
            {
                currentUser.SetData(frmGameMenu.username, frmGameMenu.password, frmGameMenu.timesPlayed, frmGameMenu.highScore);
            }
            frmGameMenu.Close();
            frmPlaylistSelector frmPlaylistSelector = new frmPlaylistSelector(currentUser.GetUsername(), currentUser.GetPlayed(), currentUser.GetScore());
            frmPlaylistSelector.ShowDialog();
            if (frmPlaylistSelector.loginSuccess == true)
            {
                currentPlaylist.SetPlaylistData(frmPlaylistSelector.takenFromFile);
                currentUser.SetCurrentPlaylist(frmPlaylistSelector.playlistName);
                
            }
            else
            {
                this.Close();
                frmStartMenu frmStartMenu = new frmStartMenu();
                frmStartMenu.Show();
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Hide();
            ToggleControls();
            progressBarTimer.Maximum = timerProgress;
            progressBarPlaylistProgress.Maximum = currentPlaylist.GetPlaylistLength();
            StartRound();
            txtInputField.Focus();


        }
        private void ToggleControls()
        {
            if (skipCount == 0)
            {
                btnSongSkip.Enabled = false;
            }
            else
            {
                btnSongSkip.Enabled = !btnSongSkip.Enabled;
            }
            if (exTimerCount == 0)
            {
                btnExtendTimer.Enabled = false;
            }
            else
            {
                btnExtendTimer.Enabled = !btnExtendTimer.Enabled;
            }
            btnRevealChar.Enabled = !btnRevealChar.Enabled;
            txtInputField.Enabled = !txtInputField.Enabled;
            btnGetArtist.Enabled = !btnGetArtist.Enabled;
        }
        private void UpdateUI()
        {
            lblScoreValue.Text = totalScore.ToString();
            lblSongsGuessedAmount.Text = playlistProgress.ToString();
            lblRoundScoreValue.Text = currRoundScore.ToString();
        }
        //-----Runtime Operations-----\\


        public void StartRound()
        {
            if (currentPlaylist.GetPlaylistLength() == 0)
            {
                EndGame();
            }
            else
            {
                btnGetArtist.Enabled = true;
                btnRevealChar.Enabled = true;
                lblArtistName.Hide();
                timerProgress = 30;
                progressBarTimer.Value = timerProgress;
                progressBarTimer.Maximum = timerProgress;
                currRoundScore = 3;
                txtInputField.Clear();
                btnSongSkip.Text = "Skip Song (" + skipCount.ToString() + " Left)";
                btnExtendTimer.Text = "Extend Timer (" + exTimerCount.ToString() + " Left)";
                currentPlaylist.SelectSong();
                lblSongNameDisplay.Text = currentPlaylist.GetSongNameSpaces();
                lblArtistName.Text = currentPlaylist.GetArtist();
                roundTimer.Start();
                UpdateUI();
            }

        }
        private void CheckInputMatch(object sender, EventArgs e)
        {
            if (txtInputField.Text.ToLower() == currentPlaylist.GetSongName().ToLower())
            {
                //Reveal Songname field (& artist if hidden)
                roundTimer.Stop();
                totalScore += currRoundScore;
                playlistProgress++;
                txtInputField.Enabled = false;
                lblSongNameDisplay.Text = currentPlaylist.GetSongName();
                txtInputField.Text = "Correct!";
                btnNextSong.Enabled = true;
                btnExtendTimer.Enabled = false;
                btnSongSkip.Enabled = false;
                btnRevealChar.Enabled = false;
                btnGetArtist.Enabled = false;
                UpdateUI();
                progressBarPlaylistProgress.PerformStep();
            }
        }
        //-----Timer Operations-----\\


        private void roundTimer_Tick(object sender, EventArgs e)
        {
            timerProgress--;
            progressBarTimer.PerformStep();
            UpdateTimerDisplay();
            if (timerProgress == 0)
            {
                roundTimer.Stop();
                EndGame();
            }
        }
        private void UpdateTimerDisplay()
        {
            if (timerProgress < 10)
            {
                lblTimerDisplay.Text = "00:0" + timerProgress;
            }
            else if (timerProgress < 60)
            {
                lblTimerDisplay.Text = "00:" + timerProgress;
            }
            else if (timerProgress >= 60)
            {
                int mins = timerProgress / 60;
                int secs = timerProgress - 60;
                if (secs < 10)
                {
                    lblTimerDisplay.Text = "0" + mins + ":0" + secs;
                }
                else
                {
                    lblTimerDisplay.Text = "0" + mins + ":" + secs;
                }
            }
        }
        public void EndGame()
        {
            frmResults frmResults = new frmResults(playlistProgress, totalScore, currentUser.GetUsername(), currentUser.GetPlaylistName());
            if (currentUser.GetLoginStatus() == true)
            {
                currentUser.UpdateResults(totalScore);
                currentUser.SaveToFile();
                frmResults.Show();
            }
            this.Close();
            
        }

        //-----Extend Timer, Hint & Skip Song Btns-----\\

        private void btnExtendTimer_Click(object sender, EventArgs e)
        {
            timerProgress = timerProgress + 30;
            exTimerCount--;
            btnExtendTimer.Text = "Extend Timer (" + exTimerCount.ToString() + " Left)";
            progressBarTimer.Maximum = timerProgress;
            progressBarTimer.Value = timerProgress;
            if (exTimerCount == 0)
            {
                btnExtendTimer.Enabled = false;
            }
            txtInputField.Focus();
        }

        private void btnRevealChar_Click(object sender, EventArgs e)
        {
            lblSongNameDisplay.Text = currentPlaylist.RevealFirstChar();           
            btnRevealChar.Enabled = false;
            currRoundScore--;
            lblRoundScoreValue.Text = currRoundScore.ToString();
            txtInputField.Focus();
        }

        private void btnGetArtist_Click(object sender, EventArgs e)
        {
            btnGetArtist.Enabled = false;
            lblArtistName.Show();
            currRoundScore--;
            lblRoundScoreValue.Text = currRoundScore.ToString();
            txtInputField.Focus();
        }

        private void btnSongSkip_Click(object sender, EventArgs e)
        {
            skipCount--;
            btnSongSkip.Text = "Skip Song (" + skipCount.ToString() + " Left)";
            StartRound();
            if (skipCount == 0)
            {
                btnSongSkip.Enabled = false;
            }
            txtInputField.Focus();
        }

        private void btnNextSong_Click(object sender, EventArgs e)
        {
            ToggleControls();
            StartRound();
            btnNextSong.Enabled = false;
            txtInputField.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            roundTimer.Stop();
            DialogResult = MessageBox.Show("Are you sure you want to Quit?", "Quit Game", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                EndGame();
            }
            else
            {
                roundTimer.Start();
            }
        }
    }
}
 