using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong.Pages
{
    public partial class ControlPage : UserControl
    {
        public ControlPage()
        {
            InitializeComponent();
        }

        public event EventHandler MinimizeClicked;
        public event EventHandler MaximizeClicked;

        public System.Windows.Forms.Form Window { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
                this.Window.Close();

        }

        private void btnMaxRes_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
            {
                if (this.Window.WindowState == FormWindowState.Normal)
                {
                    this.Window.WindowState = FormWindowState.Maximized;
                }
                else if (this.Window.WindowState == FormWindowState.Maximized)
                {
                    this.Window.WindowState = FormWindowState.Normal;
                }
                this.MaximizeClicked(sender, e);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
            {
                this.Window.WindowState = FormWindowState.Minimized;
            }
            this.MinimizeClicked(sender, e);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            PingPong.Forms.About about = new Forms.About();
            about.ShowDialog();
        }
    }
}
