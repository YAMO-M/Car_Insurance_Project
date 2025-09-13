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
    public partial class SignUpPersonalDetails : UserControl
    {
        ErrorProvider errorProvider2 = new ErrorProvider();
        public SignUpPersonalDetails()
        {
            InitializeComponent();   
            foreach(Control ct in this.Controls)
            {
                if (ct is TextBox t)
                    t.Validating += Validate;
                else if(ct is MaskedTextBox m)
                    m.Validating += Validate;
                else if(ct is ComboBox c)
                    c.Validating += Validate;
            }
        }

       

        private void SignUpPersonalDetails_Load(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            if (input.All(c => char.IsLetter(c)))
            {
                errorProvider2.SetError(textBox, "");
            }
            else
            {
                errorProvider2.SetError(textBox, "Invalid Name");
            }
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(NameTextBox.Text) && NameTextBox.Text.All(c => char.IsLetter(c)) && 
                !string.IsNullOrWhiteSpace(SurnameTextBox2.Text) && SurnameTextBox2.Text.All(c => char.IsLetter(c)) && 
                !string.IsNullOrWhiteSpace(IDNumbermaskedTextBox.Text) &&
                !string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) &&
                !string.IsNullOrWhiteSpace(StreetAddressTextBox.Text) && !string.IsNullOrWhiteSpace(StreetAddress2TextBox.Text) && 
                !string.IsNullOrWhiteSpace(CityTextBox.Text) && CityTextBox.Text.All(c => char.IsLetter(c)) && !string.IsNullOrWhiteSpace(ProvinceComboBox.Text) && 
                !string.IsNullOrWhiteSpace(PostalCodemaskedTextBox.Text);
        }
        public void Validate(object sender, CancelEventArgs e)
        {
            if(sender is TextBox t)
            {
                if (string.IsNullOrWhiteSpace(t.Text))
                {
                    errorProvider2.SetError(t, "Please fill in requirement");
                    //e.Cancel = true;
                }
                else
                {
                    errorProvider2.SetError(t, "");
                    //e.Cancel = false;
                    if(t.Name == "NameTextBox" || t.Name == "SurnameTextBox2" || t.Name == "CityTextBox")
                    {
                        if(t.Text.All(c => char.IsLetter(c)))
                        {
                            errorProvider2.SetError(t, ""); 
                        }
                        else
                        {
                             errorProvider2.SetError(t, "Invalid Name");
                        }
                    }

                }
            }
            else if(sender is MaskedTextBox m)
            {
                if (!m.MaskCompleted || string.IsNullOrWhiteSpace(m.Text))
                {
                    errorProvider2.SetError(m, "Please fill in requirement");
                    //e.Cancel = true;
                }
                else
                {
                    errorProvider2.SetError(m, "");
                    //e.Cancel = false;
                }
            }
            else if(sender is ComboBox c)
            {
                if(c.SelectedIndex < 0)
                {
                    errorProvider2.SetError(c, "Please select a value");
                    //e.Cancel = true;
                }
                else
                {
                    errorProvider2.SetError(c, "");
                   // e.Cancel = false;
                }
            }
        }

        private void SurnameTextBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            if (input.All(c => char.IsLetter(c)))
            {
                errorProvider2.SetError(textBox, "");
            }
            else
            {
                errorProvider2.SetError(textBox, "Invalid Name");
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            if (input.All(c => char.IsLetter(c)))
            {
                errorProvider2.SetError(textBox, "");
            }
            else
            {
                errorProvider2.SetError(textBox, "Invalid Name");
            }
        }
    }
}
