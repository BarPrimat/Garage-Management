using System.Drawing;

namespace DesktopGUI.SubMenus
{
    partial class insertNewVehicleForm
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
            this.titletLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.displayThisVehicleButton = new System.Windows.Forms.Button();
            this.problemButton = new FontAwesome.Sharp.IconButton();
            this.createOrUpdateVehicleButton = new System.Windows.Forms.Button();
            this.vehicleValidIconButton = new FontAwesome.Sharp.IconButton();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.licenseVehicleLabel = new System.Windows.Forms.Label();
            this.vehicleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.vehicleTypeLabel = new System.Windows.Forms.Label();
            this.vehiclesModelLabel = new System.Windows.Forms.Label();
            this.vehiclesModelTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titletLabel
            // 
            this.titletLabel.AutoSize = true;
            this.titletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.titletLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titletLabel.Location = new System.Drawing.Point(18, 24);
            this.titletLabel.Name = "titletLabel";
            this.titletLabel.Size = new System.Drawing.Size(698, 59);
            this.titletLabel.TabIndex = 9;
            this.titletLabel.Text = "Insert new vehicle or change ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titletLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 106);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.displayThisVehicleButton);
            this.panel2.Controls.Add(this.problemButton);
            this.panel2.Controls.Add(this.createOrUpdateVehicleButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 104);
            this.panel2.TabIndex = 29;
            // 
            // displayThisVehicleButton
            // 
            this.displayThisVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayThisVehicleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.displayThisVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.displayThisVehicleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.displayThisVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayThisVehicleButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.displayThisVehicleButton.Location = new System.Drawing.Point(463, 3);
            this.displayThisVehicleButton.Name = "displayThisVehicleButton";
            this.displayThisVehicleButton.Size = new System.Drawing.Size(154, 46);
            this.displayThisVehicleButton.TabIndex = 25;
            this.displayThisVehicleButton.Text = "Display this vehicle";
            this.displayThisVehicleButton.UseVisualStyleBackColor = true;
            this.displayThisVehicleButton.Visible = false;
            this.displayThisVehicleButton.Click += new System.EventHandler(this.displayThisVehicleButton_Click);
            // 
            // problemButton
            // 
            this.problemButton.AutoSize = true;
            this.problemButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.problemButton.FlatAppearance.BorderSize = 0;
            this.problemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.problemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.problemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.problemButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.problemButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.problemButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            this.problemButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.problemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.problemButton.IconSize = 35;
            this.problemButton.Location = new System.Drawing.Point(0, 58);
            this.problemButton.Name = "problemButton";
            this.problemButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.problemButton.Rotation = 0D;
            this.problemButton.Size = new System.Drawing.Size(728, 46);
            this.problemButton.TabIndex = 24;
            this.problemButton.Text = "Vehicle is filled";
            this.problemButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.problemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.problemButton.UseVisualStyleBackColor = true;
            this.problemButton.Visible = false;
            // 
            // createOrUpdateVehicleButton
            // 
            this.createOrUpdateVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createOrUpdateVehicleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.createOrUpdateVehicleButton.Enabled = false;
            this.createOrUpdateVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.createOrUpdateVehicleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createOrUpdateVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOrUpdateVehicleButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createOrUpdateVehicleButton.Location = new System.Drawing.Point(264, 3);
            this.createOrUpdateVehicleButton.Name = "createOrUpdateVehicleButton";
            this.createOrUpdateVehicleButton.Size = new System.Drawing.Size(193, 45);
            this.createOrUpdateVehicleButton.TabIndex = 17;
            this.createOrUpdateVehicleButton.Text = "Create or update vehicle";
            this.createOrUpdateVehicleButton.UseVisualStyleBackColor = true;
            this.createOrUpdateVehicleButton.Click += new System.EventHandler(this.createOrUpdateVehicleButton_Click);
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
            this.vehicleValidIconButton.IconSize = 25;
            this.vehicleValidIconButton.Location = new System.Drawing.Point(687, 108);
            this.vehicleValidIconButton.Name = "vehicleValidIconButton";
            this.vehicleValidIconButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vehicleValidIconButton.Rotation = 0D;
            this.vehicleValidIconButton.Size = new System.Drawing.Size(41, 36);
            this.vehicleValidIconButton.TabIndex = 33;
            this.vehicleValidIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleValidIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleValidIconButton.UseVisualStyleBackColor = true;
            this.vehicleValidIconButton.Visible = false;
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.licenseNumberTextBox.Location = new System.Drawing.Point(430, 113);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.Size = new System.Drawing.Size(254, 26);
            this.licenseNumberTextBox.TabIndex = 32;
            this.licenseNumberTextBox.TextChanged += new System.EventHandler(this.licenseNumberTextBox_Validated);
            // 
            // licenseVehicleLabel
            // 
            this.licenseVehicleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.licenseVehicleLabel.AutoSize = true;
            this.licenseVehicleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.licenseVehicleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.licenseVehicleLabel.Location = new System.Drawing.Point(11, 114);
            this.licenseVehicleLabel.Name = "licenseVehicleLabel";
            this.licenseVehicleLabel.Size = new System.Drawing.Size(322, 25);
            this.licenseVehicleLabel.TabIndex = 31;
            this.licenseVehicleLabel.Text = "Insert license number of the vehicle:";
            // 
            // vehicleTypeComboBox
            // 
            this.vehicleTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicleTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehicleTypeComboBox.FormattingEnabled = true;
            this.vehicleTypeComboBox.Location = new System.Drawing.Point(429, 176);
            this.vehicleTypeComboBox.Name = "vehicleTypeComboBox";
            this.vehicleTypeComboBox.Size = new System.Drawing.Size(254, 28);
            this.vehicleTypeComboBox.TabIndex = 99;
            this.vehicleTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.vehicleTypeComboBox_SelectedIndexChanged);
            // 
            // vehicleTypeLabel
            // 
            this.vehicleTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicleTypeLabel.AutoSize = true;
            this.vehicleTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehicleTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vehicleTypeLabel.Location = new System.Drawing.Point(11, 175);
            this.vehicleTypeLabel.Name = "vehicleTypeLabel";
            this.vehicleTypeLabel.Size = new System.Drawing.Size(238, 25);
            this.vehicleTypeLabel.TabIndex = 98;
            this.vehicleTypeLabel.Text = "Choose your vehicle type:";
            // 
            // vehiclesModelLabel
            // 
            this.vehiclesModelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehiclesModelLabel.AutoSize = true;
            this.vehiclesModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.vehiclesModelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vehiclesModelLabel.Location = new System.Drawing.Point(11, 145);
            this.vehiclesModelLabel.Name = "vehiclesModelLabel";
            this.vehiclesModelLabel.Size = new System.Drawing.Size(205, 25);
            this.vehiclesModelLabel.TabIndex = 94;
            this.vehiclesModelLabel.Text = "Insert vehicle\'s Model:";
            // 
            // vehiclesModelTextBox
            // 
            this.vehiclesModelTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehiclesModelTextBox.Location = new System.Drawing.Point(430, 145);
            this.vehiclesModelTextBox.Name = "vehiclesModelTextBox";
            this.vehiclesModelTextBox.Size = new System.Drawing.Size(254, 26);
            this.vehiclesModelTextBox.TabIndex = 89;
            // 
            // insertNewVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(728, 540);
            this.Controls.Add(this.vehicleTypeComboBox);
            this.Controls.Add(this.vehicleTypeLabel);
            this.Controls.Add(this.vehicleValidIconButton);
            this.Controls.Add(this.vehiclesModelLabel);
            this.Controls.Add(this.licenseNumberTextBox);
            this.Controls.Add(this.vehiclesModelTextBox);
            this.Controls.Add(this.licenseVehicleLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertNewVehicleForm";
            this.Text = "InsertNewVehicleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titletLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button createOrUpdateVehicleButton;
        public FontAwesome.Sharp.IconButton vehicleValidIconButton;
        private System.Windows.Forms.TextBox licenseNumberTextBox;
        private System.Windows.Forms.Label licenseVehicleLabel;
        private System.Windows.Forms.Label vehicleTypeLabel;
        private System.Windows.Forms.Label vehiclesModelLabel;
        private System.Windows.Forms.TextBox vehiclesModelTextBox;
        private System.Windows.Forms.ComboBox vehicleTypeComboBox;
        public FontAwesome.Sharp.IconButton problemButton;
        private System.Windows.Forms.Button displayThisVehicleButton;
    }
}