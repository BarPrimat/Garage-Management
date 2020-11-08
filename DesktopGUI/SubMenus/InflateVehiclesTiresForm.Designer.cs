using System.Drawing;

namespace DesktopGUI.SubMenus
{
    partial class InflateVehiclesTiresForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inflateNowButton = new System.Windows.Forms.Button();
            this.validChangeButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vehicleValidIconButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "Inflate tires to maximum";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 148);
            this.panel1.TabIndex = 16;
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.licenseNumberTextBox.Location = new System.Drawing.Point(401, 286);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.Size = new System.Drawing.Size(254, 26);
            this.licenseNumberTextBox.TabIndex = 26;
            this.licenseNumberTextBox.TextChanged += new System.EventHandler(this.licenseNumberTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(37, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Insert license numbe of the vehicle:";
            // 
            // inflateNowButton
            // 
            this.inflateNowButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inflateNowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inflateNowButton.Enabled = false;
            this.inflateNowButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.inflateNowButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inflateNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inflateNowButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inflateNowButton.Location = new System.Drawing.Point(272, 3);
            this.inflateNowButton.Name = "inflateNowButton";
            this.inflateNowButton.Size = new System.Drawing.Size(193, 56);
            this.inflateNowButton.TabIndex = 17;
            this.inflateNowButton.Text = "Inflate now";
            this.inflateNowButton.UseVisualStyleBackColor = true;
            this.inflateNowButton.Click += new System.EventHandler(this.inflateNowButton_Click);
            // 
            // validChangeButton
            // 
            this.validChangeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.validChangeButton.AutoSize = true;
            this.validChangeButton.FlatAppearance.BorderSize = 0;
            this.validChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.validChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.validChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validChangeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.validChangeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.validChangeButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.validChangeButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.validChangeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.validChangeButton.IconSize = 35;
            this.validChangeButton.Location = new System.Drawing.Point(272, 65);
            this.validChangeButton.Name = "validChangeButton";
            this.validChangeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.validChangeButton.Rotation = 0D;
            this.validChangeButton.Size = new System.Drawing.Size(193, 60);
            this.validChangeButton.TabIndex = 23;
            this.validChangeButton.Text = "Saved";
            this.validChangeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.validChangeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.validChangeButton.UseVisualStyleBackColor = true;
            this.validChangeButton.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inflateNowButton);
            this.panel2.Controls.Add(this.validChangeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 129);
            this.panel2.TabIndex = 27;
            // 
            // vehicleValidIconButton
            // 
            this.vehicleValidIconButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicleValidIconButton.AutoSize = true;
            this.vehicleValidIconButton.FlatAppearance.BorderSize = 0;
            this.vehicleValidIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.vehicleValidIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.vehicleValidIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleValidIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.vehicleValidIconButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vehicleValidIconButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.vehicleValidIconButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.vehicleValidIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vehicleValidIconButton.IconSize = 35;
            this.vehicleValidIconButton.Location = new System.Drawing.Point(661, 260);
            this.vehicleValidIconButton.Name = "vehicleValidIconButton";
            this.vehicleValidIconButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vehicleValidIconButton.Rotation = 0D;
            this.vehicleValidIconButton.Size = new System.Drawing.Size(51, 81);
            this.vehicleValidIconButton.TabIndex = 28;
            this.vehicleValidIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleValidIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleValidIconButton.UseVisualStyleBackColor = true;
            this.vehicleValidIconButton.Visible = false;
            // 
            // InflateVehiclesTiresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(728, 540);
            this.Controls.Add(this.vehicleValidIconButton);
            this.Controls.Add(this.licenseNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InflateVehiclesTiresForm";
            this.Text = "InflateVehiclesTiresForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox licenseNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button inflateNowButton;
        public FontAwesome.Sharp.IconButton validChangeButton;
        private System.Windows.Forms.Panel panel2;
        public FontAwesome.Sharp.IconButton vehicleValidIconButton;
    }
}