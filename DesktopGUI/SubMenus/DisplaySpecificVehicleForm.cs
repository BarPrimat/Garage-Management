﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex03.GarageLogic;

namespace DesktopGUI.SubMenus
{
    public partial class DisplaySpecificVehicleForm : Form
    {
        private Panel m_DisplayPanel;
        private TextBox m_DisplayTextBox;

        public DisplaySpecificVehicleForm()
        {
            InitializeComponent();
            initDisplayTextBox();
        }

        private void initDisplayTextBox()
        {
            m_DisplayPanel = new Panel();
            m_DisplayPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            m_DisplayPanel.Location = new System.Drawing.Point(0, 145);
            m_DisplayPanel.Name = "displayPanel";
            m_DisplayPanel.Size = new System.Drawing.Size(728, 395);
            m_DisplayPanel.TabIndex = 13;

            m_DisplayTextBox = new TextBox();
            m_DisplayTextBox.Multiline = true;
            m_DisplayTextBox.ReadOnly = true;
            m_DisplayTextBox.ScrollBars = ScrollBars.Both;
            m_DisplayTextBox.BorderStyle = BorderStyle.None;
            m_DisplayTextBox.Dock = DockStyle.Fill;
            m_DisplayTextBox.Location = new System.Drawing.Point(101, 161);
            m_DisplayTextBox.Name = "textBox1";
            m_DisplayTextBox.Size = new System.Drawing.Size(100, 26);
            m_DisplayTextBox.TabIndex = 13;
            m_DisplayPanel.Controls.Add(m_DisplayTextBox);
        }

        private void displayNowButton_Click(object sender, EventArgs e)
        {
            Vehicle vehicle;
            ManagerLogicGUi.GarageManager.FindVehicle(licenseNumberTextBox.Text, out vehicle);

            if(vehicle != null)
            {
                m_DisplayTextBox.Text = vehicle.ToString();
            }
            else
            {
                m_DisplayTextBox.Text = "The vehicle is not in the garage";
            }

            this.Controls.Remove(mainPanel);
            goBackIconPictureBox.Visible = true;
            this.Controls.Add(m_DisplayPanel);
        }

        private void goBackIconPictureBox_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(m_DisplayPanel);
            goBackIconPictureBox.Visible = false;
            this.Controls.Add(mainPanel);
        }
    }
}
