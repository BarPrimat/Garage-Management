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
    public partial class InflateVehiclesTiresForm : Form
    {
        private Vehicle m_CurrentVehicle;

        public InflateVehiclesTiresForm()
        {
            InitializeComponent();
        }

        private void inflateNowButton_Click(object sender, EventArgs e)
        {
            string textToPrint = null;

            this.validChangeButton.Visible = true;
            if (m_CurrentVehicle != null)
            {
                textToPrint = "Saved";
                this.validChangeButton.IconChar = FontAwesome.Sharp.IconChar.ThumbsUp;
            }

            this.validChangeButton.Text = textToPrint;
        }

        private void licenseNumberTextBox_Validated(object sender, EventArgs e)
        {
            m_CurrentVehicle = ManagerLogicGUi.ValidVehicleAndChangeIcon(licenseNumberTextBox.Text, vehicleValidIconButton, inflateNowButton);
        }
    }
}