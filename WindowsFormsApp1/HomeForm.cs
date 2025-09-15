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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            addVehicle1.BringToFront();
            makeClaim2.BringToFront();
            paymentDetails1.BringToFront();
            updatePersonalInfo1.BringToFront();
           // policyPage1.BringToFront();
            homePage1.BringToFront();
            this.AutoScroll = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addVehicle1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            makeClaim2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paymentDetails1.BringToFront();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdatePersonalDetButton_Click(object sender, EventArgs e)
        {
            updatePersonalInfo1.BringToFront();
        }

       

      

        private void AddPolicyButton_Click(object sender, EventArgs e)
        {
            addVehicle3.BringToFront();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string message = "Are you sure you want to Logout?";
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(message, title, buttons, icon);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
