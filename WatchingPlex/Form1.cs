using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchingPlex
{
    public partial class WatchingPlex : Form
    {
        public WatchingPlex()
        {
            InitializeComponent();
        }


        private void WatchingPlex_Load(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipTitle = "Watching Plex App";
            notifyIcon.BalloonTipText = "Watching Plex Tip";
            notifyIcon.Text = "Watching Plex Text";
            this.Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void WatchingPlex_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                
            }
            else if (FormWindowState.Normal == this.WindowState)
            { notifyIcon.Visible = false; }
        }

        private void closedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
