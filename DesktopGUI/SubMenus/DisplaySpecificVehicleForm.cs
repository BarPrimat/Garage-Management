using System;
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
        private Vehicle m_CurrentVehicle;

        public DisplaySpecificVehicleForm(string i_LicenseNumber)
        {
            InitializeComponent();
            initDisplayTextBox();
            if (!i_LicenseNumber.Equals(string.Empty))
            {
                m_CurrentVehicle = ManagerLogicGUI.ValidVehicleAndChangeIcon(i_LicenseNumber, vehicleValidIconButton, displayNowButton);
                displayNowButton_Click(null, EventArgs.Empty);
            }
        }

        private void initDisplayTextBox()
        {
            ManagerLogicGUI.InitDisplayTextBox(out m_DisplayPanel, out m_DisplayTextBox);
        }

        private void displayNowButton_Click(object sender, EventArgs e)
        {
            if (m_CurrentVehicle != null)
            {
                m_DisplayTextBox.Text = m_CurrentVehicle.ToString();
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

        private void licenseNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            m_CurrentVehicle = ManagerLogicGUI.ValidVehicleAndChangeIcon(licenseNumberTextBox.Text, vehicleValidIconButton, displayNowButton);
        }
    }
}
