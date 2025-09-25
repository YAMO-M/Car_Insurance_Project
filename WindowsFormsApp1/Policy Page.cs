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
    public partial class AddVehicle : UserControl
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private ErrorProvider errorProvider1 = new ErrorProvider();
        private PolicyTableAdapter policyTableAdapter = new PolicyTableAdapter();
        private ClientTableAdapter clientTableAdapter = new ClientTableAdapter();
        private CarTableAdapter carTableAdapter = new CarTableAdapter();
        private PaymentTableAdapter paymentTableAdapter = new PaymentTableAdapter();
        private void Policy3_CheckedChanged(object sender, EventArgs e)
        {
            if (Policy3.Checked)
            {
                AmountTextBox.Text = "3000";
               
            }
        }

        private void Policy2_CheckedChanged(object sender, EventArgs e)
        {
            if (Policy2.Checked)
            {
                AmountTextBox.Text = "2000";

            }
        }

        private void Policy1_CheckedChanged(object sender, EventArgs e)
        {
           
                AmountTextBox.Text = "1000";

           
        }
        private void textBox1_TextChanged(object sender, EventArgs e)

        {
            PolicyCreation.Enabled = true;
            ClientError.Text = "";
           
            if (string.IsNullOrEmpty(textBox1.Text)) return;
            if ((int)clientTableAdapter.Check_If_Client_Exist(int.Parse(textBox1.Text)) > 0){
                if((int)policyTableAdapter.Check_If_Policy_Exist(int.Parse(textBox1.Text)) > 0)
                {
                    ClientError.Text = "policy already exist";
                    PolicyCreation.Enabled = false;
                }
            }
            else
            {
                ClientError.Text = "client does not exist";
                PolicyCreation.Enabled = false;
            }
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return; // allow delete and other controls
            }
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // PREVENT anything that this not digit to be pressed
            }
        }

      
        public bool dataValidation()
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBox1.Text)) return false;
            
            if (string.IsNullOrEmpty(VINtextBox.Text.Trim()) || VINtextBox.Text.Length < 11)
            {
                errorProvider1.SetError(VINtextBox, "VIN is required & must be atleast 11");
                return false;
            }
            else if (MakeTextBox.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(MakeTextBox, "Make must be atleast 3 letters");
                return false;
            }
            else if (ModelTextBox.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(ModelTextBox, "Model must be atleast 3 letters");
                return false;
            }
            if (string.IsNullOrEmpty(RegistrationPlateTextBox.Text.Trim()))
            {
                errorProvider1.SetError(RegistrationPlateTextBox, "Registration Plate is required");
                return false;
            }
            if (string.IsNullOrEmpty(AmountTextBox.Text))
            {
                errorProvider1.SetError(AmountTextBox, "Choose a policy");
                return false;
            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "Choose a year");
                return false;
            }
            if (string.IsNullOrEmpty(PaymentMethodComboBox.Text))
            {
                errorProvider1.SetError(PaymentMethodComboBox, "Choose a payment method");
                return false;
            }
                return true;
        }


        private void PolicyCreation_Click_1(object sender, EventArgs e)
        {
            
            if (dataValidation())          
                if ((int)carTableAdapter.Check_If_Car_Exist(int.Parse(textBox1.Text)) > 0){
                    errorProvider1.SetError(PolicyCreation, "Car already exist");
                    return;
                }
                carTableAdapter.Insert(int.Parse(textBox1.Text), RegistrationPlateTextBox.Text, VINtextBox.Text, MakeTextBox.Text, ModelTextBox.Text, int.Parse(comboBox1.Text));
                DataRow car = carTableAdapter.GetCarDetails(int.Parse(textBox1.Text)).Rows[0];
                string Policy = "";
                if (Policy1.Checked) Policy = "Policy 1";
                else if (Policy2.Checked) Policy = "Policy 2";
                else Policy = "Policy 3";

                policyTableAdapter.InsertPolicy(int.Parse(textBox1.Text), (int)car["CarID"], Policy, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), Decimal.Parse(AmountTextBox.Text), "active");
                DataRow policy = policyTableAdapter.GetPolicyDetails(int.Parse(textBox1.Text)).Rows[0];
                paymentTableAdapter.Insert((int)policy["PolicyID"], DateTime.Parse(dateTimePicker1.Text), Decimal.Parse(AmountTextBox.Text), PaymentMethodComboBox.Text);

                MessageBox.Show("Policy created");
            }
        }
    }
}
