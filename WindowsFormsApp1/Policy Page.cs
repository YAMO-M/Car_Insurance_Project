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
    public partial class AddVehicle : UserControl
    {
        public AddVehicle()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void CVVtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CVVlabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MonthLabel_Click(object sender, EventArgs e)
        {

        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExpirationDateLable_Click(object sender, EventArgs e)
        {

        }

        private void PaymentDetailsLabel_Click(object sender, EventArgs e)
        {

        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Policy3_CheckedChanged(object sender, EventArgs e)
        {
            if (Policy3.Checked)
            {
                AmountTextBox.Text = "R3000.00";

            }
        }

        private void Policy2_CheckedChanged(object sender, EventArgs e)
        {
            if (Policy2.Checked)
            {
                AmountTextBox.Text = "R2000.00";

            }
        }

        private void Policy1_CheckedChanged(object sender, EventArgs e)
        {
           
                AmountTextBox.Text = "R1000.00";

           
        }

        
    }
}
