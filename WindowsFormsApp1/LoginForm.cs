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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }
    }
}
