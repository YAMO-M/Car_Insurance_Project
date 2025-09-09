using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;

            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                errorProvider1.SetError(nameTextbox, "Name is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(nameTextbox, "");
            }
            

            
           
            if (string.IsNullOrWhiteSpace(surnameTextbox.Text))
            {
                errorProvider1.SetError(surnameTextbox, "Surname is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(surnameTextbox, "");
            }

            

            
            if (string.IsNullOrWhiteSpace(dayComboBox.Text))
            {
                errorProvider1.SetError(dayComboBox, "Day is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(dayComboBox, "");
            }

            if (string.IsNullOrWhiteSpace(monthComboBox.Text))
            {
                errorProvider1.SetError(monthComboBox, "Month is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(monthComboBox, "");
            }

            if (string.IsNullOrWhiteSpace(yearComboBox.Text))
            {
                errorProvider1.SetError(yearComboBox, "Year is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(yearComboBox, "");
            }

            if (string.IsNullOrWhiteSpace(idNumberTextbox.Text))
            {
                errorProvider1.SetError(idNumberTextbox, "ID.No is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(idNumberTextbox, "");
            }

            if (string.IsNullOrWhiteSpace(licenseNumberTextbox.Text))
            {
                errorProvider1.SetError(licenseNumberTextbox, "License No. is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(licenseNumberTextbox, "");
            }

            if (string.IsNullOrWhiteSpace(phoneNumberbox.Text))
            {
                errorProvider1.SetError(phoneNumberbox, "Phone No. is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(phoneNumberbox, "");
            }

            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                errorProvider1.SetError(emailTextBox, "E-mail is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(emailTextBox, "");
            }

            if (!maleRadioButton.Checked && !femaleRadioButton.Checked)
            {
                errorProvider1.SetError(femaleRadioButton, "Gender is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(femaleRadioButton, "");
            }

            if (string.IsNullOrWhiteSpace(StreetAddress1Box.Text))
            {
                errorProvider1.SetError(StreetAddress1Box, "Street Address is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(StreetAddress1Box, "");
            }

            if (string.IsNullOrWhiteSpace(CityTextBox.Text))
            {
                errorProvider1.SetError(CityTextBox, "City is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(CityTextBox, "");
            }

            if (string.IsNullOrWhiteSpace(provinceTextBox.Text))
            {
                errorProvider1.SetError(provinceTextBox, "Province is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(provinceTextBox, "");
            }

            if (string.IsNullOrWhiteSpace(PostalCodeTextBox.Text))
            {
                errorProvider1.SetError(PostalCodeTextBox, "Postal code is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(PostalCodeTextBox, "");
            }

            if(!valid)
            {
                return;
            }
            else
            {
                CreatePasswordForm form3 = new CreatePasswordForm();
                form3.Show();
            }








               
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
