namespace PingPong.Controls
{
    partial class FormTools
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
            this.components = new System.ComponentModel.Container();
            this.btnIcon = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaxRes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnIcon
            // 
            this.btnIcon.BackColor = System.Drawing.Color.Black;
            this.btnIcon.BackgroundImage = global::PingPong.Properties.Resources.PingPongIcon;
            this.btnIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIcon.FlatAppearance.BorderSize = 0;
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.Location = new System.Drawing.Point(0, 0);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(45, 45);
            this.btnIcon.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnIcon, "Options");
            this.btnIcon.UseVisualStyleBackColor = false;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMinimize.BackgroundImage = global::PingPong.Properties.Resources.MinimizeButton;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe MDL2 Assets", 2F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(430, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 40);
            this.btnMinimize.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnMinimize, "Minimize");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaxRes
            // 
            this.btnMaxRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMaxRes.BackgroundImage = global::PingPong.Properties.Resources.MaxResButton;
            this.btnMaxRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaxRes.FlatAppearance.BorderSize = 0;
            this.btnMaxRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxRes.Font = new System.Drawing.Font("Segoe MDL2 Assets", 2F);
            this.btnMaxRes.ForeColor = System.Drawing.Color.White;
            this.btnMaxRes.Location = new System.Drawing.Point(485, 2);
            this.btnMaxRes.Name = "btnMaxRes";
            this.btnMaxRes.Size = new System.Drawing.Size(44, 40);
            this.btnMaxRes.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnMaxRes, "Maximize");
            this.btnMaxRes.UseVisualStyleBackColor = false;
            this.btnMaxRes.Click += new System.EventHandler(this.btnMaxRes_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnClose.BackgroundImage = global::PingPong.Properties.Resources.CloseButton;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 2F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(538, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 40);
            this.btnClose.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnClose, "Exit Game");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaxRes);
            this.Controls.Add(this.btnClose);
            this.Name = "FormTools";
            this.Size = new System.Drawing.Size(594, 45);
            this.Load += new System.EventHandler(this.FormTools_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaxRes;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
