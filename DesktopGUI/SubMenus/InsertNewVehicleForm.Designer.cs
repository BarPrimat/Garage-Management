using System.Drawing;

namespace DesktopGUI.SubMenus
{
    partial class InsertNewVehicleForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.fillNowButton = new System.Windows.Forms.Button();
            this.vehicleIsFilledButton = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.vehicleValidIconButton = new FontAwesome.Sharp.IconButton();
            this.licenseNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.subOptionPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.subOptionPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Insert new vehicle or change ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 106);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fillNowButton);
            this.panel2.Controls.Add(this.vehicleIsFilledButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 65);
            this.panel2.TabIndex = 29;
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
            this.fillNowButton.Location = new System.Drawing.Point(264, 8);
            this.fillNowButton.Name = "fillNowButton";
            this.fillNowButton.Size = new System.Drawing.Size(193, 45);
            this.fillNowButton.TabIndex = 17;
            this.fillNowButton.Text = "Fill now";
            this.fillNowButton.UseVisualStyleBackColor = true;
            // 
            // vehicleIsFilledButton
            // 
            this.vehicleIsFilledButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicleIsFilledButton.AutoSize = true;
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
            this.vehicleIsFilledButton.Location = new System.Drawing.Point(453, 10);
            this.vehicleIsFilledButton.Name = "vehicleIsFilledButton";
            this.vehicleIsFilledButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vehicleIsFilledButton.Rotation = 0D;
            this.vehicleIsFilledButton.Size = new System.Drawing.Size(193, 41);
            this.vehicleIsFilledButton.TabIndex = 23;
            this.vehicleIsFilledButton.Text = "Vehicle is filled";
            this.vehicleIsFilledButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleIsFilledButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleIsFilledButton.UseVisualStyleBackColor = true;
            this.vehicleIsFilledButton.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.subOptionPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(728, 110);
            this.panel3.TabIndex = 30;
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
            this.vehicleValidIconButton.Location = new System.Drawing.Point(665, 86);
            this.vehicleValidIconButton.Name = "vehicleValidIconButton";
            this.vehicleValidIconButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.vehicleValidIconButton.Rotation = 0D;
            this.vehicleValidIconButton.Size = new System.Drawing.Size(51, 81);
            this.vehicleValidIconButton.TabIndex = 33;
            this.vehicleValidIconButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleValidIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleValidIconButton.UseVisualStyleBackColor = true;
            this.vehicleValidIconButton.Visible = false;
            // 
            // licenseNumberTextBox
            // 
            this.licenseNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.licenseNumberTextBox.Location = new System.Drawing.Point(413, 113);
            this.licenseNumberTextBox.Name = "licenseNumberTextBox";
            this.licenseNumberTextBox.Size = new System.Drawing.Size(254, 26);
            this.licenseNumberTextBox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Insert license numbe of the vehicle:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(143, 73);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 24);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.Text = "Soler";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(3, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(218, 25);
            this.label18.TabIndex = 25;
            this.label18.Text = "Choose the type of fuel:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(134, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.Text = "Octane98";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton3.Location = new System.Drawing.Point(5, 73);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.Text = "Octane96";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton4.Location = new System.Drawing.Point(5, 43);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 24);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Octane95";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // subOptionPanel
            // 
            this.subOptionPanel.Controls.Add(this.radioButton1);
            this.subOptionPanel.Controls.Add(this.label18);
            this.subOptionPanel.Controls.Add(this.radioButton2);
            this.subOptionPanel.Controls.Add(this.radioButton4);
            this.subOptionPanel.Controls.Add(this.radioButton3);
            this.subOptionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.subOptionPanel.Location = new System.Drawing.Point(472, 0);
            this.subOptionPanel.Name = "subOptionPanel";
            this.subOptionPanel.Size = new System.Drawing.Size(256, 110);
            this.subOptionPanel.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(728, 220);
            this.panel4.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.Location = new System.Drawing.Point(413, 191);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(254, 26);
            this.textBox7.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(11, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 25);
            this.label10.TabIndex = 74;
            this.label10.Text = "Choose your vehicle type:";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.Location = new System.Drawing.Point(413, 159);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(254, 26);
            this.textBox6.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(11, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 25);
            this.label8.TabIndex = 72;
            this.label8.Text = "Insert model numbe of the vehicle:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.Location = new System.Drawing.Point(413, 127);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(254, 26);
            this.textBox5.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(11, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 25);
            this.label7.TabIndex = 70;
            this.label7.Text = "Insert model numbe of the vehicle:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.Location = new System.Drawing.Point(413, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 26);
            this.textBox4.TabIndex = 69;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.Location = new System.Drawing.Point(413, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 26);
            this.textBox3.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 25);
            this.label6.TabIndex = 66;
            this.label6.Text = "Insert license numbe of the vehicle:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(413, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 26);
            this.textBox2.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 25);
            this.label5.TabIndex = 64;
            this.label5.Text = "Insert pohone of  vehicle owner:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(413, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 26);
            this.textBox1.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(11, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Insert license numbe name of owner vehicle:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(11, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 25);
            this.label15.TabIndex = 68;
            this.label15.Text = "Insert vehicle\'s Model:";
            // 
            // InsertNewVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(728, 540);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.vehicleValidIconButton);
            this.Controls.Add(this.licenseNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertNewVehicleForm";
            this.Text = "InsertNewVehicleForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.subOptionPanel.ResumeLayout(false);
            this.subOptionPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button fillNowButton;
        public FontAwesome.Sharp.IconButton vehicleIsFilledButton;
        private System.Windows.Forms.Panel panel3;
        public FontAwesome.Sharp.IconButton vehicleValidIconButton;
        private System.Windows.Forms.TextBox licenseNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel subOptionPanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
    }
}