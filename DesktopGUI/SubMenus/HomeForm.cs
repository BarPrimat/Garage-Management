﻿using System;
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
    public partial class HomeForm : Form
    {
        private readonly MainMenuForm r_ParentForm;

        public HomeForm(MainMenuForm i_ParentForm)
        {
            InitializeComponent();
            r_ParentForm = i_ParentForm;
        }

        private void insertNewVehicleButton_Click(object sender, EventArgs e)
        {
            r_ParentForm.InsertNewVehicleButton_Click(r_ParentForm.insertNewVehicleButton, EventArgs.Empty);
        }
        
        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            r_ParentForm.ChangeStatusButton_Click(r_ParentForm.changeStatusButton, EventArgs.Empty);
        }

        // Start display option
        public void SpecificVehicleButton_Click(object sender, EventArgs e)
        {
            r_ParentForm.DisplayButton_Click(r_ParentForm.displayButton, EventArgs.Empty);
            r_ParentForm.SpecificVehicleButton_Click(r_ParentForm.specificVehicleButton, EventArgs.Empty);
        }

        private void statusCategoryButton_Click(object sender, EventArgs e)
        {
            r_ParentForm.DisplayButton_Click(r_ParentForm.displayButton, EventArgs.Empty);
            r_ParentForm.StatusCategoryButton_Click(r_ParentForm.statusCategoryButton, EventArgs.Empty);
        }
        // End display oprion

        private void inflateVehiclesTiresButton_Click(object sender, EventArgs e)
        {
            r_ParentForm.InflateVehiclesTiresButton_Click(r_ParentForm.inflateVehiclesTiresButton, EventArgs.Empty);
        }

        private void fillVehicleEnergyButton_Click(object sender, EventArgs e)
        {
            r_ParentForm.FillVehicleEnergyButton_Click(r_ParentForm.fillVehicleEnergyButton, EventArgs.Empty);
        }
    }
}
