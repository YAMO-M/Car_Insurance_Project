using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet2TableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class CreateAccountFormFinal : UserControl
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        public CreateAccountFormFinal()
        {
            InitializeComponent();
            emailTextbox.Validating += userName_Validating;
            passwordTextBox.Validating += password_Validating;
            confirmPaswordTextBox.Validating += confirmPassword;
            Submit.Enabled = false;


        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = (SignUpForm)ParentForm;
            SignUpPersonalDetails signUpPersonalDetails = signUpForm.GetSignUpPersonalDetails();
            string clientName = signUpPersonalDetails.NameTextBox.Text;
            string clientSurname = signUpPersonalDetails.SurnameTextBox2.Text;
            string clientIdentityNo = signUpPersonalDetails.IDNumbermaskedTextBox.Text;
            string clientAddress = signUpPersonalDetails.StreetAddressTextBox.Text + ", " + signUpPersonalDetails.StreetAddress2TextBox.Text + ", " + signUpPersonalDetails.CityTextBox.Text + ", " + signUpPersonalDetails.ProvinceComboBox.Text + ", " + signUpPersonalDetails.PostalCodemaskedTextBox.Text;
            string clientEmail = emailTextbox.Text;
            string clientPassword = passwordTextBox.Text;
            string clientPhoneNo = signUpPersonalDetails.PhoneNumberTextBox.Text;
            this.ParentForm?.Close();
            

            ClientTableAdapter adapter = new ClientTableAdapter();
            adapter.InsertClient(clientName,clientSurname,clientAddress,clientEmail,clientIdentityNo,clientPhoneNo,clientPassword);
            if (string.IsNullOrWhiteSpace(confirmPaswordTextBox.Text) && string.IsNullOrWhiteSpace(passwordTextBox.Text) && string.IsNullOrWhiteSpace(emailTextbox.Text))
            {
                return;
            }
        }
        private void userName_TextChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;
        }

        private void userName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string email = emailTextbox.Text.Trim();

            bool isValid = !string.IsNullOrWhiteSpace(email)
                           && email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase)
                           && email.IndexOf("@gmail.com") > 0;


            if (isValid)
            {
                emailTextbox.BackColor = System.Drawing.Color.LightGreen; // valid input
            }
            else
            {
                MessageBox.Show(
                       "Please enter a valid Gmail address (e.g., example@gmail.com).",
                       "Invalid Email",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                   );

                // Prevent leaving the textbox
               // e.Cancel = true;
            }
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            Submit.Enabled = true;//switches on the log in button
        }
        private void password_Validating(object sender, CancelEventArgs e)
        {

            string pass = passwordTextBox.Text;

            bool isValid = !string.IsNullOrWhiteSpace(pass) &&
                           pass.Length >= 8 &&
                           pass.Any(char.IsUpper) &&
                           pass.Any(char.IsLower) &&
                           pass.Any(char.IsDigit);

            if (!isValid)
            {
                MessageBox.Show(
                    "Password must be at least 8 characters long and include:\n" +
                    "- At least one uppercase letter\n" +
                    "- At least one lowercase letter\n" +
                    "- At least one number",
                    "Invalid Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                passwordTextBox.BackColor = System.Drawing.Color.LightGreen; // valid input

            }
        }
        private void confirmPassword(object sender, CancelEventArgs e)
        {
            if (passwordTextBox.Text == confirmPaswordTextBox.Text &&  !string.IsNullOrWhiteSpace(confirmPaswordTextBox.Text))
            {
                confirmPaswordTextBox.BackColor = System.Drawing.Color.LightGreen;
                
            }
            else
            {
                MessageBox.Show("Password does not match", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void confirmPaswordTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
