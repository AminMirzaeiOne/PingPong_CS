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

        public System.Windows.Forms.Form Window { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(this.Window!= null)
            {
                this.Window.Close();
            }
        }
    }
}
