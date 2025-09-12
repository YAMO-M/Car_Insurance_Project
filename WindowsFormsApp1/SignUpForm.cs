using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class SignUpForm : Form
    {
      public SignUpPersonalDetails GetSignUpPersonalDetails()
        {
            return signUpPersonalDetails1;
        }
       
        public SignUpForm()
        {
            InitializeComponent();
           
            signUpPersonalDetails1.BringToFront();
        }
       

      
         

        private void button2_Click(object sender, EventArgs e)
        {
            signUpPersonalDetails1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            createAccountFormFinal1.BringToFront();
        }

        private void createAccountFormFinal1_Load(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
