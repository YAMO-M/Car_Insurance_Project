namespace WindowsFormsApp1
{
    partial class SearchPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StartDateTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PolicyTypeTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.EndDateTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.PremiumAmoutTextBox = new System.Windows.Forms.TextBox();
            this.policyError = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.clientError = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.VinTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.RegistrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.carError = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientIDTextBox
            // 
            this.ClientIDTextBox.Location = new System.Drawing.Point(178, 44);
            this.ClientIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientIDTextBox.Name = "ClientIDTextBox";
            this.ClientIDTextBox.Size = new System.Drawing.Size(535, 20);
            this.ClientIDTextBox.TabIndex = 1;
            this.ClientIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientIDTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Client ID:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.searchButton.Location = new System.Drawing.Point(752, 35);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 31);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phone Number";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(141, 108);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.ReadOnly = true;
            this.NameTextbox.Size = new System.Drawing.Size(373, 20);
            this.NameTextbox.TabIndex = 18;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(139, 215);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(375, 20);
            this.IDTextBox.TabIndex = 19;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(139, 184);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(375, 20);
            this.EmailTextBox.TabIndex = 20;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(139, 158);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.ReadOnly = true;
            this.AddressTextBox.Size = new System.Drawing.Size(375, 20);
            this.AddressTextBox.TabIndex = 21;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(139, 132);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.ReadOnly = true;
            this.LastNameTextbox.Size = new System.Drawing.Size(375, 20);
            this.LastNameTextbox.TabIndex = 22;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(139, 242);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.ReadOnly = true;
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(375, 20);
            this.PhoneNumberTextBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Policy Details:";
            // 
            // StartDateTextBox
            // 
            this.StartDateTextBox.Location = new System.Drawing.Point(151, 386);
            this.StartDateTextBox.Name = "StartDateTextBox";
            this.StartDateTextBox.ReadOnly = true;
            this.StartDateTextBox.Size = new System.Drawing.Size(375, 20);
            this.StartDateTextBox.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "PolicyType:";
            // 
            // PolicyTypeTextBox
            // 
            this.PolicyTypeTextBox.Location = new System.Drawing.Point(151, 360);
            this.PolicyTypeTextBox.Name = "PolicyTypeTextBox";
            this.PolicyTypeTextBox.ReadOnly = true;
            this.PolicyTypeTextBox.Size = new System.Drawing.Size(375, 20);
            this.PolicyTypeTextBox.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Start Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 340);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Status:";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(153, 336);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(375, 20);
            this.StatusTextBox.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 416);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "End Date:";
            // 
            // EndDateTextBox
            // 
            this.EndDateTextBox.Location = new System.Drawing.Point(153, 412);
            this.EndDateTextBox.Name = "EndDateTextBox";
            this.EndDateTextBox.ReadOnly = true;
            this.EndDateTextBox.Size = new System.Drawing.Size(375, 20);
            this.EndDateTextBox.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 308);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Premium Amount:";
            // 
            // PremiumAmoutTextBox
            // 
            this.PremiumAmoutTextBox.Location = new System.Drawing.Point(153, 304);
            this.PremiumAmoutTextBox.Name = "PremiumAmoutTextBox";
            this.PremiumAmoutTextBox.ReadOnly = true;
            this.PremiumAmoutTextBox.Size = new System.Drawing.Size(375, 20);
            this.PremiumAmoutTextBox.TabIndex = 36;
            // 
            // policyError
            // 
            this.policyError.AutoSize = true;
            this.policyError.Location = new System.Drawing.Point(123, 295);
            this.policyError.Name = "policyError";
            this.policyError.Size = new System.Drawing.Size(0, 13);
            this.policyError.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(406, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 39;
            // 
            // clientError
            // 
            this.clientError.AutoSize = true;
            this.clientError.Location = new System.Drawing.Point(554, 47);
            this.clientError.Name = "clientError";
            this.clientError.Size = new System.Drawing.Size(0, 13);
            this.clientError.TabIndex = 40;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(694, 223);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.ReadOnly = true;
            this.YearTextBox.Size = new System.Drawing.Size(396, 20);
            this.YearTextBox.TabIndex = 46;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(620, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 45;
            this.label20.Text = "Year";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(694, 202);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(396, 20);
            this.ModelTextBox.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(620, 204);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Model";
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Location = new System.Drawing.Point(694, 172);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.ReadOnly = true;
            this.MakeTextBox.Size = new System.Drawing.Size(396, 20);
            this.MakeTextBox.TabIndex = 50;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(620, 174);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "Make";
            // 
            // VinTextBox
            // 
            this.VinTextBox.Location = new System.Drawing.Point(694, 146);
            this.VinTextBox.Name = "VinTextBox";
            this.VinTextBox.ReadOnly = true;
            this.VinTextBox.Size = new System.Drawing.Size(396, 20);
            this.VinTextBox.TabIndex = 52;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(620, 148);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 51;
            this.label23.Text = "Vin:";
            // 
            // RegistrationNumberTextBox
            // 
            this.RegistrationNumberTextBox.Location = new System.Drawing.Point(694, 119);
            this.RegistrationNumberTextBox.Name = "RegistrationNumberTextBox";
            this.RegistrationNumberTextBox.ReadOnly = true;
            this.RegistrationNumberTextBox.Size = new System.Drawing.Size(396, 20);
            this.RegistrationNumberTextBox.TabIndex = 54;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(555, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(106, 13);
            this.label24.TabIndex = 53;
            this.label24.Text = "Registration Number:";
            // 
            // carError
            // 
            this.carError.AutoSize = true;
            this.carError.Location = new System.Drawing.Point(620, 96);
            this.carError.Name = "carError";
            this.carError.Size = new System.Drawing.Size(0, 13);
            this.carError.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(554, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Car Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Client Details:";
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.carError);
            this.Controls.Add(this.RegistrationNumberTextBox);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.VinTextBox);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.MakeTextBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.clientError);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.policyError);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PremiumAmoutTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.EndDateTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.PolicyTypeTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.StartDateTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientIDTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchPage";
            this.Size = new System.Drawing.Size(1185, 672);
            this.Load += new System.EventHandler(this.SearchPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ClientIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox StartDateTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PolicyTypeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EndDateTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox PremiumAmoutTextBox;
        private System.Windows.Forms.Label policyError;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label clientError;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox VinTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox RegistrationNumberTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label carError;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
    }
}
