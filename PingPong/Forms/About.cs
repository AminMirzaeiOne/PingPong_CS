using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong.Forms
{
    public partial class About : Form
    {
        PingPong.Pages.VersionPage versionPage = new Pages.VersionPage();
        PingPong.Pages.DeveloperPage developerPage = new Pages.DeveloperPage();
        public About()
        {
            InitializeComponent();
            this.panel2.Controls.Add(this.versionPage);
            this.panel2.Controls.Add(this.developerPage);
            this.versionPage.Dock = DockStyle.Fill;
            this.developerPage.Dock = DockStyle.Fill;
        }

        private void radVersion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radVersion.Checked)
            {
                this.versionPage.BringToFront();
            }
        }

        private void radDeveloper_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radDeveloper.Checked)
            {
                this.developerPage.BringToFront();
            }
        }

        private void About_Load(object sender, EventArgs e)
        {
            this.versionPage.BringToFront();
        }
    }
}
