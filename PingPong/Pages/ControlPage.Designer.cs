namespace PingPong.Pages
{
    partial class ControlPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaxRes = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblBorder = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::PingPong.Properties.Resources.CloseButton;
            this.btnClose.Location = new System.Drawing.Point(24, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 60);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaxRes
            // 
            this.btnMaxRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxRes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxRes.ForeColor = System.Drawing.Color.White;
            this.btnMaxRes.Image = global::PingPong.Properties.Resources.MaxResButton;
            this.btnMaxRes.Location = new System.Drawing.Point(24, 98);
            this.btnMaxRes.Name = "btnMaxRes";
            this.btnMaxRes.Size = new System.Drawing.Size(200, 60);
            this.btnMaxRes.TabIndex = 0;
            this.btnMaxRes.Text = "Maximize";
            this.btnMaxRes.UseVisualStyleBackColor = true;
            this.btnMaxRes.Click += new System.EventHandler(this.btnMaxRes_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::PingPong.Properties.Resources.MinimizeButton;
            this.btnMinimize.Location = new System.Drawing.Point(24, 180);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(200, 60);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "Minimize";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblBorder
            // 
            this.lblBorder.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblBorder.Location = new System.Drawing.Point(0, 260);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(246, 2);
            this.lblBorder.TabIndex = 2;
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::PingPong.Properties.Resources.image__1_;
            this.btnAbout.Location = new System.Drawing.Point(24, 278);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(80, 60);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13F);
            this.btnFeedback.ForeColor = System.Drawing.Color.White;
            this.btnFeedback.Image = global::PingPong.Properties.Resources.image;
            this.btnFeedback.Location = new System.Drawing.Point(144, 278);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(80, 60);
            this.btnFeedback.TabIndex = 0;
            this.btnFeedback.Text = "";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // ControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.lblBorder);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaxRes);
            this.Controls.Add(this.btnClose);
            this.Name = "ControlPage";
            this.Size = new System.Drawing.Size(246, 349);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaxRes;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnFeedback;
    }
}
