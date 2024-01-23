namespace Music_Matcher
{
    public partial class frmStartMenu : Form
    {
        public frmStartMenu()
        {
            InitializeComponent();
        }

        private void btnSetupGuide_Click(object sender, EventArgs e)
        {
            frmPlaylistSetup frmPlaylistSetup = new frmPlaylistSetup();
            this.Hide();
            frmPlaylistSetup.Show();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            frmTutorial frmTutorial = new frmTutorial();
            this.Hide();
            frmTutorial.Show();
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            frmGame frmGame = new frmGame();
            this.Hide();
            frmGame.Show();
        }

   
    }
}