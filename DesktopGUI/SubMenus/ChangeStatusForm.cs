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
    public partial class ChangeStatusForm : Form
    {
        private Vehicle m_CurrentVehicle;
        public ChangeStatusForm()
        {
            InitializeComponent();
        }

        private void changeNowButton_Click(object sender, EventArgs e)
        {
            string textToPrint = null;

            this.validChangeButton.Visible = true;
            if (m_CurrentVehicle != null) 
            {
                eVehicleStatus newStatus = eVehicleStatus.InRepair;
                textToPrint = "Saved";
                this.validChangeButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
                if(repairedRadioButton.Checked)
                {
                    newStatus = eVehicleStatus.Repaired;
                }
                else if(alreadyPaidRadioButton.Checked)
                {
                    newStatus = eVehicleStatus.PayedFor;
                }

                ManagerLogicGUI.GarageManager.ChangeVehicleStatus(licenseNumberTextBox.Text, newStatus);
            }

            this.validChangeButton.Text = textToPrint;
        }

        private void licenseNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            m_CurrentVehicle = ManagerLogicGUI.ValidVehicleAndChangeIcon(licenseNumberTextBox.Text, vehicleValidIconButton, changeNowButton);
        }
    }
}
