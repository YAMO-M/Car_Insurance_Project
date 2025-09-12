using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet2TableAdapters;

namespace WindowsFormsApp1
{
    public partial class CreateAccountFormFinal : UserControl
    {
        public CreateAccountFormFinal()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = (SignUpForm)ParentForm;
            SignUpPersonalDetails signUpPersonalDetails = signUpForm.GetSignUpPersonalDetails();
            string clientName = signUpPersonalDetails.NameTextBox.Text;
            string clientSurname = signUpPersonalDetails.SurnameTextBox2.Text;
            string clientIdentityNo = signUpPersonalDetails.IDNumbermaskedTextBox.Text;
            string clientAddress = signUpPersonalDetails.StreetAddressTextBox.Text + ", " + signUpPersonalDetails.StreetAddress2TextBox.Text + ", " + signUpPersonalDetails.CityTextBox.Text + ", " + signUpPersonalDetails.ProvinceComboBox.Text + ", " + signUpPersonalDetails.PostalCodemaskedTextBox.Text;
            string clientEmail = emailTextbox.Text;
            string clientPassword = passwordTextBox1.Text;
            string clientPhoneNo = signUpPersonalDetails.PhoneNumberTextBox.Text;
            

            ClientTableAdapter adapter = new ClientTableAdapter();
            adapter.InsertClient(clientName,clientSurname,clientAddress,clientEmail,clientIdentityNo,clientPhoneNo,clientPassword);

        }
    }
}
