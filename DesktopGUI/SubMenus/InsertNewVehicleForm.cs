using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopGUI.SubMenus
{
    public partial class InsertNewVehicleForm : Form
    {
        public InsertNewVehicleForm()
        {
            InitializeComponent();
        }

        public void m()
        {
            List<string> parametersList = ManagerLogicGUI.VehicleFactory.GetExtendedParametersList(i_Vehicle.VehicleType);

            foreach (string parameterKey in parametersList)
            {
                switch(WindowState)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                }
            }
                "Please enter {0}:", parameterKey;
            }
    }
}
