using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;

namespace Music_Matcher
{
    public partial class frmPlaylistSelector : Form
    {
        public string username;
        public List<string> takenFromFile;
        public List<string> savedPlaylists = new List<string>();
        public bool loginSuccess = false;
        public string playlistName;
        public int timesPlayed;
        public int highscore;
        public frmPlaylistSelector(string currentUser, int timesPlayed, int highscore)
        {
            InitializeComponent();
            username = currentUser;
            this.timesPlayed = timesPlayed;
            this.highscore = highscore;
        }

        private void frmPlaylistSelector_Load(object sender, EventArgs e)
        {
            if (username == null)
            {
                grpBoxSettings.Enabled = false;
                grpBoxSettings.Text = "N/A";
            }
            else
            {
                grpBoxGuest.Enabled = false;
                SetDisplayData();
                LoadUserPlaylists();
            }
        }
        private void LoadUserPlaylists()
        {
            //https://www.delftstack.com/howto/csharp/get-all-files-in-a-directory-in-csharp/
            DirectoryInfo di = new DirectoryInfo("Users/" + username);
            FileInfo[] files = di.GetFiles("*.txt");
            foreach (FileInfo file in files)
            {
                savedPlaylists.Add(file.Name.ToString());
                string current = file.Name.ToString();
                current = current.Remove(current.IndexOf(".txt"), 4);
                cmbBoxPlaylists.Items.Add(current);
            }
            lblPlaylistCount.Text += cmbBoxPlaylists.Items.Count;
        }
        private void SetDisplayData()
        {
            grpBoxSettings.Text = "Settings for " + username;
            lblHighScore.Text += highscore;
            lblTimesPlayed.Text += timesPlayed;

        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            string path = "Users/" + username;
            ofd.ShowDialog();
            takenFromFile = File.ReadAllLines(ofd.FileName).ToList<string>();
            frmNewPlaylistInput frmNewPlaylistInput = new frmNewPlaylistInput();
            frmNewPlaylistInput.ShowDialog();
            if (frmNewPlaylistInput.processComplete == true)
            {
                File.WriteAllLines(path + "/" + frmNewPlaylistInput.playlistName + ".txt", takenFromFile);
                MessageBox.Show("Playlist Added", "Notice");
            }
            cmbBoxPlaylists.Items.Add(frmNewPlaylistInput.playlistName);
            lblPlaylistCount.Text += cmbBoxPlaylists.Items.Count;
            frmNewPlaylistInput.Close();

        }
        private void btnConfirmUserChoice_Click(object sender, EventArgs e)
        {
            if (cmbBoxPlaylists.Text == null)
            {
                MessageBox.Show("Please select a playlist from the dropdown list, or add a new one.");
            }
            else
            {
                playlistName = cmbBoxPlaylists.Text;
                loginSuccess = true;
                this.Close();
            }
        }

        private void btnGuestSelectFile_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            string FileName = (ofd.SafeFileName.Remove(ofd.SafeFileName.IndexOf(".txt"), 4));
            takenFromFile = File.ReadAllLines(ofd.FileName).ToList<string>();
            grpBoxPreview.Text = FileName + " (" + takenFromFile.Count.ToString() + ")";
            foreach (var song in takenFromFile)
            {
                liBoxPlaylistPreview.Items.Add(song);
            }
            btnCancelGuest.Enabled = true;
            btnGuestConfirm.Enabled = true;
            playlistName = FileName;
        }

        private void btnGuestConfirm_Click(object sender, EventArgs e)
        {
            loginSuccess = true;
            this.Close();
        }

        private void btnCancelGuest_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePreview(object sender, EventArgs e)
        {
            if (cmbBoxPlaylists.SelectedIndex >= 0)
            {
                btnConfirmUserChoice.Enabled = true;
            }
            else
            {
                btnConfirmUserChoice.Enabled = false;
            }
            liBoxPlaylistPreview.Items.Clear();
            string path = "Users/" + username + "/" + cmbBoxPlaylists.Text + ".txt";
            takenFromFile = File.ReadAllLines(path).ToList<string>();
            foreach (var song in takenFromFile)
            {
                liBoxPlaylistPreview.Items.Add(song); 
                grpBoxPreview.Text = cmbBoxPlaylists.Text + " (" + takenFromFile.Count.ToString() + ")";
            }
        }
    }
}
