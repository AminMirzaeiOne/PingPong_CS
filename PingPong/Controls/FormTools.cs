using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong.Controls
{
    public partial class FormTools : UserControl
    {
        public FormTools()
        {
            InitializeComponent();
        }

        XDropDown.XToolStripDropDown xTool;

        public System.Boolean MaximizeButton
        {
            get { return this.btnMaxRes.Visible; }
            set 
            { 
                this.btnMaxRes.Visible = value;
                if (value)
                {
                    this.btnMinimize.Location = new Point(430, 2);
                }
                else
                {
                    this.btnMinimize.Location = new Point(485, 2);
                }
            }
        }

        private PingPong.Menus.MainMenu mainMenu = new Menus.MainMenu();

        public System.Windows.Forms.Form Window { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.Window != null)
            {
                this.Window.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            xTool.Show(this.btnIcon);
        }

        private void MinimizeClick(object sender, EventArgs e)
        {
            //this.xTool.Close();
        }

        private void FormTools_Load(object sender, EventArgs e)
        {
            this.mainMenu.Window = this.Window;
            xTool = new XDropDown.XToolStripDropDown(this.mainMenu);
            this.mainMenu.MinimizeClicked += new EventHandler(this.MinimizeClick);
        }
    }
}
