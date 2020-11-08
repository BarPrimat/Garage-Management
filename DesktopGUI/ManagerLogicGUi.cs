using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex03.GarageLogic;
using FontAwesome.Sharp;

namespace DesktopGUI
{
    public class ManagerLogicGUI
    {
        private static readonly GarageManager r_GarageManager = new GarageManager();
        private static readonly VehicleFactory r_VehicleFactory = new VehicleFactory();

        public ManagerLogicGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }

        public static Vehicle ValidVehicleAndChangeIcon(string i_LicenseNumber, IconButton i_VehicleValidIcon, Button i_ChangeNowIcon)
        {
            Vehicle vehicle = ValidVehicleAndChangeIcon(i_LicenseNumber, i_VehicleValidIcon);

            i_ChangeNowIcon.Enabled = vehicle != null;

            return vehicle;
        }

        public static Vehicle ValidVehicleAndChangeIcon(string i_LicenseNumber, IconButton i_VehicleValidIcon)
        {
            Vehicle vehicle;
            bool isVehicleExist = ManagerLogicGUI.GarageManager.FindVehicle(i_LicenseNumber, out vehicle);

            i_VehicleValidIcon.Visible = true;
            i_VehicleValidIcon.IconChar = isVehicleExist
                                              ? FontAwesome.Sharp.IconChar.ThumbsUp
                                              : FontAwesome.Sharp.IconChar.ExclamationCircle;

            return vehicle;
        }

        public static void InitDisplayTextBox(out Panel i_DisplayPanel, out TextBox i_DisplayTextBox)
        {
            i_DisplayPanel = new Panel();
            i_DisplayPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            i_DisplayPanel.Location = new System.Drawing.Point(0, 145);
            i_DisplayPanel.Name = "displayPanel";
            i_DisplayPanel.Size = new System.Drawing.Size(728, 395);
            i_DisplayPanel.TabIndex = 13;

            i_DisplayTextBox = new TextBox();
            i_DisplayTextBox.Multiline = true;
            i_DisplayTextBox.ReadOnly = true;
            i_DisplayTextBox.ScrollBars = ScrollBars.Both;
            i_DisplayTextBox.BorderStyle = BorderStyle.None;
            i_DisplayTextBox.Dock = DockStyle.Fill;
            i_DisplayTextBox.Location = new System.Drawing.Point(101, 161);
            i_DisplayTextBox.Name = "textBox1";
            i_DisplayTextBox.Size = new System.Drawing.Size(100, 26);
            i_DisplayTextBox.TabIndex = 13;
            i_DisplayPanel.Controls.Add(i_DisplayTextBox);
        }

        public static GarageManager GarageManager => r_GarageManager;

        public static VehicleFactory VehicleFactory => r_VehicleFactory;
    }
}
