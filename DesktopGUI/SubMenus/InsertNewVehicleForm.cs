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
using static Ex03.GarageLogic.VehicleFactory;

namespace DesktopGUI.SubMenus
{
    public partial class insertNewVehicleForm : Form
    {
        private Vehicle m_CurrentVehicle;
        private eVehicleType m_VehicleType;
        private List<string> m_ParametersList;
        private string[] m_ArrOfAllEnumVehicleType;
        private readonly bool[] r_MustInputForNewVehicle = new bool[2];
        private readonly Dictionary<Label, object> r_ListOfParameters = new Dictionary<Label, object>();
        private readonly MainMenuForm r_ParentForm;

        public insertNewVehicleForm(MainMenuForm i_ParentForm)
        {
            InitializeComponent();
            r_ParentForm = i_ParentForm;
            initMenu();
        }

        private void initMenu()
        {
            string allEnumVehicleType = EnumOperations.ListEnumValues<eVehicleType>(true);

            m_ArrOfAllEnumVehicleType = allEnumVehicleType.Split('\n');
            foreach (string newItem in m_ArrOfAllEnumVehicleType)
            {

                vehicleTypeComboBox.Items.Add(newItem.Replace("\r", string.Empty));
            }
        }

        private void licenseNumberTextBox_Validated(object sender, EventArgs e)
        {
            m_CurrentVehicle = ManagerLogicGUI.ValidVehicleAndChangeIcon(licenseNumberTextBox.Text, vehicleValidIconButton, IconChar.Edit, IconChar.PlusCircle);
            displayThisVehicleButton.Visible = false;
            r_MustInputForNewVehicle[0] = false;
            vehicleTypeComboBox.Enabled = true;
            if (licenseNumberTextBox.Text != string.Empty)
            {
                r_MustInputForNewVehicle[0] = true;
                if (m_CurrentVehicle != null)
                {
                    findComboBoxValueWithNumbers(vehicleTypeComboBox, m_CurrentVehicle.VehicleType.ToString());
                    r_MustInputForNewVehicle[0] = true;
                    getAllCurrentVehicle();
                    vehicleTypeComboBox.Enabled = false;
                }
            }

            enabledCreateOrUpdateVehicleButton();
        }

        private void findComboBoxValueWithNumbers(ComboBox i_ComboBox, string i_ParameterValue)
        {
            if (m_CurrentVehicle != null)
            {
                for (int i = 1; i <= i_ComboBox.Items.Count; i++)
                {
                    i_ComboBox.SelectedItem = string.Format("{0}. {1}", i, i_ParameterValue);
                }
            }
        }

        private void getAllCurrentVehicle()
        {
            foreach(KeyValuePair<Label, object> keyValuePair in r_ListOfParameters)
            {
                string parameterKey = keyValuePair.Key.Name;
                TextBox textBox = keyValuePair.Value as TextBox;
                ComboBox comboBox = keyValuePair.Value as ComboBox;
                string parameterValue = ManagerLogicGUI.VehicleFactory.GetFieldValue(m_CurrentVehicle, parameterKey);

                if(textBox != null)
                {
                    textBox.Text = parameterValue;
                }
                else if(comboBox != null)
                {
                    findComboBoxValueWithNumbers(comboBox, parameterValue);
                }
            }
        }

        private void enabledCreateOrUpdateVehicleButton()
        {
            int counter = 0;

            foreach(bool buttonIsValid in r_MustInputForNewVehicle)
            {
                if(!buttonIsValid) break;
                counter++;
            }

            if(counter == r_MustInputForNewVehicle.Length)
            {
                createOrUpdateVehicleButton.Enabled = true;
            }
        }

        private void vehicleTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Label, object> keyValuePair in r_ListOfParameters.ToList())
            {
                TextBox textBox = keyValuePair.Value as TextBox;
                ComboBox comboBox = keyValuePair.Value as ComboBox;

                this.Controls.Remove(keyValuePair.Key);
                if(textBox != null) this.Controls.Remove(textBox);
                if(comboBox != null) this.Controls.Remove(comboBox);
                r_ListOfParameters.Remove(keyValuePair.Key);
            }

