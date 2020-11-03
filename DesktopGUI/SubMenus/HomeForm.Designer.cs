using System.Drawing;

namespace DesktopGUI.SubMenus
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.insertNewVehicleButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fillVehicleEnergyButton = new System.Windows.Forms.Button();
            this.changeStatusButton = new System.Windows.Forms.Button();
            this.specificVehicleButton = new System.Windows.Forms.Button();
            this.inflateVehiclesTiresButton = new System.Windows.Forms.Button();
            this.statusCategoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(175, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // insertNewVehicleButton
            // 
            this.insertNewVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertNewVehicleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.insertNewVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.insertNewVehicleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.insertNewVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertNewVehicleButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insertNewVehicleButton.Location = new System.Drawing.Point(64, 33);
            this.insertNewVehicleButton.Name = "insertNewVehicleButton";
            this.insertNewVehicleButton.Size = new System.Drawing.Size(193, 56);
            this.insertNewVehicleButton.TabIndex = 3;
            this.insertNewVehicleButton.Text = "Insert new vehicle";
            this.insertNewVehicleButton.UseVisualStyleBackColor = true;
            this.insertNewVehicleButton.Click += new System.EventHandler(this.insertNewVehicleButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fillVehicleEnergyButton);
            this.panel1.Controls.Add(this.changeStatusButton);
            this.panel1.Controls.Add(this.specificVehicleButton);
            this.panel1.Controls.Add(this.inflateVehiclesTiresButton);
            this.panel1.Controls.Add(this.statusCategoryButton);
            this.panel1.Controls.Add(this.insertNewVehicleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 202);
            this.panel1.TabIndex = 5;
            // 
            // fillVehicleEnergyButton
            // 
            this.fillVehicleEnergyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillVehicleEnergyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fillVehicleEnergyButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.fillVehicleEnergyButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fillVehicleEnergyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillVehicleEnergyButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fillVehicleEnergyButton.Location = new System.Drawing.Point(462, 102);
            this.fillVehicleEnergyButton.Name = "fillVehicleEnergyButton";
            this.fillVehicleEnergyButton.Size = new System.Drawing.Size(193, 56);
            this.fillVehicleEnergyButton.TabIndex = 8;
            this.fillVehicleEnergyButton.Text = "Fill vehicle energy";
            this.fillVehicleEnergyButton.UseVisualStyleBackColor = true;
            this.fillVehicleEnergyButton.Click += new System.EventHandler(this.fillVehicleEnergyButton_Click);
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changeStatusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.changeStatusButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.changeStatusButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.changeStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeStatusButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeStatusButton.Location = new System.Drawing.Point(64, 102);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Size = new System.Drawing.Size(193, 56);
            this.changeStatusButton.TabIndex = 7;
            this.changeStatusButton.Text = "Change status";
            this.changeStatusButton.UseVisualStyleBackColor = true;
            this.changeStatusButton.Click += new System.EventHandler(this.changeStatusButton_Click);
            // 
            // specificVehicleButton
            // 
            this.specificVehicleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specificVehicleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.specificVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.specificVehicleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.specificVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specificVehicleButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.specificVehicleButton.Location = new System.Drawing.Point(263, 33);
            this.specificVehicleButton.Name = "specificVehicleButton";
            this.specificVehicleButton.Size = new System.Drawing.Size(193, 56);
            this.specificVehicleButton.TabIndex = 6;
            this.specificVehicleButton.Text = "Display Scpecific vehicle";
            this.specificVehicleButton.UseVisualStyleBackColor = true;
            this.specificVehicleButton.Click += new System.EventHandler(this.specificVehicleButton_Click);
            // 
            // inflateVehiclesTiresButton
            // 
            this.inflateVehiclesTiresButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inflateVehiclesTiresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.inflateVehiclesTiresButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.inflateVehiclesTiresButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inflateVehiclesTiresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inflateVehiclesTiresButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inflateVehiclesTiresButton.Location = new System.Drawing.Point(462, 33);
            this.inflateVehiclesTiresButton.Name = "inflateVehiclesTiresButton";
            this.inflateVehiclesTiresButton.Size = new System.Drawing.Size(193, 56);
            this.inflateVehiclesTiresButton.TabIndex = 5;
            this.inflateVehiclesTiresButton.Text = "Inflate vehicle\'s tires";
            this.inflateVehiclesTiresButton.UseVisualStyleBackColor = true;
            this.inflateVehiclesTiresButton.Click += new System.EventHandler(this.inflateVehiclesTiresButton_Click);
            // 
            // statusCategoryButton
            // 
            this.statusCategoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statusCategoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statusCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.statusCategoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusCategoryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.statusCategoryButton.Location = new System.Drawing.Point(263, 102);
            this.statusCategoryButton.Name = "statusCategoryButton";
            this.statusCategoryButton.Size = new System.Drawing.Size(193, 56);
            this.statusCategoryButton.TabIndex = 4;
            this.statusCategoryButton.Text = "Display By status category";
            this.statusCategoryButton.UseVisualStyleBackColor = true;
            this.statusCategoryButton.Click += new System.EventHandler(this.statusCategoryButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(728, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button insertNewVehicleButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fillVehicleEnergyButton;
        private System.Windows.Forms.Button changeStatusButton;
        private System.Windows.Forms.Button specificVehicleButton;
        private System.Windows.Forms.Button inflateVehiclesTiresButton;
        private System.Windows.Forms.Button statusCategoryButton;
    }
}