using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet1TableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class SignUpPersonalDetails : UserControl
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        public SignUpPersonalDetails()
        {
            InitializeComponent();
            IDNumbermaskedTextBox.Mask = "0000000000000";
            IDNumbermaskedTextBox.PromptChar = ' ';
            PhoneNumberTextBox.Mask = "000-000-0000";
            PhoneNumberTextBox.PromptChar = ' ';
            PostalCodemaskedTextBox.Mask = "0000-0";
            PostalCodemaskedTextBox.PromptChar= ' ';
            
        }

        private void IDNumbermaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            ClientTableAdapter adapter = new ClientTableAdapter();
            int checkDuplicateID = (int)adapter.GetNoOfClientsWithIDNumber(IDNumbermaskedTextBox.Text);
            IDErrorLabel.ForeColor = Color.Red;
            IDErrorLabel.Text = checkDuplicateID > 0 ? " ID Already in use" : "";
        }

       
        public bool checkSignUpInput()

        {
           
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NameTextBox.Text.Trim()))
            {
                errorProvider1.SetError(NameTextBox, "Name is required");
                return false;
            }
            else if (NameTextBox.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(NameTextBox, "Name must be atleast 3 letters");
                return false;
            }
            else if (NameTextBox.Text.Trim().Any(Char.IsDigit) || NameTextBox.Text.Trim().Any(Char.IsPunctuation))
            {
                errorProvider1.SetError(NameTextBox, "Name contains no digits OR symbols");
                return false;
            }
            if (string.IsNullOrEmpty(SurnameTextBox2.Text.Trim()))
            {
                errorProvider1.SetError(SurnameTextBox2, "Surname is required");
                return false;
            }
            else if (SurnameTextBox2.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(SurnameTextBox2, "Surname must be atleast 3 letters");
                return false;
            }
            else if (SurnameTextBox2.Text.Trim().Any(Char.IsDigit) || NameTextBox.Text.Trim().Any(Char.IsPunctuation))
            {
                errorProvider1.SetError(NameTextBox, "Surname contains no digits or symbols");
                return false;
            }
            if (string.IsNullOrEmpty(IDNumbermaskedTextBox.Text.Trim()))
            {
                errorProvider1.SetError(SurnameTextBox2, "ID Number is required");
                return false;
            }
            else if(IDNumbermaskedTextBox.Text.Trim().Length < 12)
            {
                errorProvider1.SetError(IDNumbermaskedTextBox, "ID Number must be 13 numbers");
                return false;
            }
            else if(!(IDErrorLabel.Text == ""))
            {
                return false;
            }
            if (string.IsNullOrEmpty(PhoneNumberTextBox.Text.Trim()))
            {
                errorProvider1.SetError(PhoneNumberTextBox, "Phone Number is required");
                return false;
            }
            else if (PhoneNumberTextBox.Text.Trim().Length < 9)
            {
                errorProvider1.SetError(PhoneNumberTextBox, "Phone Number must be 10 numbers");
                return false;
            }
            else if(!PhoneNumberTextBox.Text.StartsWith("0") || 
                    !(PhoneNumberTextBox.Text.Trim()[1] == '6' ||
                      PhoneNumberTextBox.Text.Trim()[1] == '7' ||
                      PhoneNumberTextBox.Text.Trim()[1] == '8'))
            {
                errorProvider1.SetError(PhoneNumberTextBox, "Phone Number must start with 06,07,08");
                return false;
            }
            if (string.IsNullOrEmpty(StreetAddressTextBox.Text.Trim()))
            {
                errorProvider1.SetError(StreetAddressTextBox, "Street Address is required");
                return false;
            }
            else if (StreetAddressTextBox.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(StreetAddressTextBox, "Street Address must be atleast 3 letters");
                return false;
            }
            if (string.IsNullOrEmpty(CityTextBox.Text.Trim()))
            {
                errorProvider1.SetError(CityTextBox, "City is required");
                return false;
            }
            else if(CityTextBox.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(CityTextBox, "City Name must be atleast 3 letters");
                return false;
            }
            if (string.IsNullOrEmpty(ProvinceComboBox.Text.Trim()))
            {
                errorProvider1.SetError(ProvinceComboBox, "Province is required");
                return false;
            }
            if (string.IsNullOrEmpty(PostalCodemaskedTextBox.Text.Trim()))
            {
                errorProvider1.SetError(PostalCodemaskedTextBox, "Postal/Zip Code is required");
                return false;
            }
            else if (PostalCodemaskedTextBox.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(PostalCodemaskedTextBox, "Postal/Zip Code must be 4 or 5 numbers");
                return false;
            }
         
            return true;
        }

       
    }
}
