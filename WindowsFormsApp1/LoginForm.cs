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
using WindowsFormsApp1.DataSet1TableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {

            InitializeComponent();
            this.AutoScroll = true;
            this.AutoScroll = true;
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

            if (checkUserExist()) { 
                HomeForm form5 = new HomeForm();
                form5.Show();
            }
          
          
        }

        private bool checkUserExist()
        {

            errorProvider1.Clear();
            if (string.IsNullOrEmpty(userName.Text))
            {
                errorProvider1.SetError(userName, "Email is required");
                return false;
            }
            else if (!(userName.Text.ToLower().EndsWith("@gmail.com")) || userName.Text.Split('@')[0].Length < 4)
            {
                errorProvider1.SetError(userName, "Enter valid email address (e.g example@gmail.com).");
                return false;
            }
            else
            {
                ClientTableAdapter adapter = new ClientTableAdapter();
                int checkDuplicateEmail = (int)adapter.GetNoOfClientsWithEmail(userName.Text);
                errorProvider1.SetError(userName, checkDuplicateEmail > 0 ? "" : "Email does not exist");
                if (errorProvider1.GetError(userName) == "")
                {
                    int checkIfUserExist = (int)adapter.CheckIFUserExist(userName.Text, password.Text);
                    if (checkIfUserExist > 0)
                    {
                        return true;
                    }
                    else
                    {
                        errorProvider1.SetError(password, "incorrect password");
                        return false;
                    }
                }
                return false;
            }
               
        } 
    }
}
