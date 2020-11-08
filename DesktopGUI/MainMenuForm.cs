using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DesktopGUI.SubMenus;
using Ex03.GarageLogic;
using FontAwesome.Sharp;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace DesktopGUI
{
    public sealed partial class MainMenuForm : Form
    {
        private Form m_ActionForm;
        private readonly Panel r_LeftBorderPanelForButton;
        private IconButton m_CurrentButton;
        private Color m_LastColorOfCurrentButton;
        private readonly Panel r_LeftBorderPanelForSubButton;
        private bool m_IsFirstOpenForm = true;

        public MainMenuForm()
        {
            InitializeComponent();
           // this.Text = string.Empty;
           // this.ControlBox = false; 
            // this.DoubleBuffered = true;
            // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            // this.SetStyle(ControlStyles.ResizeRedraw, true);
            // this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            r_LeftBorderPanelForButton = new Panel();
            r_LeftBorderPanelForSubButton = new Panel();
            r_LeftBorderPanelForButton.Size = new Size(7,60);
            r_LeftBorderPanelForSubButton.Size = new Size(7,60); 
            panelSideMenu.Controls.Add(r_LeftBorderPanelForButton);
            displaySubPanel.Controls.Add(r_LeftBorderPanelForSubButton);
            initFirstMenu();
        }

        private void activateButton(object i_Sender, Color i_Color)
        {
            IconButton newCurrentIconButton = i_Sender as IconButton;

            if (newCurrentIconButton != null && newCurrentIconButton != m_CurrentButton)
            {
                disableButton();
                m_CurrentButton = newCurrentIconButton;
                // Button change
                m_LastColorOfCurrentButton = m_CurrentButton.BackColor;
                m_CurrentButton.BackColor = Color.DarkSlateGray;
                m_CurrentButton.ForeColor = i_Color;
                m_CurrentButton.IconColor = i_Color;
                m_CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
                m_CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                m_CurrentButton.ImageAlign = ContentAlignment.MiddleRight;
                // Left border
                if(displaySubPanel.Visible)
                {
                    r_LeftBorderPanelForSubButton.BackColor = i_Color;
                    r_LeftBorderPanelForSubButton.Location = new Point(0, m_CurrentButton.Location.Y);
                    r_LeftBorderPanelForSubButton.Visible = true;
                    r_LeftBorderPanelForSubButton.BringToFront();
                }
                else
                {
                    r_LeftBorderPanelForButton.BackColor = i_Color;
                    r_LeftBorderPanelForButton.Location = new Point(0, m_CurrentButton.Location.Y);
                    r_LeftBorderPanelForButton.Visible = true;
                    r_LeftBorderPanelForButton.BringToFront();
                }
            }
        }

        private void disableButton()
        {
            if(m_CurrentButton != null)
            {
                m_CurrentButton.BackColor = m_LastColorOfCurrentButton;
                m_CurrentButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
                m_CurrentButton.IconColor = System.Drawing.SystemColors.ButtonFace;
                m_CurrentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                m_CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                m_CurrentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }



        /*
        // Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMassage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMassage(this.Handle, 0x112, 0xf012, 0);
        }
        */

        private void initFirstMenu()
        { 
            displaySubPanel.Visible = false;
            activateButton(homeButton, Color.Aquamarine);
            HomeButton_Click(null, EventArgs.Empty);
        }

        private void openChildForm(Form i_ChildForm)
        {
            if(m_IsFirstOpenForm || i_ChildForm.Name != m_ActionForm.Name)
            {
                m_ActionForm?.Close();
                m_ActionForm = i_ChildForm;
                i_ChildForm.TopLevel = false;
                i_ChildForm.FormBorderStyle = FormBorderStyle.None;
                i_ChildForm.Dock = DockStyle.Fill;
                mainFillPanel.Controls.Add(i_ChildForm);
                mainFillPanel.Tag = i_ChildForm;
                i_ChildForm.BringToFront();
                i_ChildForm.Show();
                m_IsFirstOpenForm = false;
            }
        }

        private void hideSubMenu()
        {
            if (displaySubPanel.Visible)
            {
                displaySubPanel.Visible = false;
            }
        }

        private void showSubMenu(Panel i_SubMenu)
        {
            if(!i_SubMenu.Visible)
            {
                hideSubMenu();
                i_SubMenu.Visible = true;
            }
            else
            {
                i_SubMenu.Visible = false;
            }

            r_LeftBorderPanelForSubButton.Visible = false;
        }

        private void activeButtonAndHideSubMenu(object i_Sender, Color i_Color)
        {
            hideSubMenu();
            activateButton(i_Sender, i_Color);
        }

        public void HomeButton_Click(object sender, EventArgs e)
        {
            activeButtonAndHideSubMenu(sender, Color.Aquamarine);
            openChildForm(new HomeForm(this));
        }

        public void InsertNewVehicleButton_Click(object sender, EventArgs e)
        {
            activeButtonAndHideSubMenu(sender, Color.Chartreuse);
            openChildForm(new insertNewVehicleForm(this));
        }

        public void DisplayButton_Click(object sender, EventArgs e)
        {
            activeButtonAndHideSubMenu(sender, Color.LawnGreen);
            showSubMenu(displaySubPanel);
        }

        public void DisplaySpecificVehicle(object i_Sender, string i_LicenseNumber)
        {
            DisplayButton_Click(displayButton, EventArgs.Empty);
            activateButton(i_Sender, Color.Green);
            openChildForm(new DisplaySpecificVehicleForm(i_LicenseNumber));
        }

        // Start sub menu of Display button
        public void SpecificVehicleButton_Click(object sender, EventArgs e)
        {
            DisplaySpecificVehicle(sender, string.Empty);
        }

        public void StatusCategoryButton_Click(object sender, EventArgs e)
        {
            activateButton(sender, Color.Green);
            openChildForm(new DisplayByStatusCategoryForm());
        }
        // End sub menu of Display button

        public void ChangeStatusButton_Click(object sender, EventArgs e)
        {
            activeButtonAndHideSubMenu(sender, Color.Brown);
            openChildForm(new ChangeStatusForm());
        }

        public void InflateVehiclesTiresButton_Click(object sender, EventArgs e)
        {
            activeButtonAndHideSubMenu(sender, Color.RosyBrown);
            openChildForm(new InflateVehiclesTiresForm());
        }

        public void FillVehicleEnergyButton_Click(object sender, EventArgs e)
        {
            activeButtonAndHideSubMenu(sender, Color.ForestGreen);
            openChildForm(new FillVehicleEnergyForm());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeButton_Click(homeButton, EventArgs.Empty);
        }
    }
}