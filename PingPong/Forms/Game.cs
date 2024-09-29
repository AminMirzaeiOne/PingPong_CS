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
            //Set up all the initial speed
            this.xspeed = 2;
            this.yspeed = 2;

            //Make the buttons no longer clickable
            this.lblBall.Enabled = false;
            this.btnPlayer.Enabled = false;

            //Last mouse X position stored here (so we can add curve based on how fast the mouse was moved)
            this.lastx = MousePosition.X;
            this.lastx_cpu = this.btnCPU.Location.X;

            //Scores
            this.score_player = 0;
            this.score_cpu = 0;

            //Screen Boundaries
            this.topBounds = 0;
            this.bottomBounds = this.Height;
            this.leftBounds = 0;
            this.rightBounds = this.Width;

            //Hide the pause text (since it defaults on)
            //pause_txt.Visible = false;

            //Double Buffer (without this technique the screen will flash)
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
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
