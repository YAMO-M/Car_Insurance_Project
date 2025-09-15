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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class CreateAccountFormFinal : UserControl
    {
    
        public CreateAccountFormFinal()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = (SignUpForm)ParentForm;
            SignUpPersonalDetails signUpPersonalDetails = signUpForm.GetSignUpPersonalDetails();
            string clientName = signUpPersonalDetails.NameTextBox.Text;
            string clientSurname = signUpPersonalDetails.SurnameTextBox2.Text;
            string clientIdentityNo = signUpPersonalDetails.IDNumbermaskedTextBox.Text;
            string clientAddress = signUpPersonalDetails.StreetAddressTextBox.Text + ", " + signUpPersonalDetails.CityTextBox.Text + ", " + signUpPersonalDetails.ProvinceComboBox.Text + ", " + signUpPersonalDetails.PostalCodemaskedTextBox.Text;
            string clientEmail = emailTextbox.Text;
            string clientPassword = passwordTextBox.Text;
            string clientPhoneNo = signUpPersonalDetails.PhoneNumberTextBox.Text;
           
            

            if(checkInvalidInput())
            {
                ClientTableAdapter adapter = new ClientTableAdapter();
                adapter.InsertClient(clientName, clientSurname, clientAddress, clientEmail, clientIdentityNo, clientPhoneNo, clientPassword);
                MessageBox.Show("Account Created Succefully.", "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ParentForm?.Close();
            }
    
        }

        private bool checkInvalidInput()
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(emailTextbox.Text))
            {
                errorProvider1.SetError(emailTextbox, "Email is required");
                return false;
            }
            else if (!(emailTextbox.Text.ToLower().EndsWith("@gmail.com")) || emailTextbox.Text.Split('@')[0].Length < 4)
            {
                errorProvider1.SetError(emailTextbox, "Enter valid email address (e.g example@gmail.com).");
                return false;
            }
            else if(!(EmailErrorLabel.Text == ""))
            {
                return false;
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                errorProvider1.SetError(passwordTextBox, "Password is required");
                return false;
            }
            else if (!string.IsNullOrEmpty(passwordTextBox.Text)) return (numberLabel.ForeColor == ErrorLength.ForeColor) && (UpperCaseLabel.ForeColor == lowercaseLabel.ForeColor) && (ErrorLength.ForeColor == UpperCaseLabel.ForeColor) && (ErrorLength.ForeColor == Color.Green);

            return true;

        }

       

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            ErrorLength.ForeColor = passwordTextBox.Text.Length < 8 ? Color.Red : Color.Green;

            UpperCaseLabel.ForeColor = !passwordTextBox.Text.Any(char.IsUpper) ? Color.Red : Color.Green;

            lowercaseLabel.ForeColor = !passwordTextBox.Text.Any(char.IsLower) ? Color.Red : Color.Green;

            numberLabel.ForeColor = !passwordTextBox.Text.Any(char.IsDigit) ? Color.Red : Color.Green;
        }

        private void emailTextbox_TextChanged(object sender, EventArgs e)
        {
            ClientTableAdapter adapter = new ClientTableAdapter();
            int checkDuplicateEmail = (int)adapter.GetNoOfClientsWithEmail(emailTextbox.Text);
            EmailErrorLabel.ForeColor = Color.Red;
            EmailErrorLabel.Text = checkDuplicateEmail > 0 ? "Email already used" : "";
            
        }

        internal bool IsValid2()
        {
            throw new NotImplementedException();
        }
    }
}
