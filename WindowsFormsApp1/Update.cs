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
    public partial class Update : UserControl
    {
        public Update()
        {
            InitializeComponent();
        }

        private void ClientIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
            //fill method
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
