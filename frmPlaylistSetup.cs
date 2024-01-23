using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Matcher
{
    public partial class frmPlaylistSetup : Form
    {
        List<Image> images = new List<Image>();
        public int currentPage = 1;
        //declare array for images
        //fromfile image search for each image and add them to the array
        private void frmPlaylistSetup_Load(object sender, EventArgs e)
        {
            UpdateDisplay(currentPage);
        }
        public frmPlaylistSetup()
        {
            InitializeComponent();
            images.Add(Image.FromFile("music-matcher-screen-1.png"));
            images.Add(Image.FromFile("music-matcher-screen-2.png"));
            images.Add(Image.FromFile("music-matcher-screen-3.png"));
            images.Add(Image.FromFile("music-matcher-screen-4.png"));
        }

        private void lblNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            UpdateDisplay(currentPage);
        }
        private void lblLastPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            UpdateDisplay(currentPage);
        }

        private void UpdateDisplay(int page)
        {
            txtDisplay.Clear();
            if (currentPage == 5)
            {
                btnOk.Enabled = true;
                btnOk.Show();
                lblNextPage.Enabled = false;
            }
            else
            {
                btnOk.Enabled = false;
                btnOk.Hide();
                lblNextPage.Enabled = true;  
            }
            if (currentPage > 1)
            {
                lblLastPage.Enabled = true;
            }
            else
            {
                lblLastPage.Enabled = false;    
            }
            switch (page)
            {
                case 1:
                    txtDisplay.Text = "Visit 'TuneMyMusic' from the above link.";
                    pbDisplay.Image = images[0];
                    break;
                case 2:
                    txtDisplay.Text = "Select the platform you use for music streaming from the given list.";
                    pbDisplay.Image = images[1];
                    break;
                case 3:
                    txtDisplay.Text = "Follow the instructions given. This example is with spotify, either paste the url of your playlist, or sign in with spotify and select it.";
                    pbDisplay.Image = images[2];
                    break;
                case 4:
                    txtDisplay.Text = "On the Destination page, select the option 'Export to file' and select a TXT format.";
                    pbDisplay.Image = images[3];
                    break;
                case 5:
                    pbDisplay.Image = images[3];
                    txtDisplay.Text = "Press Convert, and download the file, it will be loaded & saved into the program when the game starts.";
                    break;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmStartMenu frmStartMenu = new frmStartMenu();
            currentPage = 1;
            //reset image
            frmStartMenu.Show();
            this.Close();
            
        }

        private void LiLblTuneMyMusic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"http://tunemymusic.com", UseShellExecute = true }); //A solution i have used previously didn't work on this framework, found the solution here: https://learn.microsoft.com/en-us/answers/questions/809281/net6-systemdiagnosticsprocessstart-error.html
            
        }   
    }
}
