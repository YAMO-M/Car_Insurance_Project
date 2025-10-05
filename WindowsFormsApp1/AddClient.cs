using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet1TableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class AddClient : UserControl
    {
    
        public AddClient()
        {
            InitializeComponent();
            PostalCodeTextBox.Mask = "0000";
            PostalCodeTextBox.PromptChar = ' ';

        }
        ClientTableAdapter adapter = new ClientTableAdapter();
        ErrorProvider errorProvider1 = new ErrorProvider();
        private void AddClientButton_Click(object sender, EventArgs e)
        {
            if (DataValidation())
            {
                try
                {
                    string name = CustomerName.Text;
                    string lastname = CustomerLastName.Text;
                    string id = CustomerID.Text;
                    string address = StreetAddressTextBox.Text + ", " + CityTextBox.Text + ", " + ProvinceComboBox.Text + ", " + PostalCodeTextBox.Text;
                    string email = EmailTextBox.Text.ToLower();
                    string phoneno = PhoneNumTextBox.Text;
                    adapter.Insert(name, lastname, address, email, id, phoneno);
                    string ClientId = adapter.getClientDetails(email).Rows[0]["ClientID"].ToString();
                    MessageBox.Show("Client succefully added , ClientID = " + ClientId);
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Client Alreay Exists");
                }
            } 

        }
            public bool DataValidation() { 
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(CustomerName.Text.Trim()))
                {
                    errorProvider1.SetError(CustomerName, "Name is required");
                    return false;
                }
                else if (CustomerName.Text.Trim().Length < 3)
                {
                    errorProvider1.SetError(CustomerName, "Name must be atleast 3 letters");
                    return false;
                }
                else if (CustomerName.Text.Trim().Any(Char.IsDigit) || CustomerName.Text.Trim().Any(Char.IsPunctuation))
                {
                    errorProvider1.SetError(CustomerName, "Name contains no digits OR symbols");
                    return false;
                }
                if (string.IsNullOrEmpty(CustomerLastName.Text.Trim()))
                {
                    errorProvider1.SetError(CustomerLastName, "Surname is required");
                    return false;
                }
                else if (CustomerLastName.Text.Trim().Length < 2)
                {
                    errorProvider1.SetError(CustomerLastName, "Surname must be atleast 3 letters");
                    return false;
                }
                else if (CustomerLastName.Text.Trim().Any(Char.IsDigit) || CustomerLastName.Text.Trim().Any(Char.IsPunctuation))
                {
                    errorProvider1.SetError(CustomerLastName, "Surname contains no digits or symbols");
                    return false;
                }
                if (string.IsNullOrEmpty(CustomerID.Text.Trim()))
                {
                    errorProvider1.SetError(CustomerID, "ID Number is required");
                    return false;
                }
                else if (CustomerID.Text.Trim().Length < 13)
                {
                    errorProvider1.SetError(CustomerID, "ID Number must be 13 numbers");
                    return false;
                }
                else if (!(IDErrorLabel.Text == ""))
                {
                    return false;
                }
                if (string.IsNullOrEmpty(EmailTextBox.Text.Trim()))
                {
                    errorProvider1.SetError(EmailTextBox, "Email is required");
                    return false;
                }
                else if (!(EmailTextBox.Text.ToLower().EndsWith("@gmail.com")) || EmailTextBox.Text.Split('@')[0].Length < 4)
                {
                    errorProvider1.SetError(EmailTextBox, "Enter valid email address (e.g example@gmail.com).");
                    return false;
                }
                else if (!(EmailErrorLabel.Text == ""))
                {
                    return false;
                }
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
                if (string.IsNullOrEmpty(StreetAddressTextBox.Text.Trim()))
                {
                    errorProvider1.SetError(StreetAddressTextBox, "Street Address is required");
                    return false;
                }
                else if (StreetAddressTextBox.Text.Trim().Length < 2)
                {
                    errorProvider1.SetError(StreetAddressTextBox, "Street Address must be atleast 3 letters");
                    return false;
                }
                if (string.IsNullOrEmpty(CityTextBox.Text.Trim()))
                {
                    errorProvider1.SetError(CityTextBox, "City is required");
                    return false;
                }
                else if (CityTextBox.Text.Trim().Length < 2)
                {
                    errorProvider1.SetError(CityTextBox, "City Name must be atleast 3 letters");
                    return false;
                }
                if (string.IsNullOrEmpty(ProvinceComboBox.Text.Trim()))
                {
                    errorProvider1.SetError(ProvinceComboBox, "Province is required");
                    return false;
                }
                if (string.IsNullOrEmpty(PostalCodeTextBox.Text.Trim()))
                {
                    errorProvider1.SetError(PostalCodeTextBox, "Postal/Zip Code is required");
                    return false;
                }
                else if (PostalCodeTextBox.Text.Trim().Length < 3)
                {
                    errorProvider1.SetError(PostalCodeTextBox, "Postal/Zip Code must be 4 or 5 numbers");
                    return false;
                }

                return true;
            }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            int checkDuplicateEmail = (int) adapter.GetNoOfClientsWithEmail(EmailTextBox.Text);
            EmailErrorLabel.ForeColor = Color.Red;
            EmailErrorLabel.Text = checkDuplicateEmail > 0 ? " Email Already in use" : "";
        }


        private void CustomerID_TextChanged(object sender, EventArgs e)
        {
                IDErrorLabel.ForeColor = Color.Red;
                int checkDuplicateID = (int)adapter.Check_If_Id_Exist(CustomerID.Text);
                IDErrorLabel.Text = checkDuplicateID > 0 ? " ID Already in use" : "";
            
        }

        private void AddClient_Load(object sender, EventArgs e)
        {

        }

        private void CustomerID_Enter(object sender, EventArgs e)
        {
            CustomerID.Select(0, 0);
        }

        private void PostalCodeTextBox_Enter(object sender, EventArgs e)
        {
            PostalCodeTextBox.Select(0, 0);
        }

        private void CustomerID_Click(object sender, EventArgs e)
        {
            //CustomerID.Select(0, 0);
            CustomerID.Select(CustomerID.MaskedTextProvider.ToString(false, false).Length, 1);
        }

        private void PhoneNumTextBox_Click(object sender, EventArgs e)
        {
            //PhoneNumTextBox.Select(0, 0);
          PhoneNumTextBox.Select(PhoneNumTextBox.MaskedTextProvider.ToString(false, false).Length+(PhoneNumTextBox.Text.Length==12 ? 2 : 0), 0);
        }

        private void PostalCodeTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PostalCodeTextBox_Click(object sender, EventArgs e)
        {
            //PostalCodeTextBox.Select(PostalCodeTextBox.Text.Length-3, 0);
            PostalCodeTextBox.Select(PostalCodeTextBox.MaskedTextProvider.ToString(false, false).Length + (PostalCodeTextBox.Text.Length == 6 ? 1:0), 1);
           
        }
    }

}

