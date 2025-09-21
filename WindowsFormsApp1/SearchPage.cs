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

           ClientTableAdapter clientTableAdapter = new ClientTableAdapter();
           PolicyTableAdapter policyTableAdapter = new PolicyTableAdapter(); 
           CarTableAdapter carTableAdapter = new CarTableAdapter();

           if ((int)clientTableAdapter.Check_If_Client_Exist(clientID) > 0)
            {
                DataRow client = clientTableAdapter.GetClientDetails(clientID).Rows[0];

                NameTextbox.Text = client["FirstName"].ToString();
                LastNameTextbox.Text = client["LastName"].ToString();
                AddressTextBox.Text = client["Address"].ToString();
                EmailTextBox.Text = client["Email"].ToString();
                PhoneNumberTextBox.Text = client["PhoneNumber"].ToString();
                IDTextBox.Text = client["IDNumber"].ToString();

                if ((int)policyTableAdapter.Check_If_Client_Has_Policy(clientID) > 0)
                {
                   DataRow policy = policyTableAdapter.GetPolicyDetails(clientID).Rows[0];

                    PolicyNumberTextBox.Text = policy["PolicyNumber"].ToString();
                    PolicyTypeTextBox.Text = policy["PolicyType"].ToString();
                    StartDateTextBox.Text = policy["StartDate"].ToString();
                    EndDateTextBox.Text = policy["EndDate"].ToString();
                    PremiumAmoutTextBox.Text = policy["PremiumAmount"].ToString();
                    StatusTextBox.Text = policy["Status"].ToString();

                    int carID = (int)policy["CarID"];
                    DataRow car = carTableAdapter.GetCarDetails(carID).Rows[0]; // not necessary to check because if you have policy implies you have a car
                    RegistrationNumberTextBox.Text = car["RegistrationNumber"].ToString();
                    VinTextBox.Text = car["RegistrationNumber"].ToString();
                    MakeTextBox.Text = car["RegistrationNumber"].ToString();
                    ModelTextBox.Text = car["RegistrationNumber"].ToString();
                    YearTextBox.Text = car["RegistrationNumber"].ToString();
                   

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
            PolicyNumberTextBox.Text = "";
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
            }
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

        private void ClientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
