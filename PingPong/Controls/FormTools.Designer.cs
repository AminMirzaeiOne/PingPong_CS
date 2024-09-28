﻿namespace PingPong.Controls
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
            this.btnMaxRes = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaxRes
            // 
            this.btnMaxRes.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxRes.BackgroundImage = global::PingPong.Properties.Resources.MaxResButton;
            this.btnMaxRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaxRes.FlatAppearance.BorderSize = 0;
            this.btnMaxRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxRes.Font = new System.Drawing.Font("Segoe MDL2 Assets", 2F);
            this.btnMaxRes.ForeColor = System.Drawing.Color.White;
            this.btnMaxRes.Location = new System.Drawing.Point(494, 2);
            this.btnMaxRes.Name = "btnMaxRes";
            this.btnMaxRes.Size = new System.Drawing.Size(44, 40);
            this.btnMaxRes.TabIndex = 0;
            this.btnMaxRes.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::PingPong.Properties.Resources.CloseButton;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 2F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(547, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // FormTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Controls.Add(this.btnMaxRes);
            this.Controls.Add(this.btnClose);
            this.Name = "FormTools";
            this.Size = new System.Drawing.Size(600, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaxRes;
    }
}
