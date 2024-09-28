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
    public partial class MultiPanel : UserControl
    {
        public MultiPanel()
        {
            InitializeComponent();
        }

        public List<Panel> Tasks { get; set; } = new List<Panel>();
    }
}
