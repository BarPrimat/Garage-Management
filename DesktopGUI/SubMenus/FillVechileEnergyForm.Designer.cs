using System.Drawing;

namespace DesktopGUI.SubMenus
{
    partial class FillVehicleEnergyForm
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
            this.subOptionPanel = new System.Windows.Forms.Panel();
            this.solerRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.octane98RadioButton = new System.Windows.Forms.RadioButton();
            this.octane96RadioButton = new System.Windows.Forms.RadioButton();
            this.octane95RadioButton = new System.Windows.Forms.RadioButton();
            this.refuelRadioButton = new System.Windows.Forms.RadioButton();
            this.rechargeRadioButton = new System.Windows.Forms.RadioButton();
            this.fuelAmountTextBox = new System.Windows.Forms.TextBox();
            this.timeToChargeLabel = new System.Windows.Forms.Label();
            this.fuelAmountLabel = new System.Windows.Forms.Label();
            this.timeToChargeTextBox = new System.Windows.Forms.TextBox();
            this.fillNowButton = new System.Windows.Forms.Button();
            this.vehicleIsFilledButton = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vehicleValidIconButton = new FontAwesome.Sharp.IconButton();
            this.invalidChargeIconButton = new FontAwesome.Sharp.IconButton();
            this.invalidFuelAmountIconButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.subOptionPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 91);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fill vehicle energy";
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
            this.licenseNumberTextBox.Location = new System.Drawing.Point(382, 154);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.Size = new System.Drawing.Size(254, 26);
            this.licenseNumberTextBox.TabIndex = 19;
            this.licenseNumberTextBox.TextChanged += new System.EventHandler(this.licenseNumberTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(32, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Insert license numbe of the vehicle:";
            // 
            // subOptionPanel
            // 
            this.subOptionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subOptionPanel.Controls.Add(this.solerRadioButton);
            this.subOptionPanel.Controls.Add(this.label2);
            this.subOptionPanel.Controls.Add(this.octane98RadioButton);
            this.subOptionPanel.Controls.Add(this.octane96RadioButton);
            this.subOptionPanel.Controls.Add(this.octane95RadioButton);
            this.subOptionPanel.Location = new System.Drawing.Point(424, 226);
            this.subOptionPanel.Name = "subOptionPanel";
            this.subOptionPanel.Size = new System.Drawing.Size(256, 179);
            this.subOptionPanel.TabIndex = 20;
            this.subOptionPanel.Visible = false;
            // 
            // solerRadioButton
            // 
            this.solerRadioButton.AutoSize = true;
            this.solerRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.solerRadioButton.Location = new System.Drawing.Point(17, 145);
            this.solerRadioButton.Name = "solerRadioButton";
            this.solerRadioButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.solerRadioButton.Size = new System.Drawing.Size(101, 24);
            this.solerRadioButton.TabIndex = 20;
            this.solerRadioButton.Text = "Soler";
            this.solerRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Choose the type of fuel:";
            // 
            // octane98RadioButton
            // 
            this.octane98RadioButton.AutoSize = true;
            this.octane98RadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.octane98RadioButton.Location = new System.Drawing.Point(17, 115);
            this.octane98RadioButton.Name = "octane98RadioButton";
            this.octane98RadioButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.octane98RadioButton.Size = new System.Drawing.Size(134, 24);
            this.octane98RadioButton.TabIndex = 5;
            this.octane98RadioButton.Text = "Octane98";
            this.octane98RadioButton.UseVisualStyleBackColor = true;
            // 
            // octane96RadioButton
            // 
            this.octane96RadioButton.AutoSize = true;
            this.octane96RadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.octane96RadioButton.Location = new System.Drawing.Point(17, 85);
            this.octane96RadioButton.Name = "octane96RadioButton";
            this.octane96RadioButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.octane96RadioButton.Size = new System.Drawing.Size(134, 24);
            this.octane96RadioButton.TabIndex = 4;
            this.octane96RadioButton.Text = "Octane96";
            this.octane96RadioButton.UseVisualStyleBackColor = true;
            // 
            // octane95RadioButton
            // 
            this.octane95RadioButton.AutoSize = true;
            this.octane95RadioButton.Checked = true;
            this.octane95RadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.octane95RadioButton.Location = new System.Drawing.Point(17, 55);
            this.octane95RadioButton.Name = "octane95RadioButton";
            this.octane95RadioButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.octane95RadioButton.Size = new System.Drawing.Size(134, 24);
            this.octane95RadioButton.TabIndex = 3;
            this.octane95RadioButton.TabStop = true;
            this.octane95RadioButton.Text = "Octane95";
            this.octane95RadioButton.UseVisualStyleBackColor = true;
            // 
            // refuelRadioButton
            // 
            this.refuelRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refuelRadioButton.AutoSize = true;
            this.refuelRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.refuelRadioButton.Location = new System.Drawing.Point(424, 196);
            this.refuelRadioButton.Name = "refuelRadioButton";
            this.refuelRadioButton.Size = new System.Drawing.Size(81, 24);
            this.refuelRadioButton.TabIndex = 21;
            this.refuelRadioButton.Text = "Refuel";
            this.refuelRadioButton.UseVisualStyleBackColor = true;
            this.refuelRadioButton.CheckedChanged += new System.EventHandler(this.refuelRadioButton_CheckedChanged);
            // 
            // rechargeRadioButton
            // 
            this.rechargeRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rechargeRadioButton.AutoSize = true;
            this.rechargeRadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rechargeRadioButton.Location = new System.Drawing.Point(89, 196);
            this.rechargeRadioButton.Name = "rechargeRadioButton";
            this.rechargeRadioButton.Size = new System.Drawing.Size(104, 24);
            this.rechargeRadioButton.TabIndex = 22;
            this.rechargeRadioButton.Text = "Recharge";
            this.rechargeRadioButton.UseVisualStyleBackColor = true;
            this.rechargeRadioButton.CheckedChanged += new System.EventHandler(this.rechargeRadioButton_CheckedChanged);
            // 
            // fuelAmountTextBox
            // 
            this.fuelAmountTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fuelAmountTextBox.Location = new System.Drawing.Point(625, 409);
            this.fuelAmountTextBox.Name = "fuelAmountTextBox";
            this.fuelAmountTextBox.Size = new System.Drawing.Size(59, 26);
            this.fuelAmountTextBox.TabIndex = 23;
            this.fuelAmountTextBox.Text = "0";
            this.fuelAmountTextBox.Visible = false;
            this.fuelAmountTextBox.TextChanged += new System.EventHandler(this.fuelAmountTextBox_TextChanged);
            // 
            // timeToChargeLabel
            // 
            this.timeToChargeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeToChargeLabel.AutoSize = true;
            this.timeToChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeToChargeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.timeToChargeLabel.Location = new System.Drawing.Point(32, 253);
            this.timeToChargeLabel.Name = "timeToChargeLabel";
            this.timeToChargeLabel.Size = new System.Drawing.Size(353, 25);
            this.timeToChargeLabel.TabIndex = 24;
            this.timeToChargeLabel.Text = "Enter desired time to charge in minutes:";
            this.timeToChargeLabel.Visible = false;
            // 
            // fuelAmountLabel
            // 
            this.fuelAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fuelAmountLabel.AutoSize = true;
            this.fuelAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fuelAmountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fuelAmountLabel.Location = new System.Drawing.Point(357, 408);
            this.fuelAmountLabel.Name = "fuelAmountLabel";
            this.fuelAmountLabel.Size = new System.Drawing.Size(242, 25);
            this.fuelAmountLabel.TabIndex = 26;
            this.fuelAmountLabel.Text = "Enter fuel amount in Liters:";
            this.fuelAmountLabel.Visible = false;
            // 
            // timeToChargeTextBox
            // 
            this.timeToChargeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeToChargeTextBox.Location = new System.Drawing.Point(37, 294);
            this.timeToChargeTextBox.Name = "timeToChargeTextBox";
            this.timeToChargeTextBox.Size = new System.Drawing.Size(237, 26);
            this.timeToChargeTextBox.TabIndex = 25;
            this.timeToChargeTextBox.Text = "0";
            this.timeToChargeTextBox.Visible = false;
            this.timeToChargeTextBox.TextChanged += new System.EventHandler(this.timeToChargeTextBox_TextChanged);
            // 
            // fillNowButton
            // 
            this.fillNowButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillNowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fillNowButton.Enabled = false;
            this.fillNowButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.fillNowButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fillNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillNowButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fillNowButton.Location = new System.Drawing.Point(272, 0);
            this.fillNowButton.Name = "fillNowButton";
            this.fillNowButton.Size = new System.Drawing.Size(193, 49);
            this.fillNowButton.TabIndex = 17;
            this.fillNowButton.Text = "Fill now";
            this.fillNowButton.UseVisualStyleBackColor = true;
            this.fillNowButton.Click += new System.EventHandler(this.inflateNowButton_Click);
            // 
            // vehicleIsFilledButton
            // 
            this.vehicleIsFilledButton.AutoSize = true;
            this.vehicleIsFilledButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vehicleIsFilledButton.FlatAppearance.BorderSize = 0;
            this.vehicleIsFilledButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.vehicleIsFilledButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.vehicleIsFilledButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleIsFilledButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.vehicleIsFilledButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vehicleIsFilledButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.vehicleIsFilledButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.vehicleIsFilledButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vehicleIsFilledButton.IconSize = 35;
            this.vehicleIsFilledButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vehicleIsFilledButton.Location = new System.Drawing.Point(0, 36);
            this.vehicleIsFilledButton.Name = "vehicleIsFilledButton";
            this.vehicleIsFilledButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vehicleIsFilledButton.Rotation = 0D;
            this.vehicleIsFilledButton.Size = new System.Drawing.Size(728, 65);
            this.vehicleIsFilledButton.TabIndex = 23;
            this.vehicleIsFilledButton.Text = "Vehicle is filled";
            this.vehicleIsFilledButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleIsFilledButton.UseVisualStyleBackColor = true;
            this.vehicleIsFilledButton.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fillNowButton);
            this.panel2.Controls.Add(this.vehicleIsFilledButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 101);
            this.panel2.TabIndex = 28;
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
            this.vehicleValidIconButton.Location = new System.Drawing.Point(642, 147);
            this.vehicleValidIconButton.Name = "vehicleValidIconButton";
            this.vehicleValidIconButton.Rotation = 0D;
            this.vehicleValidIconButton.Size = new System.Drawing.Size(57, 41);
            this.vehicleValidIconButton.TabIndex = 29;
            this.vehicleValidIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleValidIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleValidIconButton.UseVisualStyleBackColor = true;
            this.vehicleValidIconButton.Visible = false;
            // 
            // invalidChargeIconButton
            // 
            this.invalidChargeIconButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalidChargeIconButton.AutoSize = true;
            this.invalidChargeIconButton.FlatAppearance.BorderSize = 0;
            this.invalidChargeIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.invalidChargeIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.invalidChargeIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invalidChargeIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.invalidChargeIconButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.invalidChargeIconButton.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.invalidChargeIconButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.invalidChargeIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.invalidChargeIconButton.IconSize = 35;
            this.invalidChargeIconButton.Location = new System.Drawing.Point(291, 287);
            this.invalidChargeIconButton.Name = "invalidChargeIconButton";
            this.invalidChargeIconButton.Rotation = 0D;
            this.invalidChargeIconButton.Size = new System.Drawing.Size(57, 41);
            this.invalidChargeIconButton.TabIndex = 30;
            this.invalidChargeIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invalidChargeIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.invalidChargeIconButton.UseVisualStyleBackColor = true;
            this.invalidChargeIconButton.Visible = false;
            // 
            // invalidFuelAmountIconButton
            // 
            this.invalidFuelAmountIconButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalidFuelAmountIconButton.AutoSize = true;
            this.invalidFuelAmountIconButton.FlatAppearance.BorderSize = 0;
            this.invalidFuelAmountIconButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.invalidFuelAmountIconButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.invalidFuelAmountIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invalidFuelAmountIconButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.invalidFuelAmountIconButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.invalidFuelAmountIconButton.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.invalidFuelAmountIconButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.invalidFuelAmountIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.invalidFuelAmountIconButton.IconSize = 35;
            this.invalidFuelAmountIconButton.Location = new System.Drawing.Point(671, 403);
            this.invalidFuelAmountIconButton.Name = "invalidFuelAmountIconButton";
            this.invalidFuelAmountIconButton.Rotation = 0D;
            this.invalidFuelAmountIconButton.Size = new System.Drawing.Size(57, 41);
            this.invalidFuelAmountIconButton.TabIndex = 31;
            this.invalidFuelAmountIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.invalidFuelAmountIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.invalidFuelAmountIconButton.UseVisualStyleBackColor = true;
            this.invalidFuelAmountIconButton.Visible = false;
            // 
            // FillVehicleEnergyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(728, 540);
            this.Controls.Add(this.invalidFuelAmountIconButton);
            this.Controls.Add(this.invalidChargeIconButton);
            this.Controls.Add(this.vehicleValidIconButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fuelAmountLabel);
            this.Controls.Add(this.timeToChargeTextBox);
            this.Controls.Add(this.fuelAmountTextBox);
            this.Controls.Add(this.timeToChargeLabel);
            this.Controls.Add(this.rechargeRadioButton);
            this.Controls.Add(this.refuelRadioButton);
            this.Controls.Add(this.subOptionPanel);
            this.Controls.Add(this.licenseNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FillVehicleEnergyForm";
            this.Text = "FillVechileEnergyForm";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox licenseNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel subOptionPanel;
        private System.Windows.Forms.RadioButton octane98RadioButton;
        private System.Windows.Forms.RadioButton octane96RadioButton;
        private System.Windows.Forms.RadioButton octane95RadioButton;
        private System.Windows.Forms.RadioButton refuelRadioButton;
        private System.Windows.Forms.RadioButton rechargeRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fuelAmountTextBox;
        private System.Windows.Forms.Label timeToChargeLabel;
        private System.Windows.Forms.Label fuelAmountLabel;
        private System.Windows.Forms.TextBox timeToChargeTextBox;
        private System.Windows.Forms.Button fillNowButton;
        public FontAwesome.Sharp.IconButton vehicleIsFilledButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton solerRadioButton;
        public FontAwesome.Sharp.IconButton vehicleValidIconButton;
        public FontAwesome.Sharp.IconButton invalidChargeIconButton;
        public FontAwesome.Sharp.IconButton invalidFuelAmountIconButton;
    }
}