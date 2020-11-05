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
            Vehicle vehicle;
            bool isVehicleExist = ManagerLogicGUI.GarageManager.FindVehicle(i_LicenseNumber, out vehicle);

            i_ChangeNowIcon.Enabled = isVehicleExist;
            i_VehicleValidIcon.Visible = true;
            i_VehicleValidIcon.IconChar = isVehicleExist
                                              ? FontAwesome.Sharp.IconChar.ThumbsUp
                                              : FontAwesome.Sharp.IconChar.ExclamationCircle;

            return vehicle;

        }
        public static GarageManager GarageManager => r_GarageManager;

        public static VehicleFactory VehicleFactory => r_VehicleFactory;
    }
}
