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
        public HomeForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            addVehicle3.BringToFront();
            addClient1.BringToFront();
            makeClaim4.BringToFront();
            updatePersonalInfo1.BringToFront();
            homePage2.BringToFront();

            homePage2.Dock = DockStyle.Fill;
            searchPage1.Dock = DockStyle.Fill;
            addVehicle3.Dock = DockStyle.Fill;
            makeClaim2.Dock = DockStyle.Fill;
            updatePersonalInfo1.Dock = DockStyle.Fill;


        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.Text = "Home: Loggined in as " + AgentFname;
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Home: Loggined in as " + AgentFname;
            homePage2.BringToFront();
        }

        

        

        

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Search Page: Loggined in as " + AgentFname;
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
            this.Text = "Policy Page: Loggined in as " + AgentFname;
            addVehicle3.BringToFront();
        }

        private void makeClaimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Text = "Claim: Loggined in as " + AgentFname;
            makeClaim3.BringToFront();
        }

        private void addClientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Text = "Add Client: Loggined in as " + AgentFname;
            addClient2.BringToFront();
        }


        private void homePage3_Load(object sender, EventArgs e)
        {

        }
    }
}
