using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {

            InitializeComponent();
            this.AutoScroll = true;
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
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

            HomeForm form5 = new HomeForm();
            form5.Show();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            try {
                string username = userName.Text;

                // Implicit validation rules
                bool isValid = !string.IsNullOrWhiteSpace(username)      // Not empty
                               && username.Contains("@")    // Alphanumeric only
                               && username.Contains("gmail.com");                 // Min length
                               

                // Implicit feedback
                if (isValid)
                {
                    //e.Cancel = true;
                    userName.ForeColor = Color.Black;  // valid
                    loginButton.Enabled = true;            // allow submit
                }
                else
                {
                    userName.ForeColor = Color.Red;    // invalid
                    loginButton.Enabled = false;           // prevent submit
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:" + ex.Message);
            }
           
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
