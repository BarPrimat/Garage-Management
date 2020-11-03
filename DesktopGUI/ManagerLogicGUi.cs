using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ex03.GarageLogic;

namespace DesktopGUI
{
    public class ManagerLogicGUi
    {
        private static readonly GarageManager r_GarageManager = new GarageManager();
        private static readonly VehicleFactory r_VehicleFactory = new VehicleFactory();

        public ManagerLogicGUi()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }

        public static GarageManager GarageManager => r_GarageManager;

        public static VehicleFactory VehicleFactory => r_VehicleFactory;
    }
}