            m_VehicleType = Validation.ValidateAndParseEnum<eVehicleType>(getTypes(vehicleTypeComboBox.SelectedItem.ToString()));
            m_ParametersList = ManagerLogicGUI.VehicleFactory.GetExtendedParametersList(m_VehicleType);
            r_MustInputForNewVehicle[1] = true;
            bases();
            enabledCreateOrUpdateVehicleButton();
        }

        private void bases()
        {
            int nextYLocationOfLabel = 175 + 80;
            int nextYLocationOfTextBox = 175 + 80;

            foreach (string parameterKey in m_ParametersList)
            {
                Label label = new Label();

                label.Anchor = System.Windows.Forms.AnchorStyles.None;
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                label.ForeColor = System.Drawing.SystemColors.ButtonFace;
                label.Location = new System.Drawing.Point(50, nextYLocationOfLabel);
                nextYLocationOfLabel += 28;
                label.Name = parameterKey;
                label.Text =  parameterKey;
                this.Controls.Add(label);

                if (ManagerLogicGUI.VehicleFactory.ParameterInputIsEnum(parameterKey, out string enumString))
                {
                    createComboBoxForSubParameter(label, enumString, parameterKey, nextYLocationOfTextBox);
                }
                else
                {
                    createTextBoxForSubParameter(label, parameterKey, nextYLocationOfTextBox);
                }

                nextYLocationOfTextBox += 28;
            }
        }

        private void createTextBoxForSubParameter(Label i_Label, string i_ParameterKey, int i_NextYLocationOfTextBox)
        {
            TextBox textBox = new TextBox();

            textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBox.Location = new System.Drawing.Point(422, i_NextYLocationOfTextBox);
            textBox.Name = i_ParameterKey;
            textBox.Size = new System.Drawing.Size(225, 28);
            if (ManagerLogicGUI.VehicleFactory.ParameterInputIsFloat(i_ParameterKey))
            {
                textBox.Validated += floatValid_TextBoxValidated;
                textBox.Text = "0";
            }

            this.Controls.Add(textBox);
            r_ListOfParameters.Add(i_Label, textBox);
        }

        private void createComboBoxForSubParameter(Label i_Label, string i_EnumStringValue, string i_ParameterKey, int i_NextYLocationOfTextBox)
        {
            const int v_OffsetForOverflow = 5;
            ComboBox comboBox = new ComboBox();
            string[] enumItemsList = i_EnumStringValue.Split('\n');
            int endLocationOfLabel = i_Label.Size.Width + i_Label.Location.X;

            comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            if (endLocationOfLabel >= 422) // 422 is the start X position of the comboBox 
            {
                comboBox.Location = new System.Drawing.Point(endLocationOfLabel + v_OffsetForOverflow, i_NextYLocationOfTextBox);
                comboBox.Size = new System.Drawing.Size(170, 28);
            }
            else
            {
                comboBox.Location = new System.Drawing.Point(422, i_NextYLocationOfTextBox);
                comboBox.Size = new System.Drawing.Size(225, 28);
            }

            comboBox.Name = i_ParameterKey;
            comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            bool isFirstItem = true;
            foreach (string newItem in enumItemsList)
            {
                string replace = newItem.Replace("\r", string.Empty);
                comboBox.Items.Add(replace);
                if (isFirstItem)
                {
                    comboBox.SelectedItem = replace;
                    isFirstItem = false;
                }
            }

            this.Controls.Add(comboBox);
            r_ListOfParameters.Add(i_Label, comboBox);
        }

        private void floatValid_TextBoxValidated(object i_Sender, EventArgs i_E)
        {
            TextBox textBox = i_Sender as TextBox;

            if(textBox != null)
            {
                if(!float.TryParse(textBox.Text, out float newValue))
                {
                    textBox.Text = "0";
                }
            }
        }

        private string getTypes(string i_SelectedItem)
        {
            int foundStartOfTheItem = i_SelectedItem.IndexOf(". ");
            string enumTypeName = foundStartOfTheItem == -1 ? i_SelectedItem : i_SelectedItem.Substring(foundStartOfTheItem + 2);

            return enumTypeName.Replace("\r", string.Empty);
        }

        private void createOrUpdateVehicleButton_Click(object sender, EventArgs e)
        {
            if(m_CurrentVehicle == null)
            {
                m_CurrentVehicle = ManagerLogicGUI.VehicleFactory.CreateVehicle(licenseNumberTextBox.Text, vehiclesModelTextBox.Text, m_VehicleType);
                ManagerLogicGUI.GarageManager.AddVehicle(m_CurrentVehicle);
            }

            setAllParameters();
            vehicleTypeComboBox.Enabled = false;
            displayThisVehicleButton.Visible = true;
        }

        private void setAllParameters()
        {
            foreach (KeyValuePair<Label, object> keyValuePair in r_ListOfParameters)
            {
                string parameterKey = keyValuePair.Key.Name;
                string parameterValue = string.Empty;
                TextBox textBox = keyValuePair.Value as TextBox;
                ComboBox comboBox = keyValuePair.Value as ComboBox;

                if (textBox != null)
                {
                    parameterValue = textBox.Text;
                }
                else if (comboBox != null)
                {
                    parameterValue = getTypes(comboBox.SelectedItem.ToString());
                }

                try
                {
                    ManagerLogicGUI.VehicleFactory.SetFieldValue(m_CurrentVehicle, parameterKey, parameterValue);
                }
                catch (Exception e)
                {
                    problemButton.Text = e.Message;
                    problemButton.Visible = true;
                }
            }
        }

        private void displayThisVehicleButton_Click(object sender, EventArgs e)
        {
            r_ParentForm.DisplaySpecificVehicle(r_ParentForm.specificVehicleButton, m_CurrentVehicle.LicenseNumber);
        }
    }
}