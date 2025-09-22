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
            this.WindowState = FormWindowState.Maximized;
            addVehicle1.BringToFront();
            makeClaim2.BringToFront();
            updatePersonalInfo1.BringToFront();
            homePage2.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homePage2.BringToFront();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            searchPage1.BringToFront();
        }

        private void searchPage1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                this.Close();
            }
        }
    }
}
