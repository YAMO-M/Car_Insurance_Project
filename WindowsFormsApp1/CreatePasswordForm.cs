using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class CreatePasswordForm : Form
    {
        public CreatePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            if (string.IsNullOrWhiteSpace(createPasswordTextbox.Text))
            {
                errorProvider1.SetError(createPasswordTextbox, "Password is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(createPasswordTextbox, "");
            }

            if (string.IsNullOrWhiteSpace(confirmPassword.Text))
            {
                errorProvider1.SetError(confirmPassword, "Password is required");
                valid = false;
            }
            else
            {
                errorProvider1.SetError(confirmPassword, "");
            }

            if (!valid)
            {
                return;
            }
            else
            {
                LoginForm form1 = new LoginForm();
                form1.Show();
            }
        }
    }
}
