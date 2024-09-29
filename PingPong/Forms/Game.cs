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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        int xspeed;
        int yspeed;
        int lastx;
        int lastx_cpu;
        int score_player;
        int score_cpu;
        int topBounds;
        int bottomBounds;
        int leftBounds;
        int rightBounds;
        bool paused = false;

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
