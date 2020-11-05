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
using FontAwesome.Sharp;

namespace DesktopGUI.SubMenus
{
    public partial class FillVehicleEnergyForm : Form
    {
        private Vehicle m_CurrentVehicle;
        private float m_EnergyToAdd = 0;

        public FillVehicleEnergyForm()
        {
            InitializeComponent();
        }

        private void licenseNumberTextBox_Validated(object sender, EventArgs e)
        {
            m_CurrentVehicle = ManagerLogicGUI.ValidVehicleAndChangeIcon(licenseNumberTextBox.Text, vehicleValidIconButton, vehicleIsFilledButton);
        }

        private void rechargeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setupSubMenuRefuel(false);
        }

        private void refuelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            setupSubMenuRefuel(true);
        }

        private void setupSubMenuRefuel(bool i_OpenRefuelSubMenu)
        {
            subOptionPanel.Visible = i_OpenRefuelSubMenu;
            fuelAmountLabel.Visible = i_OpenRefuelSubMenu;
            fuelAmountTextBox.Visible = i_OpenRefuelSubMenu;
            timeToChargeLabel.Visible = !i_OpenRefuelSubMenu;
            timeToChargeTextBox.Visible = !i_OpenRefuelSubMenu;
        }

        private void inflateNowButton_Click(object sender, EventArgs e)
        {
            string textToPrint = "Vehicle is filled and ready";
            bool additionIsValid = true;

            try
            {
                if (refuelRadioButton.Checked)
                {
                    eFuelType fuelChoice = whichOptionIsSelect();
                    ManagerLogicGUI.GarageManager.RefuelVehicle(licenseNumberTextBox.Text, fuelChoice, m_EnergyToAdd);
                }
                else if (rechargeRadioButton.Checked)
                {
                    ManagerLogicGUI.GarageManager.RechargeVehicle(licenseNumberTextBox.Text, m_EnergyToAdd);
                }
            }
            catch (Exception exception)
            {
                textToPrint = exception.Message;
                additionIsValid = false;
            }

            vehicleIsFilledButton.IconChar = additionIsValid ? 
                                                 FontAwesome.Sharp.IconChar.ThumbsUp 
                                                 : FontAwesome.Sharp.IconChar.ExclamationCircle;
            vehicleIsFilledButton.Text = textToPrint;
        }

        private eFuelType whichOptionIsSelect()
        {
            eFuelType fuelChoice;

            if (octane95RadioButton.Checked)
            {
                fuelChoice = eFuelType.Octane95;
            }
            else if(octane96RadioButton.Checked)
            {
                fuelChoice = eFuelType.Octane96;
            } 
            else if(octane98RadioButton.Checked)
            {
                fuelChoice = eFuelType.Octane98;
            }
            else
            {
                fuelChoice = eFuelType.Soler;
            }

            return fuelChoice;
        }

        private void fuelAmountTextBox_Validated(object sender, EventArgs e)
        {
            isValidValueToChargeOrFuel(fuelAmountTextBox.Text, invalidFuelAmountIconButton);
            timeToChargeTextBox.Text = "0";
        }

        private void timeToChargeTextBox_Validated(object sender, EventArgs e)
        {
            isValidValueToChargeOrFuel(timeToChargeTextBox.Text, invalidChargeIconButton);
            fuelAmountTextBox.Text = "0";
        }

        private void isValidValueToChargeOrFuel(string i_EnergyToAddTextBox, IconButton i_InvalidValueIconButton)
        {
            bool isVehicleEnable = m_CurrentVehicle != null;

            fillNowButton.Enabled = isVehicleEnable && float.TryParse(i_EnergyToAddTextBox, out m_EnergyToAdd);
            i_InvalidValueIconButton.Visible = !fillNowButton.Enabled;
        }
    }
}
