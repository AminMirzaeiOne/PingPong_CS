namespace PingPong.Forms
{
    partial class About
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radDeveloper = new System.Windows.Forms.RadioButton();
            this.radVersion = new System.Windows.Forms.RadioButton();
            this.formTools1 = new PingPong.Controls.FormTools();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.formTools1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 494);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radDeveloper, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radVersion, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 434);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 60);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // radDeveloper
            // 
            this.radDeveloper.Appearance = System.Windows.Forms.Appearance.Button;
            this.radDeveloper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radDeveloper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDeveloper.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.radDeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radDeveloper.ForeColor = System.Drawing.Color.White;
            this.radDeveloper.Location = new System.Drawing.Point(200, 3);
            this.radDeveloper.Name = "radDeveloper";
            this.radDeveloper.Size = new System.Drawing.Size(191, 54);
            this.radDeveloper.TabIndex = 2;
            this.radDeveloper.TabStop = true;
            this.radDeveloper.Text = "Developer";
            this.radDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radDeveloper.UseVisualStyleBackColor = true;
            // 
            // radVersion
            // 
            this.radVersion.Appearance = System.Windows.Forms.Appearance.Button;
            this.radVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radVersion.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.radVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radVersion.ForeColor = System.Drawing.Color.White;
            this.radVersion.Location = new System.Drawing.Point(3, 3);
            this.radVersion.Name = "radVersion";
            this.radVersion.Size = new System.Drawing.Size(191, 54);
            this.radVersion.TabIndex = 1;
            this.radVersion.TabStop = true;
            this.radVersion.Text = "Version";
            this.radVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radVersion.UseVisualStyleBackColor = true;
            // 
            // formTools1
            // 
            this.formTools1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.formTools1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formTools1.Location = new System.Drawing.Point(0, 0);
            this.formTools1.MaximizeButton = false;
            this.formTools1.Name = "formTools1";
            this.formTools1.Size = new System.Drawing.Size(394, 45);
            this.formTools1.TabIndex = 3;
            this.formTools1.Window = null;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 2);
            this.label1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 387);
            this.panel2.TabIndex = 6;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radDeveloper;
        private System.Windows.Forms.RadioButton radVersion;
        private Controls.FormTools formTools1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}