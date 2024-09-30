namespace PingPong.Forms
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.formTools1 = new PingPong.Controls.FormTools();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCPU = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCpuPoints = new System.Windows.Forms.Label();
            this.lblCpuColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPlayer = new System.Windows.Forms.Button();
            this.lblBall = new System.Windows.Forms.Label();
            this.btnCPU = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.formTools1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 594);
            this.panel1.TabIndex = 0;
            // 
            // formTools1
            // 
            this.formTools1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.formTools1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formTools1.Location = new System.Drawing.Point(0, 0);
            this.formTools1.Name = "formTools1";
            this.formTools1.Size = new System.Drawing.Size(594, 45);
            this.formTools1.TabIndex = 0;
            this.formTools1.Window = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnCPU);
            this.panel2.Controls.Add(this.btnPlayer);
            this.panel2.Controls.Add(this.lblBall);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 489);
            this.panel2.TabIndex = 1;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(79, 15);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(128, 30);
            this.lblCPU.TabIndex = 0;
            this.lblCPU.Text = "CPU Points :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblCpuColor);
            this.panel3.Controls.Add(this.lblPlayerPoints);
            this.panel3.Controls.Add(this.lblCpuPoints);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblCPU);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 60);
            this.panel3.TabIndex = 2;
            // 
            // lblCpuPoints
            // 
            this.lblCpuPoints.AutoSize = true;
            this.lblCpuPoints.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuPoints.ForeColor = System.Drawing.Color.White;
            this.lblCpuPoints.Location = new System.Drawing.Point(208, 15);
            this.lblCpuPoints.Name = "lblCpuPoints";
            this.lblCpuPoints.Size = new System.Drawing.Size(25, 30);
            this.lblCpuPoints.TabIndex = 0;
            this.lblCpuPoints.Text = "0";
            // 
            // lblCpuColor
            // 
            this.lblCpuColor.BackColor = System.Drawing.Color.Crimson;
            this.lblCpuColor.Location = new System.Drawing.Point(53, 21);
            this.lblCpuColor.Name = "lblCpuColor";
            this.lblCpuColor.Size = new System.Drawing.Size(20, 20);
            this.lblCpuColor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Points :";
            // 
            // lblPlayerPoints
            // 
            this.lblPlayerPoints.AutoSize = true;
            this.lblPlayerPoints.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerPoints.ForeColor = System.Drawing.Color.White;
            this.lblPlayerPoints.Location = new System.Drawing.Point(515, 15);
            this.lblPlayerPoints.Name = "lblPlayerPoints";
            this.lblPlayerPoints.Size = new System.Drawing.Size(25, 30);
            this.lblPlayerPoints.TabIndex = 0;
            this.lblPlayerPoints.Text = "0";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(342, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(289, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 61);
            this.label4.TabIndex = 3;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(594, 2);
            this.label5.TabIndex = 4;
            // 
            // btnPlayer
            // 
            this.btnPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayer.BackColor = System.Drawing.Color.SlateBlue;
            this.btnPlayer.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.btnPlayer.FlatAppearance.BorderSize = 0;
            this.btnPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlayer.Location = new System.Drawing.Point(213, 429);
            this.btnPlayer.Name = "btnPlayer";
            this.btnPlayer.Size = new System.Drawing.Size(160, 30);
            this.btnPlayer.TabIndex = 0;
            this.btnPlayer.UseVisualStyleBackColor = false;
            // 
            // lblBall
            // 
            this.lblBall.BackColor = System.Drawing.Color.Orange;
            this.lblBall.Location = new System.Drawing.Point(289, 331);
            this.lblBall.Name = "lblBall";
            this.lblBall.Size = new System.Drawing.Size(30, 30);
            this.lblBall.TabIndex = 3;
            // 
            // btnCPU
            // 
            this.btnCPU.BackColor = System.Drawing.Color.Crimson;
            this.btnCPU.FlatAppearance.BorderSize = 0;
            this.btnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPU.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCPU.Location = new System.Drawing.Point(213, 22);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(160, 30);
            this.btnCPU.TabIndex = 0;
            this.btnCPU.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.moveBall);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResizeEnd += new System.EventHandler(this.movePlayers);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Controls.FormTools formTools1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCpuPoints;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCpuColor;
        private System.Windows.Forms.Label lblPlayerPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPlayer;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Label lblBall;
        private System.Windows.Forms.Timer timer1;
    }
}