using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
            this.AutoScroll = true;
            userName.Validating += userName_Validating;
            password.Validating += password_Validating;
            loginButton.Enabled = false;
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            bool valid = true;

            errorProvider1.Clear();
            if(string.IsNullOrWhiteSpace(userName.Text))
            {
                errorProvider1.SetError(userName, "UserName is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(userName, "");
            }
            if (string.IsNullOrWhiteSpace(password.Text))
            {
                errorProvider1.SetError(password, "Password is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(password, "");
            }

            if(!valid)
            {
                return;
            }
            else
            {
                HomeForm form5 = new HomeForm();
                form5.Show();
            }
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPasswordForm form = new ResetPasswordForm();
            form.Show();
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SignUpForm form2 = new SignUpForm();
            form2.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            try {
                HomeForm form5 = new HomeForm();
                form5.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex + "Hell nah, you don't exist!!");
            }
          
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = false;
        }
        
        private void userName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
                string email = userName.Text.Trim();

                bool isValid = !string.IsNullOrWhiteSpace(email)
                               && email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase)
                               && email.IndexOf("@gmail.com") > 0;

               
            if (isValid)
            {
                userName.BackColor = System.Drawing.Color.LightGreen; // valid input
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
                e.Cancel = true;
            }
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            loginButton.Enabled = true;//switches on the log in buttonn
        }
        private void password_Validating(object sender, CancelEventArgs e)
        {
            
            string pass = password.Text;

            bool isValid = (!string.IsNullOrEmpty(pass))&
            pass.Length >= 8 &
            pass.Any(char.IsUpper) &
            pass.Any(char.IsLower) &
            pass.Any(char.IsDigit);

            if (!isValid)
            {
                //essageBox.Show(
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
                password.BackColor = System.Drawing.Color.LightGreen; // valid input

            }
        }
    }
}
