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
        public About()
        {
            InitializeComponent();
            this.panel2.Controls.Add(this.versionPage);
            this.versionPage.Dock = DockStyle.Fill;
        }
    }
}
