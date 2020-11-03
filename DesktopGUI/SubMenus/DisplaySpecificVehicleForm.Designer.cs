using System.Drawing;

namespace DesktopGUI.SubMenus
{
    partial class DisplaySpecificVehicleForm
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
            this.displayNowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goBackIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goBackIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // displayNowButton
            // 
            this.displayNowButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayNowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.displayNowButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.displayNowButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.displayNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayNowButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.displayNowButton.Location = new System.Drawing.Point(247, 303);
            this.displayNowButton.Name = "displayNowButton";
            this.displayNowButton.Size = new System.Drawing.Size(193, 56);
            this.displayNowButton.TabIndex = 12;
            this.displayNowButton.Text = "Display now";
            this.displayNowButton.UseVisualStyleBackColor = true;
            this.displayNowButton.Click += new System.EventHandler(this.displayNowButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(177, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 108);
            this.label1.TabIndex = 9;
            this.label1.Text = "Display";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.licenseNumberTextBox);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.displayNowButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 145);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(728, 395);
            this.mainPanel.TabIndex = 13;
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Location = new System.Drawing.Point(409, 149);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.Size = new System.Drawing.Size(254, 26);
            this.licenseNumberTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(45, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Insert license numbe of the vehicle:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(168, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Display spacific vehicle";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.goBackIconPictureBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 148);
            this.panel1.TabIndex = 14;
            // 
            // goBackIconPictureBox
            // 
            this.goBackIconPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.goBackIconPictureBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.goBackIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.goBackIconPictureBox.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.goBackIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goBackIconPictureBox.IconSize = 55;
            this.goBackIconPictureBox.Location = new System.Drawing.Point(27, 73);
            this.goBackIconPictureBox.Name = "goBackIconPictureBox";
            this.goBackIconPictureBox.Size = new System.Drawing.Size(55, 60);
            this.goBackIconPictureBox.TabIndex = 10;
            this.goBackIconPictureBox.TabStop = false;
            this.goBackIconPictureBox.Visible = false;
            this.goBackIconPictureBox.Click += new System.EventHandler(this.goBackIconPictureBox_Click);
            // 
            // DisplaySpecificVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(728, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplaySpecificVehicleForm";
            this.Text = "DisplayByStatusCategoryForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goBackIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button specificVehicleButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button displayNowButton;
        private System.Windows.Forms.Panel mainPanel;
        private FontAwesome.Sharp.IconPictureBox goBackIconPictureBox;
        private System.Windows.Forms.TextBox licenseNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}