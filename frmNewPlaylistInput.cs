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
    public partial class frmNewPlaylistInput : Form
    {
        public bool processComplete = false;
        public string playlistName;
        public frmNewPlaylistInput()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] charCheck = { "'\'", "/", "<", "?", ">", ":", "*", "|" };
            playlistName = txtPlaylistInput.Text;
            foreach (var item in charCheck)
            {
                if (playlistName.Contains(item))
                {
                    playlistName = playlistName.Replace(item, "_");
                }
            }
            processComplete = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 
