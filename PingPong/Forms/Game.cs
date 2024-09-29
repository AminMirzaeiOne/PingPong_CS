using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        //Moves the ball each frame
        private void moveBall(object sender, EventArgs e)
        {
            //Adjusting the bounds (a bit sloppy but useful for testing)
            topBounds = 0;
            bottomBounds = this.Height - 23;
            leftBounds = 0;
            rightBounds = this.Width;

            //If not paused we can advance the position of everything
            if (!paused)
            {
                //Player 1
                this.btnPlayer.Location = new Point((int)(MousePosition.X - this.btnPlayer.Width), this.btnPlayer.Location.Y);
                this.lblBall.Location = new Point(this.lblBall.Location.X + xspeed, this.lblBall.Location.Y + yspeed);

                //Computer
                if (this.lblBall.Location.X > this.btnCPU.Location.X)
                {
                    this.btnCPU.Location = new Point(this.btnCPU.Location.X + 3, this.btnCPU.Location.Y);
                }
                else
                {
                    this.btnCPU.Location = new Point(this.btnCPU.Location.X - 3, this.btnCPU.Location.Y);
                }

                //Ball Control:  Left Wall
                if (this.lblBall.Location.X < leftBounds)
                {
                    xspeed *= -1;
                    while (this.lblBall.Location.X - 1 < leftBounds)
                    {
                        this.lblBall.Location = new Point(this.lblBall.Location.X + 1, this.lblBall.Location.Y);
                    }
                }

                //Ball Control:  Right Wall
                if (this.lblBall.Location.X + this.lblBall.Width > rightBounds)
                {
                    xspeed *= -1;
                    while (this.lblBall.Location.X + 1 > rightBounds)
                    {
                        this.lblBall.Location = new Point(this.lblBall.Location.X - 1, this.lblBall.Location.Y);
                    }
                }

                //Ball Control: Player Paddle
                if (this.lblBall.Location.Y + this.lblBall.Height > this.btnPlayer.Location.Y && this.lblBall.Location.X > (int)(this.btnPlayer.Location.X - this.lblBall.Width / 2) && this.lblBall.Location.X + this.lblBall.Width < (int)(this.btnPlayer.Location.X + this.btnPlayer.Width + this.lblBall.Width / 2) && this.lblBall.Location.Y < (int)(this.btnPlayer.Location.Y + this.btnPlayer.Height / 2))
                {
                    yspeed *= -1;
                    xspeed = Math.Abs(MousePosition.X - lastx);
                    if (xspeed > 4)
                    {
                        xspeed = 4;
                    }
                    else if (xspeed < -4)
                    {
                        xspeed = -4;
                    }
                    else if (xspeed == 0)
                    {
                        Random a = new Random();
                        if (a.NextDouble() > .5)
                        {
                            xspeed = 2;
                        }
                        else
                        {
                            xspeed = -2;
                        }
                    }
                    while (this.lblBall.Location.Y + 1 + this.lblBall.Height > this.btnPlayer.Location.Y)
                    {
                        this.lblBall.Location = new Point(this.lblBall.Location.X, this.lblBall.Location.Y - 1);
                    }
                }

                //Ball Control: CPU Paddle
                if (this.lblBall.Location.Y < this.btnCPU.Location.Y + this.btnCPU.Height && this.lblBall.Location.X > (int)(this.btnCPU.Location.X - this.lblBall.Width / 2) && this.lblBall.Location.X + this.lblBall.Width < (int)(this.btnCPU.Location.X + this.btnPlayer.Width + this.lblBall.Width / 2) && this.lblBall.Location.Y > (int)(this.btnCPU.Location.Y + this.btnCPU.Height / 2))
                {
                    yspeed *= -1;
                    xspeed = Math.Abs(this.btnPlayer.Location.X - lastx_cpu);
                    if (xspeed > 4)
                    {
                        xspeed = 4;
                    }
                    else if (xspeed < -4)
                    {
                        xspeed = -4;
                    }
                    else if (xspeed == 0)
                    {
                        Random a = new Random();
                        if (a.NextDouble() > .5)
                        {
                            xspeed = 2;
                        }
                        else
                        {
                            xspeed = -2;
                        }
                    }
                    while (this.lblBall.Location.Y - 1 < this.btnCPU.Location.Y + this.btnCPU.Height)
                    {
                        this.lblBall.Location = new Point(this.lblBall.Location.X, this.lblBall.Location.Y + 1);
                    }
                }

                //Ball Control: CPU Scoring
                if (this.lblBall.Location.Y > bottomBounds)
                {
                    this.lblBall.Location = new Point(120, 100);
                    Random b = new Random();
                    if (b.NextDouble() > .5)
                    {
                        xspeed = 2;
                    }
                    else
                    {
                        xspeed = -2;
                    }
                    yspeed = -2;
                    score_cpu++;
                    lblCpuPoints.Text = score_cpu.ToString();
                } //Ball Control - Player Scoring
                else if (this.lblBall.Location.Y < topBounds)
                {
                    this.lblBall.Location = new Point(120, 100);
                    Random b = new Random();
                    if (b.NextDouble() > .5)
                    {
                        xspeed = 2;
                    }
                    else
                    {
                        xspeed = -2;
                    }
                    yspeed = 2;
                    score_player++;
                    lblPlayerPoints.Text = score_player.ToString();
                }
                lastx = MousePosition.X;
                lastx_cpu = this.btnCPU.Location.X;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
