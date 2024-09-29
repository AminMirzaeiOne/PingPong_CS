using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong.Menus
{
    public partial class MainMenu : UserControl
    {
        private PingPong.Pages.ControlPage controlPage = new Pages.ControlPage();
        private PingPong.Pages.SettingsPage settingsPage = new Pages.SettingsPage();
        public System.Windows.Forms.Form Window { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            this.panel3.Controls.Add(this.controlPage);
            this.panel3.Controls.Add(this.settingsPage);
            this.controlPage.Dock = DockStyle.Fill;
            this.settingsPage.Dock = DockStyle.Fill;
            this.controlPage.BringToFront();
        }

        public event EventHandler MaximizeClicked;
        public event EventHandler MinimizeClicked;

        private void radAppControl_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radAppControl.Checked)
            {
                this.controlPage.BringToFront();
            }
        }

        private void radSettings_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radSettings.Checked)
            {
                this.settingsPage.BringToFront();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.controlPage.Window = this.Window;
            this.controlPage.MaximizeClicked += new EventHandler(this.Maximize_Clicked);
            this.controlPage.MinimizeClicked += new EventHandler(this.MinimizeClicked);
        }

        private void Maximize_Clicked(object sender,EventArgs e)
        {
            this.MaximizeClicked(sender, e);
        }

        private void Minimize_Clicked(object sender, EventArgs e)
        {
            this.MinimizeClicked(sender, e);
        }
    }
}
