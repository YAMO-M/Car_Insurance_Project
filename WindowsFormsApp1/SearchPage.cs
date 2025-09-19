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
    public partial class SearchPage : UserControl
    {
        public SearchPage()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void SearchPage_Load(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //display clients
            /*
            Name:
            Surname:
            ID number:
            Policy type:
            Status:
             */
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Minenhle
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //kwesta
                //Change the status
            }
        }
    }
}
