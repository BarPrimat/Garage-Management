using System.Drawing;
using System.Windows.Forms;

namespace DesktopGUI.SubMenus
{
    partial class ChangeStatusForm
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
            this.alreadyPaidRadioButton = new System.Windows.Forms.RadioButton();
            this.subOptionPanel = new System.Windows.Forms.Panel();
            this.repairedRadioButton = new System.Windows.Forms.RadioButton();
            this.inRepairRadioButton = new System.Windows.Forms.RadioButton();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changeNowButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.validChangeButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vehicleValidIconButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.subOptionPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(121, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 82);
            this.label1.TabIndex = 9;
            this.label1.Text = "Change Status";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 148);
            this.panel1.TabIndex = 15;
            // 
            // alreadyPaidRadioButton
            // 
            this.alreadyPaidRadioButton.AutoSize = true;
            this.alreadyPaidRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.alreadyPaidRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.alreadyPaidRadioButton.Location = new System.Drawing.Point(0, 78);
            this.alreadyPaidRadioButton.Name = "alreadyPaidRadioButton";
            this.alreadyPaidRadioButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.alreadyPaidRadioButton.Size = new System.Drawing.Size(233, 39);
            this.alreadyPaidRadioButton.TabIndex = 5;
            this.alreadyPaidRadioButton.Text = "Already paid";
            this.alreadyPaidRadioButton.UseVisualStyleBackColor = true;
            // 
            // subOptionPanel
            // 
            this.subOptionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subOptionPanel.Controls.Add(this.alreadyPaidRadioButton);
            this.subOptionPanel.Controls.Add(this.repairedRadioButton);
            this.subOptionPanel.Controls.Add(this.inRepairRadioButton);
            this.subOptionPanel.Location = new System.Drawing.Point(409, 254);
            this.subOptionPanel.Name = "subOptionPanel";
            this.subOptionPanel.Size = new System.Drawing.Size(233, 151);
            this.subOptionPanel.TabIndex = 16;
            // 
            // repairedRadioButton
            // 
            this.repairedRadioButton.AutoSize = true;
            this.repairedRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.repairedRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.repairedRadioButton.Location = new System.Drawing.Point(0, 39);
            this.repairedRadioButton.Name = "repairedRadioButton";
            this.repairedRadioButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.repairedRadioButton.Size = new System.Drawing.Size(233, 39);
            this.repairedRadioButton.TabIndex = 4;
            this.repairedRadioButton.Text = "Repaired";
            this.repairedRadioButton.UseVisualStyleBackColor = true;
            // 
            // inRepairRadioButton
            // 
            this.inRepairRadioButton.AutoSize = true;
            this.inRepairRadioButton.Checked = true;
            this.inRepairRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inRepairRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inRepairRadioButton.Location = new System.Drawing.Point(0, 0);
            this.inRepairRadioButton.Name = "inRepairRadioButton";
            this.inRepairRadioButton.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.inRepairRadioButton.Size = new System.Drawing.Size(233, 39);
            this.inRepairRadioButton.TabIndex = 3;
            this.inRepairRadioButton.TabStop = true;
            this.inRepairRadioButton.Text = "In Repair";
            this.inRepairRadioButton.UseVisualStyleBackColor = true;
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.licenseNumberTextBox.Location = new System.Drawing.Point(388, 170);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.Size = new System.Drawing.Size(254, 26);
            this.licenseNumberTextBox.TabIndex = 19;
            this.licenseNumberTextBox.Validated += new System.EventHandler(this.licenseNumberTextBox_Validated);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Insert license numbe of the vehicle:";
            // 
            // changeNowButton
            // 
            this.changeNowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.changeNowButton.Enabled = false;
            this.changeNowButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.changeNowButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.changeNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeNowButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeNowButton.Location = new System.Drawing.Point(306, 3);
            this.changeNowButton.Name = "changeNowButton";
            this.changeNowButton.Size = new System.Drawing.Size(193, 56);
            this.changeNowButton.TabIndex = 17;
            this.changeNowButton.Text = "Change now";
            this.changeNowButton.UseVisualStyleBackColor = true;
            this.changeNowButton.Click += new System.EventHandler(this.changeNowButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Insert license numbe of the vehicle:";
            // 
            // validChangeButton
            // 
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
            this.validChangeButton.Size = new System.Drawing.Size(250, 60);
            this.validChangeButton.TabIndex = 23;
            this.validChangeButton.Text = "Saved";
            this.validChangeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.validChangeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.validChangeButton.UseVisualStyleBackColor = true;
            this.validChangeButton.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.changeNowButton);
            this.panel2.Controls.Add(this.validChangeButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 129);
            this.panel2.TabIndex = 24;
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
            this.vehicleValidIconButton.Location = new System.Drawing.Point(648, 143);
            this.vehicleValidIconButton.Name = "vehicleValidIconButton";
            this.vehicleValidIconButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vehicleValidIconButton.Rotation = 0D;
            this.vehicleValidIconButton.Size = new System.Drawing.Size(51, 81);
            this.vehicleValidIconButton.TabIndex = 25;
            this.vehicleValidIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleValidIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleValidIconButton.UseVisualStyleBackColor = true;
            this.vehicleValidIconButton.Visible = false;
            // 
            // ChangeStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(728, 540);
            this.Controls.Add(this.vehicleValidIconButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.licenseNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subOptionPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeStatusForm";
            this.Text = "ChangeStatusForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.subOptionPanel.ResumeLayout(false);
            this.subOptionPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private RadioButton alreadyPaidRadioButton;
        private Panel subOptionPanel;
        private RadioButton repairedRadioButton;
        private RadioButton inRepairRadioButton;
        private TextBox licenseNumberTextBox;
        private Label label3;
        private Button changeNowButton;
        private Label label2;
        public FontAwesome.Sharp.IconButton validChangeButton;
        private Panel panel2;
        public FontAwesome.Sharp.IconButton vehicleValidIconButton;
    }
}