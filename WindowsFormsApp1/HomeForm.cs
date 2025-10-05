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
        public string AgentFname;
        public string AgentEmail;
        public HomeForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
         
            update1.BringToFront();
            addVehicle4.BringToFront();
            addClient3.BringToFront();
            makeClaim1.BringToFront();
            updatePersonalInfo1.BringToFront();
            searchPage2.BringToFront();
            homePage4.BringToFront();

            homePage4.Dock = DockStyle.Fill;
            searchPage2.Dock = DockStyle.Fill;
            addVehicle4.Dock = DockStyle.Fill;
            makeClaim1.Dock = DockStyle.Fill;
            addClient3.Dock = DockStyle.Fill;
            update1.Dock = DockStyle.Fill;
          

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.Text = "Home: Loggined in as " + AgentFname;
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            homePage4.BringToFront();
            this.Text = "Home: Loggined in as " + AgentFname;
            //homePage.BringToFront();
        }

        

        

        

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Search Page: Loggined in as " + AgentFname;
            searchPage2.BringToFront();
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
            this.Text = "Policy Page: Loggined in as " + AgentFname;
            addVehicle4.BringToFront();
        }

        private void makeClaimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Text = "Claim: Loggined in as " + AgentFname;
            makeClaim1.BringToFront();
        }

        private void addClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Text = "Add Client: Loggined in as " + AgentFname;
           addClient3.BringToFront();
        }


        private void homePage3_Load(object sender, EventArgs e)
        {

        }

        private void addClient2_Load(object sender, EventArgs e)
        {

        }

        private void addClient2_Load_1(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text =  "Update: Loggined in as " + AgentFname;
           update1.BringToFront();
        }


        private void addVehicle4_Load(object sender, EventArgs e)
        {

        }

       
    }
}
