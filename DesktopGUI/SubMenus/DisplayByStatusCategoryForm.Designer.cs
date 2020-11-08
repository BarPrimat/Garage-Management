using System.Drawing;

namespace DesktopGUI.SubMenus
{
    partial class DisplayByStatusCategoryForm
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
            this.subOptionPanel = new System.Windows.Forms.Panel();
            this.alreadyPaidRadioButton = new System.Windows.Forms.RadioButton();
            this.repairedRadioButton = new System.Windows.Forms.RadioButton();
            this.inRepairRadioButton = new System.Windows.Forms.RadioButton();
            this.displayNowButton = new System.Windows.Forms.Button();
            this.allVehicleRadioButton = new System.Windows.Forms.RadioButton();
            this.sortedByStatusRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goBackIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.subOptionPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goBackIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // subOptionPanel
            // 
            this.subOptionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subOptionPanel.Controls.Add(this.alreadyPaidRadioButton);
            this.subOptionPanel.Controls.Add(this.repairedRadioButton);
            this.subOptionPanel.Controls.Add(this.inRepairRadioButton);
            this.subOptionPanel.Location = new System.Drawing.Point(417, 110);
            this.subOptionPanel.Name = "subOptionPanel";
            this.subOptionPanel.Size = new System.Drawing.Size(233, 151);
            this.subOptionPanel.TabIndex = 11;
            this.subOptionPanel.Visible = false;
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
            // allVehicleRadioButton
            // 
            this.allVehicleRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allVehicleRadioButton.AutoSize = true;
            this.allVehicleRadioButton.Checked = true;
            this.allVehicleRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.allVehicleRadioButton.Location = new System.Drawing.Point(85, 80);
            this.allVehicleRadioButton.Name = "allVehicleRadioButton";
            this.allVehicleRadioButton.Size = new System.Drawing.Size(164, 24);
            this.allVehicleRadioButton.TabIndex = 8;
            this.allVehicleRadioButton.TabStop = true;
            this.allVehicleRadioButton.Text = "Display all vehicles";
            this.allVehicleRadioButton.UseVisualStyleBackColor = true;
            this.allVehicleRadioButton.CheckedChanged += new System.EventHandler(this.allVehicleRadioButton_CheckedChanged);
            // 
            // sortedByStatusRadioButton
            // 
            this.sortedByStatusRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortedByStatusRadioButton.AutoSize = true;
            this.sortedByStatusRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sortedByStatusRadioButton.Location = new System.Drawing.Point(397, 80);
            this.sortedByStatusRadioButton.Name = "sortedByStatusRadioButton";
            this.sortedByStatusRadioButton.Size = new System.Drawing.Size(281, 24);
            this.sortedByStatusRadioButton.TabIndex = 10;
            this.sortedByStatusRadioButton.Text = "Display all vehicles sorted by status";
            this.sortedByStatusRadioButton.UseVisualStyleBackColor = true;
            this.sortedByStatusRadioButton.CheckedChanged += new System.EventHandler(this.sortedByStatusRadioButton_CheckedChanged);
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
            this.mainPanel.Controls.Add(this.subOptionPanel);
            this.mainPanel.Controls.Add(this.sortedByStatusRadioButton);
            this.mainPanel.Controls.Add(this.displayNowButton);
            this.mainPanel.Controls.Add(this.allVehicleRadioButton);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 145);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(728, 395);
            this.mainPanel.TabIndex = 13;
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
            // DisplayByStatusCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(728, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayByStatusCategoryForm";
            this.Text = "DisplayByStatusCategoryForm";
            this.subOptionPanel.ResumeLayout(false);
            this.subOptionPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goBackIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel subOptionPanel;
        private System.Windows.Forms.RadioButton alreadyPaidRadioButton;
        private System.Windows.Forms.RadioButton repairedRadioButton;
        private System.Windows.Forms.RadioButton inRepairRadioButton;
        private System.Windows.Forms.Button displayNowButton;
        private System.Windows.Forms.RadioButton allVehicleRadioButton;
        private System.Windows.Forms.RadioButton sortedByStatusRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox goBackIconPictureBox;
    }
}