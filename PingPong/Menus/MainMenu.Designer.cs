namespace PingPong.Menus
{
    partial class MainMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblBorder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radSettings = new System.Windows.Forms.RadioButton();
            this.radAppControl = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblBorder);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 396);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 349);
            this.panel3.TabIndex = 2;
            // 
            // lblBorder
            // 
            this.lblBorder.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBorder.Location = new System.Drawing.Point(0, 349);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(246, 2);
            this.lblBorder.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.radSettings);
            this.panel2.Controls.Add(this.radAppControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 45);
            this.panel2.TabIndex = 0;
            // 
            // radSettings
            // 
            this.radSettings.Appearance = System.Windows.Forms.Appearance.Button;
            this.radSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSettings.FlatAppearance.BorderSize = 0;
            this.radSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.radSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSettings.ForeColor = System.Drawing.Color.White;
            this.radSettings.Image = global::PingPong.Properties.Resources.icons8_settings_24;
            this.radSettings.Location = new System.Drawing.Point(123, 0);
            this.radSettings.Name = "radSettings";
            this.radSettings.Size = new System.Drawing.Size(123, 45);
            this.radSettings.TabIndex = 3;
            this.radSettings.Text = "Settings";
            this.radSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radSettings.UseVisualStyleBackColor = true;
            this.radSettings.CheckedChanged += new System.EventHandler(this.radSettings_CheckedChanged);
            // 
            // radAppControl
            // 
            this.radAppControl.Appearance = System.Windows.Forms.Appearance.Button;
            this.radAppControl.Checked = true;
            this.radAppControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radAppControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.radAppControl.FlatAppearance.BorderSize = 0;
            this.radAppControl.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.radAppControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radAppControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAppControl.ForeColor = System.Drawing.Color.White;
            this.radAppControl.Image = global::PingPong.Properties.Resources.icons8_adjust_24;
            this.radAppControl.Location = new System.Drawing.Point(0, 0);
            this.radAppControl.Name = "radAppControl";
            this.radAppControl.Size = new System.Drawing.Size(123, 45);
            this.radAppControl.TabIndex = 2;
            this.radAppControl.TabStop = true;
            this.radAppControl.Text = "Control";
            this.radAppControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radAppControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radAppControl.UseVisualStyleBackColor = true;
            this.radAppControl.CheckedChanged += new System.EventHandler(this.radAppControl_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(250, 400);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.RadioButton radAppControl;
        private System.Windows.Forms.RadioButton radSettings;
        private System.Windows.Forms.Panel panel3;
    }
}
