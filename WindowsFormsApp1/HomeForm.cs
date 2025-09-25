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

        

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        
            
        

        
            
        


        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

       

       

      

        



        

        private void searchPage1_Load(object sender, EventArgs e)
        {

        }

        

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homePage2.BringToFront();
        }

        

        

        

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchPage1.BringToFront();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void addPolicyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addVehicle3.BringToFront();
        }

        private void makeClaimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            makeClaim2.BringToFront();
        }

        private void addClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            updatePersonalInfo1.BringToFront();
        }
    }
}
