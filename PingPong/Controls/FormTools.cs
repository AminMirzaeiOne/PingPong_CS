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

        public System.Windows.Forms.Form Window { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnMaxRes_Click(object sender, EventArgs e)
        {
            if()
        }
    }
}
