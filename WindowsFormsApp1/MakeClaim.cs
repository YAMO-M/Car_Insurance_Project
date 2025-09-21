using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet1TableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class MakeClaim: UserControl
    {
        public MakeClaim()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }
        ErrorProvider errorProvider1 = new ErrorProvider();
        int policyID;
        private void searchButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            PolicyTableAdapter policyTableAdapter = new PolicyTableAdapter();

            if (string.IsNullOrEmpty(ClientIDTextbox.Text)){
                errorProvider1.SetError(ClientIDTextbox,"Enter Client ID");
                return;
            }
            if ((int)policyTableAdapter.Check_If_Client_Has_Policy(int.Parse(ClientIDTextbox.Text)) > 0)
            {
                policyError.Text = "";
                DataRow policy = policyTableAdapter.GetPolicyDetails(int.Parse(ClientIDTextbox.Text)).Rows[0];

                policyType.Text = policy["PolicyType"].ToString();
                PolicyStatus.Text = policy["Status"].ToString();
                policyID = (int)policy["PolicyID"];
                if (!PolicyStatus.Text.Equals("active"))
                {
                    ClaimButton.Enabled = false;
                    button1.Enabled = false;
                }
            }
            else { 
                 policyError.ForeColor = Color.Red;
                 policyError.Text = "policy not found";
                ClaimButton.Enabled = false;
                button1.Enabled = false;
            }
        }
        public bool DataValidation()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(DescriptionRichTextBox.Text))
            {
                errorProvider1.SetError(DescriptionRichTextBox, "Description is required");
                return false;
            }
            return true;
        }

        private void ClaimButton_Click(object sender, EventArgs e)
        {
            if (PolicyStatus.Text.Equals("active"))
            {
                if (DataValidation())
                {
                    ClaimTableAdapter claimTableAdapter = new ClaimTableAdapter();
                    claimTableAdapter.InsertClaim(policyID, dateTimePicker1.Text,"approved", DescriptionRichTextBox.Text, policyType.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PolicyStatus.Text.Equals("active"))
            {
                if (DataValidation())
                {
                    ClaimTableAdapter claimTableAdapter = new ClaimTableAdapter();
                    claimTableAdapter.InsertClaim(policyID, dateTimePicker1.Text, "disapproved", DescriptionRichTextBox.Text, policyType.Text);
                }
            }
        }


        private void ClientIDTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validate clientID

            if (char.IsControl(e.KeyChar))
            {
                return; // allow delete and other controls
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // PREVENT anything that this not digit to be pressed
            }
        }
    }
}
