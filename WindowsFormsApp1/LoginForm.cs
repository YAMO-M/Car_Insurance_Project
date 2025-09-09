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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPasswordForm form = new ResetPasswordForm();
            form.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm form2 = new SignUpForm();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void welcomeBackLabel_Click(object sender, EventArgs e)
        {

        }

        private void enterDetailsLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
