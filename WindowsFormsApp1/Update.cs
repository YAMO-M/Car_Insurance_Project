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

namespace WindowsFormsApp1
{
    public partial class Update : UserControl
    {
        public Update()
        {
            InitializeComponent();
        }
        ClientTableAdapter clientTableAdapter = new ClientTableAdapter();
        PolicyTableAdapter policyTableAdapter = new PolicyTableAdapter();
    
        ErrorProvider errorProvider1 = new ErrorProvider();

        private void searchButton_Click(object sender, EventArgs e)
        {
            clientError.ForeColor = Color.Red;
            policyError.ForeColor = Color.Red;


            if (string.IsNullOrEmpty(ClientIDTextBox.Text))
            {
                clientError.Text = "enter client id";
                return;
            }

            int clientID = int.Parse(ClientIDTextBox.Text);
            clearAllTextBoxs();


            if ((int)clientTableAdapter.Check_If_Client_Exist(clientID) > 0)
            {
                DataRow client = clientTableAdapter.GetClientDetail(clientID).Rows[0];

                NameTextbox.Text = client["FirstName"].ToString();
                LastNameTextbox.Text = client["LastName"].ToString();
                AddressTextBox.Text = client["Address"].ToString();
                EmailTextBox.Text = client["Email"].ToString();
                PhoneNumTextBox.Text = client["PhoneNumber"].ToString();
                IDTextBox.Text = client["IDNumber"].ToString();

                if ((int)policyTableAdapter.Check_If_Policy_Exist(clientID) > 0)
                {
                    DataRow policy = policyTableAdapter.GetPolicyDetails(clientID).Rows[0];

                    PolicyTypeTextBox.Text = policy["PolicyType"].ToString();

                    PremiumAmoutTextBox.Text = policy["PremiumAmount"].ToString();
                    StatusTextBox.Text = policy["Status"].ToString();





                }
                else
                {

                    policyError.Text = "no policy found";

                }

            }
            else
            {
                clientError.Text = "not client found";
            }
        }
        public void clearAllTextBoxs()
        {
            // client details
            NameTextbox.Text = "";
            LastNameTextbox.Text = "";
            AddressTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneNumTextBox.Text = "";
            IDTextBox.Text = "";

            // policy details
            PolicyTypeTextBox.Text = "";

            PremiumAmoutTextBox.Text = "";
            StatusTextBox.Text = "";


            //errros
            policyError.Text = "";

            clientError.Text = "";

            // radio
            ActivateradioButton.Checked = false;
            De_ActivateradioButton2.Checked = false;
        }

        private void UpdateStatusConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientIDTextBox.Text))
            {
                clientError.Text = "enter client id";
                return;
            }

            errorProvider1.Clear();
            string policyStatus = "";
            if (ActivateradioButton.Checked)
            {

                policyStatus = "active";

            }
            else if (De_ActivateradioButton2.Checked)
            {
                policyStatus = "not active";
            }
            else
            {

                errorProvider1.SetError(UpdateStatusConfirmButton, "press radio button");
                return;
            }
            if (DataValidation()) { 
            clientTableAdapter.UpdateClientDetails(AddressTextBox.Text, PhoneNumTextBox.Text, int.Parse(ClientIDTextBox.Text));
            
                string Policy = "";
                if (Policy1radioButton.Checked) Policy = "Collision";
                else if (Policy2radioButton.Checked) Policy = "Comprehensive";
                else Policy = "Third party";
                policyTableAdapter.UpdateStatus(policyStatus,Policy,Decimal.Parse(PremiumAmoutTextBox.Text), int.Parse(ClientIDTextBox.Text.Trim()));
                MessageBox.Show("Client Updated");
                ClientIDTextBox.Text = "";
                clearAllTextBoxs();
            }
        }
        public bool DataValidation()
        {
            if (string.IsNullOrEmpty(PhoneNumTextBox.Text.Trim()))
            {
                errorProvider1.SetError(PhoneNumTextBox, "Phone Number is required");
                return false;
            }
            else if (PhoneNumTextBox.Text.Trim().Length <= 9)
            {
                errorProvider1.SetError(PhoneNumTextBox, "Phone Number must be 10 numbers");
                return false;
            }
            else if (!PhoneNumTextBox.Text.StartsWith("0") ||
                    !(PhoneNumTextBox.Text.Trim()[1] == '6' ||
                      PhoneNumTextBox.Text.Trim()[1] == '7' ||
                      PhoneNumTextBox.Text.Trim()[1] == '8'))
            {
                errorProvider1.SetError(PhoneNumTextBox, "Phone Number must start with 06,07,08");
                return false;
            }
            if (string.IsNullOrEmpty(AddressTextBox.Text.Trim()))
            {
                errorProvider1.SetError(AddressTextBox, "Street Address is required");
                return false;
            }
            else if (AddressTextBox.Text.Trim().Length < 2)
            {
                errorProvider1.SetError(AddressTextBox, "Street Address must be atleast 3 letters");
                return false;
            }
            return true;
        }

        private void Policy1radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Policy1radioButton.Checked)
            {
                PremiumAmoutTextBox.Text = "500";

            }
        }

        private void Policy2radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Policy2radioButton.Checked)
            {
                PremiumAmoutTextBox.Text = "750";

            }
        }

        private void Policy3radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Policy3radioButton.Checked)
            {
                PremiumAmoutTextBox.Text = "1000";

            }
        }
        private void Policy1radioButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Policy 1", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                Policy1radioButton.Checked = false;

        }

        private void Policy2radioButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Policy 2", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                Policy2radioButton.Checked = false;

        }

        private void Policy3radioButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Policy 3", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                Policy3radioButton.Checked = false;
        }

    

        private void De_ActivateradioButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("De-activate Policy?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
        {
                De_ActivateradioButton2.Checked = false;
                ActivateradioButton.Checked = true;
            }
        }

        private void ActivateradioButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Activate Policy?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                De_ActivateradioButton2.Checked = true;
                ActivateradioButton.Checked = false;
            }
        }

        private void PhoneNumTextBox_Click(object sender, EventArgs e)
        {
            PhoneNumTextBox.Select(PhoneNumTextBox.MaskedTextProvider.ToString(false, false).Length + (PhoneNumTextBox.Text.Length == 12 ? 2 : 0), 0);

        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void ClientIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            if (ClientIDTextBox.Text.Length > 4)
            {
                e.Handled = true;
            }
        }

        private void label18_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ClientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
