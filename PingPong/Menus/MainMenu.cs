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
            this.controlPage.Window = this.Window;
        }

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
    }
}
