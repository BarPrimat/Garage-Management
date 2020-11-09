namespace DesktopGUI
{
    sealed partial class MainMenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.fillVehicleEnergyButton = new FontAwesome.Sharp.IconButton();
            this.inflateVehiclesTiresButton = new FontAwesome.Sharp.IconButton();
            this.changeStatusButton = new FontAwesome.Sharp.IconButton();
            this.displaySubPanel = new System.Windows.Forms.Panel();
            this.statusCategoryButton = new FontAwesome.Sharp.IconButton();
            this.specificVehicleButton = new FontAwesome.Sharp.IconButton();
            this.displayButton = new FontAwesome.Sharp.IconButton();
            this.insertNewVehicleButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainFillPanel = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelSideMenu.SuspendLayout();
            this.displaySubPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSideMenu.Controls.Add(this.exitButton);
            this.panelSideMenu.Controls.Add(this.fillVehicleEnergyButton);
            this.panelSideMenu.Controls.Add(this.inflateVehiclesTiresButton);
            this.panelSideMenu.Controls.Add(this.changeStatusButton);
            this.panelSideMenu.Controls.Add(this.displaySubPanel);
            this.panelSideMenu.Controls.Add(this.displayButton);
            this.panelSideMenu.Controls.Add(this.insertNewVehicleButton);
            this.panelSideMenu.Controls.Add(this.homeButton);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 700);
            this.panelSideMenu.TabIndex = 9;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.exitButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 35;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 580);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exitButton.Rotation = 0D;
            this.exitButton.Size = new System.Drawing.Size(250, 60);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // fillVehicleEnergyButton
            // 
            this.fillVehicleEnergyButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.fillVehicleEnergyButton.FlatAppearance.BorderSize = 0;
            this.fillVehicleEnergyButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.fillVehicleEnergyButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fillVehicleEnergyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillVehicleEnergyButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.fillVehicleEnergyButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fillVehicleEnergyButton.IconChar = FontAwesome.Sharp.IconChar.GasPump;
            this.fillVehicleEnergyButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.fillVehicleEnergyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.fillVehicleEnergyButton.IconSize = 35;
            this.fillVehicleEnergyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fillVehicleEnergyButton.Location = new System.Drawing.Point(0, 520);
            this.fillVehicleEnergyButton.Name = "fillVehicleEnergyButton";
            this.fillVehicleEnergyButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.fillVehicleEnergyButton.Rotation = 0D;
            this.fillVehicleEnergyButton.Size = new System.Drawing.Size(250, 60);
            this.fillVehicleEnergyButton.TabIndex = 7;
            this.fillVehicleEnergyButton.Text = "Fill vehicle energy";
            this.fillVehicleEnergyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fillVehicleEnergyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fillVehicleEnergyButton.UseVisualStyleBackColor = true;
            this.fillVehicleEnergyButton.Click += new System.EventHandler(this.FillVehicleEnergyButton_Click);
            // 
            // inflateVehiclesTiresButton
            // 
            this.inflateVehiclesTiresButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inflateVehiclesTiresButton.FlatAppearance.BorderSize = 0;
            this.inflateVehiclesTiresButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.inflateVehiclesTiresButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inflateVehiclesTiresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inflateVehiclesTiresButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.inflateVehiclesTiresButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inflateVehiclesTiresButton.IconChar = FontAwesome.Sharp.IconChar.TruckMonster;
            this.inflateVehiclesTiresButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.inflateVehiclesTiresButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inflateVehiclesTiresButton.IconSize = 35;
            this.inflateVehiclesTiresButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inflateVehiclesTiresButton.Location = new System.Drawing.Point(0, 460);
            this.inflateVehiclesTiresButton.Name = "inflateVehiclesTiresButton";
            this.inflateVehiclesTiresButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.inflateVehiclesTiresButton.Rotation = 0D;
            this.inflateVehiclesTiresButton.Size = new System.Drawing.Size(250, 60);
            this.inflateVehiclesTiresButton.TabIndex = 6;
            this.inflateVehiclesTiresButton.Text = "Inflate vehicle\'s tires";
            this.inflateVehiclesTiresButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inflateVehiclesTiresButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inflateVehiclesTiresButton.UseVisualStyleBackColor = true;
            this.inflateVehiclesTiresButton.Click += new System.EventHandler(this.InflateVehiclesTiresButton_Click);
            // 
            // changeStatusButton
            // 
            this.changeStatusButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.changeStatusButton.FlatAppearance.BorderSize = 0;
            this.changeStatusButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.changeStatusButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.changeStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeStatusButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.changeStatusButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeStatusButton.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.changeStatusButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.changeStatusButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.changeStatusButton.IconSize = 35;
            this.changeStatusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeStatusButton.Location = new System.Drawing.Point(0, 400);
            this.changeStatusButton.Name = "changeStatusButton";
            this.changeStatusButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.changeStatusButton.Rotation = 0D;
            this.changeStatusButton.Size = new System.Drawing.Size(250, 60);
            this.changeStatusButton.TabIndex = 5;
            this.changeStatusButton.Text = "Change status";
            this.changeStatusButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeStatusButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeStatusButton.UseVisualStyleBackColor = true;
            this.changeStatusButton.Click += new System.EventHandler(this.ChangeStatusButton_Click);
            // 
            // displaySubPanel
            // 
            this.displaySubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.displaySubPanel.Controls.Add(this.statusCategoryButton);
            this.displaySubPanel.Controls.Add(this.specificVehicleButton);
            this.displaySubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.displaySubPanel.Location = new System.Drawing.Point(0, 280);
            this.displaySubPanel.Name = "displaySubPanel";
            this.displaySubPanel.Size = new System.Drawing.Size(250, 120);
            this.displaySubPanel.TabIndex = 4;
            // 
            // statusCategoryButton
            // 
            this.statusCategoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusCategoryButton.FlatAppearance.BorderSize = 0;
            this.statusCategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.statusCategoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusCategoryButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.statusCategoryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.statusCategoryButton.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.statusCategoryButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.statusCategoryButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusCategoryButton.IconSize = 35;
            this.statusCategoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusCategoryButton.Location = new System.Drawing.Point(0, 60);
            this.statusCategoryButton.Name = "statusCategoryButton";
            this.statusCategoryButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.statusCategoryButton.Rotation = 0D;
            this.statusCategoryButton.Size = new System.Drawing.Size(250, 60);
            this.statusCategoryButton.TabIndex = 5;
            this.statusCategoryButton.Text = "By status category";
            this.statusCategoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusCategoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.statusCategoryButton.UseVisualStyleBackColor = true;
            this.statusCategoryButton.Click += new System.EventHandler(this.StatusCategoryButton_Click);
            // 
            // specificVehicleButton
            // 
            this.specificVehicleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.specificVehicleButton.FlatAppearance.BorderSize = 0;
            this.specificVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.specificVehicleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.specificVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specificVehicleButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.specificVehicleButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.specificVehicleButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.specificVehicleButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.specificVehicleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.specificVehicleButton.IconSize = 35;
            this.specificVehicleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.specificVehicleButton.Location = new System.Drawing.Point(0, 0);
            this.specificVehicleButton.Name = "specificVehicleButton";
            this.specificVehicleButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.specificVehicleButton.Rotation = 0D;
            this.specificVehicleButton.Size = new System.Drawing.Size(250, 60);
            this.specificVehicleButton.TabIndex = 4;
            this.specificVehicleButton.Text = "Specific vehicle";
            this.specificVehicleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.specificVehicleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.specificVehicleButton.UseVisualStyleBackColor = true;
            this.specificVehicleButton.Click += new System.EventHandler(this.SpecificVehicleButton_Click);
            // 
            // displayButton
            // 
            this.displayButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayButton.FlatAppearance.BorderSize = 0;
            this.displayButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.displayButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.displayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.displayButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.displayButton.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.displayButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.displayButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.displayButton.IconSize = 35;
            this.displayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayButton.Location = new System.Drawing.Point(0, 220);
            this.displayButton.Name = "displayButton";
            this.displayButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.displayButton.Rotation = 0D;
            this.displayButton.Size = new System.Drawing.Size(250, 60);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "Display";
            this.displayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // insertNewVehicleButton
            // 
            this.insertNewVehicleButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.insertNewVehicleButton.FlatAppearance.BorderSize = 0;
            this.insertNewVehicleButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.insertNewVehicleButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.insertNewVehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertNewVehicleButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.insertNewVehicleButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.insertNewVehicleButton.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.insertNewVehicleButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.insertNewVehicleButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.insertNewVehicleButton.IconSize = 35;
            this.insertNewVehicleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertNewVehicleButton.Location = new System.Drawing.Point(0, 160);
            this.insertNewVehicleButton.Name = "insertNewVehicleButton";
            this.insertNewVehicleButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.insertNewVehicleButton.Rotation = 0D;
            this.insertNewVehicleButton.Size = new System.Drawing.Size(250, 60);
            this.insertNewVehicleButton.TabIndex = 2;
            this.insertNewVehicleButton.Text = "Insert new vehicle";
            this.insertNewVehicleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insertNewVehicleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.insertNewVehicleButton.UseVisualStyleBackColor = true;
            this.insertNewVehicleButton.Click += new System.EventHandler(this.InsertNewVehicleButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.homeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.homeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.IconSize = 35;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.ImeMode = System.Windows.Forms.ImeMode.On;
            this.homeButton.Location = new System.Drawing.Point(0, 100);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.homeButton.Rotation = 0D;
            this.homeButton.Size = new System.Drawing.Size(250, 60);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(250, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 106);
            this.panel1.TabIndex = 8;
            // 
            // mainFillPanel
            // 
            this.mainFillPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(45)))));
            this.mainFillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFillPanel.Location = new System.Drawing.Point(250, 0);
            this.mainFillPanel.Name = "mainFillPanel";
            this.mainFillPanel.Size = new System.Drawing.Size(750, 594);
            this.mainFillPanel.TabIndex = 9;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.mainFillPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Garage Management";
            this.panelSideMenu.ResumeLayout(false);
            this.displaySubPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainFillPanel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public FontAwesome.Sharp.IconButton homeButton;
        public FontAwesome.Sharp.IconButton insertNewVehicleButton;
        public FontAwesome.Sharp.IconButton displayButton;
        private System.Windows.Forms.Panel displaySubPanel;
        public FontAwesome.Sharp.IconButton statusCategoryButton;
        public FontAwesome.Sharp.IconButton specificVehicleButton;
        public FontAwesome.Sharp.IconButton inflateVehiclesTiresButton;
        public FontAwesome.Sharp.IconButton changeStatusButton;
        public FontAwesome.Sharp.IconButton fillVehicleEnergyButton;
        public FontAwesome.Sharp.IconButton exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

