using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Matcher
{
    public partial class frmTutorial : Form
    {
        int currentPage = 1;
        public frmTutorial()
        {
            InitializeComponent();
        }

        private void frmTutorial_Load(object sender, EventArgs e)
        {
            ToggleNavigation(currentPage);
            DisplayPage(currentPage);
        }
        public void EndTutorial()
        {
            var end = MessageBox.Show("Ready to Play?", caption: "Music Matcher");
            if (end == DialogResult.OK)
            {
                currentPage = 1;
                frmStartMenu frmStartMenu = new frmStartMenu();
                frmStartMenu.Show();
                this.Hide();       
            }
        }
        
        public void ToggleNavigation(int currentPage)
        { 
            if (currentPage != 8)
            {
                btnNextInfo.Enabled = true;

            }
            else
            {
                btnNextInfo.Enabled = false;
                panel1.Enabled = false;
                EndTutorial();
            }
        }
        public void DisplayPage(int currentPage)
        {
            switch (currentPage)
            {
                case 1:
                    {
                        PageOne();
                        break;
                    }
                case 2:
                    {
                        PageTwo();
                        break;
                    }
                case 3:
                    {
                        PageThree();
                        break;
                    }
                case 4:
                    {
                        PageFour();
                        break;
                    }
                case 5:
                    {
                        PageFive();
                        break;
                    }
                case 6:
                    {
                        PageSix();
                        break;
                    }
                case 7:
                    {
                        PageSeven();
                        break;
                    }
                case 8:
                    {
                        break;
                    }
            }
        }

        //Page Functions
        public void PageOne()
        {
            txtInfoDisplay.Text = "Welcome to the tutorial! The aim of the game is to guess the name of a song in your playlist, and all you are given is the length of each word in the song.";
            lblSongNameDisplay.ForeColor = Color.Red;
        }
        public void PageTwo()
        {
            txtInfoDisplay.Text = "You are restricted to 30 seconds to guess the song, after that, the game will end.";
            lblTimerDisplay.ForeColor = Color.Red;
            progressBarTimer.BackColor = Color.Red;
        }
        public void PageThree()
        {
            txtInfoDisplay.Text = "However, each song has the option to recieve 2 hints to make your guess easier. However, using these hints will decrease the score you can earn in that round...";
            btnGetArtist.ForeColor = Color.Red;
            btnRevealChar.ForeColor = Color.Red;
            lblRoundScore.ForeColor = Color.Red;
        }
        public void PageFour()
        {
            txtInfoDisplay.Text = "The first hint will reveal the name of the artist for you.";
            lblArtistName.Show();
            lblArtistName.ForeColor = Color.Red;
            lblRoundScoreValue.Text = "2";
            lblRoundScoreValue.ForeColor = Color.Red;
        }
        public void PageFive()
        {
            txtInfoDisplay.Text = "The second hint will reveal the first letter in each word of the song.";
            lblSongNameDisplay.Text = "I W____ B_ A_____";
            lblSongNameDisplay.ForeColor = Color.Red;
            lblRoundScoreValue.Text = "1";
            lblRoundScoreValue.ForeColor = Color.Red;
        }
        public void PageSix() 
        {
            txtInfoDisplay.Text = "There are also 2 other helpful tools you can use. Extend timer adds 30 seconds to the timer, and skip will completely skip this song. Remember, running out of time ends the game, so skipping can save it for you.";
            btnExtendTimer.ForeColor = Color.Red;
            btnSongSkip.ForeColor = Color.Red;
        }
        public void PageSeven()
        {
            txtInfoDisplay.Text = "The top progress bar and song count show how far into your playlist you have made it.";
            lblGuessedSongs.ForeColor = Color.Red;
            progressBarPlaylistProgress.BackColor = Color.Red;
        }
        public void SetPageDefaults()
        {
            txtInfoDisplay.Clear();
            lblSongNameDisplay.ForeColor = SystemColors.ControlText;
            lblTimerDisplay.ForeColor = SystemColors.ControlText;
            progressBarTimer.BackColor = SystemColors.Control;
            btnGetArtist.ForeColor = SystemColors.ControlText;
            btnRevealChar.ForeColor = SystemColors.ControlText;
            lblRoundScore.ForeColor = SystemColors.ControlText;
            lblGuessedSongs.ForeColor = SystemColors.ControlText;
            progressBarPlaylistProgress.BackColor = SystemColors.Control;
            btnExtendTimer.ForeColor = SystemColors.ControlText;
            btnSongSkip.ForeColor = SystemColors.ControlText;
            lblSongNameDisplay.Text = "_ _____ __ ______";
            btnGetArtist.Enabled = true;
            btnRevealChar.Enabled = true;
            lblRoundScoreValue.Text = "3";
            lblRoundScoreValue.ForeColor = SystemColors.ControlText;
            lblArtistName.Hide();
            lblArtistName.ForeColor = SystemColors.ControlText;
        }

        private void btnNextInfo_Click(object sender, EventArgs e)
        {
            currentPage++;
            ToggleNavigation(currentPage);
            SetPageDefaults();
            DisplayPage(currentPage);
        }
    }
}
