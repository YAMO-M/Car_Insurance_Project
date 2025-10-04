using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using WindowsFormsApp1.DataSet1TableAdapters;

namespace WindowsFormsApp1
{
    public partial class SearchPage : UserControl
    {
        public SearchPage()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }
        ClientTableAdapter clientTableAdapter = new ClientTableAdapter();
        PolicyTableAdapter policyTableAdapter = new PolicyTableAdapter();
        CarTableAdapter carTableAdapter = new CarTableAdapter();
        ErrorProvider errorProvider = new ErrorProvider();
        
        private void searchButton_Click(object sender, EventArgs e)
        {
            clientError.ForeColor = Color.Red;
            policyError.ForeColor = Color.Red;
            carError.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(ClientIDTextBox.Text)) {
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
                PhoneNumberTextBox.Text = client["PhoneNumber"].ToString();
                IDTextBox.Text = client["IDNumber"].ToString();

                if ((int)policyTableAdapter.Check_If_Policy_Exist(clientID) > 0)
                {
                    DataRow policy = policyTableAdapter.GetPolicyDetails(clientID).Rows[0];

                    PolicyTypeTextBox.Text = policy["PolicyType"].ToString();
                    StartDateTextBox.Text = policy["StartDate"].ToString();
                    EndDateTextBox.Text = policy["EndDate"].ToString();
                    PremiumAmoutTextBox.Text = policy["PremiumAmount"].ToString();
                    StatusTextBox.Text = policy["Status"].ToString();


                    DataRow car = carTableAdapter.GetCarDetails(clientID).Rows[0]; // not necessary to check because if you have policy implies you have a car
                    RegistrationNumberTextBox.Text = car["RegistrationNumber"].ToString();
                    VinTextBox.Text = car["Vin"].ToString();
                    MakeTextBox.Text = car["Make"].ToString();
                    ModelTextBox.Text = car["Model"].ToString();
                    YearTextBox.Text = car["Year"].ToString();


                }
                else
                {

                    policyError.Text = "no policy found";
                    carError.Text = "no car found";
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
            PhoneNumberTextBox.Text = "";
            IDTextBox.Text = "";

            // policy details
            PolicyTypeTextBox.Text = "";
            StartDateTextBox.Text = "";
            EndDateTextBox.Text = "";
            PremiumAmoutTextBox.Text = "";
            StatusTextBox.Text = "";

            // car details
            RegistrationNumberTextBox.Text = "";
            VinTextBox.Text = "";
            MakeTextBox.Text = "";
            ModelTextBox.Text = "";
            YearTextBox.Text = "";

            //errros
            policyError.Text = "";
            carError.Text = "";
            clientError.Text = "";

            // radio
            ActivateradioButton.Checked = false;
            De_ActivateradioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrEmpty(ClientIDTextBox.Text))
            {
                clientError.Text = "enter client id";
                return;
            }

            errorProvider.Clear();
           
            if (ActivateradioButton.Checked)
            {  
                policyTableAdapter.UpdateStatus("active", int.Parse(ClientIDTextBox.Text));
                

            }
            else if(De_ActivateradioButton2.Checked){
                policyTableAdapter.UpdateStatus( "not active", int.Parse(ClientIDTextBox.Text));
                
            }
            else
            {
                
                errorProvider.SetError(UpdateStatusConfirmButton, "press radio button");
            }
            
            ClientIDTextBox.Text = "";
            clearAllTextBoxs();

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
        }

        private void Policy1radioButton_CheckedChanged(object sender, EventArgs e)
        {
           
           


        }

        private void Policy1radioButton_Enter(object sender, EventArgs e)
        {
            

        }

        private void Policy1radioButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Policy 1", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                Policy1radioButton.Checked = false;
            
        }

        private void Policy2radioButton_Click(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Activate Policy?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                De_ActivateradioButton2.Checked = true;
                ActivateradioButton.Checked = false;
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("De-activate Policy?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                De_ActivateradioButton2.Checked = false;
                ActivateradioButton.Checked = true;
            }
            
        }

        private void SearchPage_Load(object sender, EventArgs e)
        {
            //txtName.DataBindings.Add("Text", clientBsource, "Name");
            //txtLastName.DataBindings.Add("Text", clientBsource, "LastName");
            //txtAddress.DataBindings.Add("Text", clientBsource, "Address");
            //txtEmail.DataBindings.Add("Text", clientBsource, "Email");
            //txtIDNumber.DataBindings.Add("Text", clientBsource, "IDNumber");
            //txtPhoneNumber.DataBindings.Add("Text", clientBsource, "PhoneNumber");

            //txtRegNumber.DataBindings.Add("Text", carBsource, "RegistrationNumber");
            //txtVin.DataBindings.Add("Text", carBsource, "VIN");
            //txtMake.DataBindings.Add("Text", carBsource, "Make");
            //txtModel.DataBindings.Add("Text", carBsource, "Model");
            //txtYear.DataBindings.Add("Text", carBsource, "Year");

            


        }
    }
}
