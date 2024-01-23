using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Music_Matcher
{
    public partial class frmGameMenu : Form
    {
        public string username;
        public string password;
        public bool DidUserLogin;
        public string highScore;
        public string timesPlayed;
        public frmGameMenu()
        {
            InitializeComponent();
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        { 
            pnlMainControls.Hide();
            pnlNewAccountControls.Show();
            pnlConfirmTab.Show();
            txtUsername.Focus();
        }

        private void btnValidateCredentials_Click(object sender, EventArgs e)
        {
            string[] users = File.ReadAllLines("userCredentials.txt");
            bool login = false;
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                lblError.Text = "Please fill out both fields";
                grpBoxError.Show();
            }
            else
            {
                foreach (var user in users)
                {
                    string[] parsed = user.Split(", ");
                    if (parsed[0] == txtUsername.Text.Trim() && parsed[1] == txtPassword.Text.Trim())
                    {
                        login = true;
                        if (parsed.Length > 2)
                        {
                            highScore = parsed[2];
                            timesPlayed = parsed[3];
                        }
                        break;
                    }
                }
                if (login == true)
                {
                    username = txtUsername.Text.Trim();
                    password = txtPassword.Text.Trim();
                    DidUserLogin = true;
                
                    this.Close();
                }
                else
                {
                    grpBoxError.Show();
                    lblError.Text = "Username or Password does not match.";
                }
            }
        }
        private void btnNoAccount_Click(object sender, EventArgs e)
        {
            DidUserLogin = false;
            this.Close();
        }

        private void btnConfirmNewAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            bool stop = false;
            List<string> currentUsers = new List<string>();
            string[] userFile = File.ReadAllLines("userCredentials.txt");
            foreach (var user in userFile)
            {
                string[] parts = user.Split(", ");
                currentUsers.Add(parts[0]);
            }
            if (currentUsers.Contains(username))
            {
                grpBoxError.Show();
                lblError.Text = "A user exists with that username.";
                stop = true;
            }
            else if (username == "" || password == "")
            {
                lblError.Text = "Please enter a valid username and password.";
                grpBoxError.Show();
                stop = true;
            }
            else if (password != txtConfirmPassword.Text.Trim())
            {
                lblError.Text = "Password confirmation does not match.";
                stop = true;
            }
            if (stop == false)
            {
                File.AppendAllText("UserCredentials.txt", (username + ", " + password + "\n"));
                grpBoxError.Hide();
                pnlMainControls.Show();
                pnlNewAccountControls.Hide();
                pnlConfirmTab.Hide();
                ClearAllFields();
                Directory.CreateDirectory("Users/" + username);
            }
        }

        private void btnCancelAccountCreation_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            pnlConfirmTab.Hide();
            pnlMainControls.Show();
            pnlNewAccountControls.Hide();
        }
        public void ClearAllFields()
        {
            txtConfirmPassword.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void frmGameMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
