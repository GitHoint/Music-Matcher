using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Matcher
{
    public partial class frmResults : Form
    {
        public int playlistProgres;
        public int score;
        public string playlist;
        public string username;

        public frmResults(int playlistProgress, int gameScore, string username, string playlist)
        {
            InitializeComponent();
            this.playlistProgres = playlistProgress;
            score = gameScore;
            this.username = username;
            this.playlist = playlist;
        }

        private void frmResults_Load(object sender, EventArgs e)
        {
            lblPlaylist.Text += playlist;
            lblEndScore.Text += score;
            lblProgress.Text += playlistProgres;
            grpboxResults.Text += username;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
