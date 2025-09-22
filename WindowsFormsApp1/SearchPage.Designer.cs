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
            this.label2 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PolicyNumberTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label25 = new System.Windows.Forms.Label();
            this.carError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientIDTextBox
            // 
            this.ClientIDTextBox.Location = new System.Drawing.Point(231, 62);
            this.ClientIDTextBox.Name = "ClientIDTextBox";
            this.ClientIDTextBox.Size = new System.Drawing.Size(380, 26);
            this.ClientIDTextBox.TabIndex = 1;
            this.ClientIDTextBox.TextChanged += new System.EventHandler(this.ClientIDTextBox_TextChanged);
            this.ClientIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientIDTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Client ID:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchButton.Location = new System.Drawing.Point(640, 57);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(165, 48);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(70, 726);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Policy Update:";
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.confirmButton.Location = new System.Drawing.Point(640, 726);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(147, 38);
            this.confirmButton.TabIndex = 8;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton1.Location = new System.Drawing.Point(267, 726);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 29);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Activate";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton2.Location = new System.Drawing.Point(444, 723);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(136, 29);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "De-activate";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Last name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 331);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 372);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phone Number";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(141, 166);
            this.NameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.ReadOnly = true;
            this.NameTextbox.Size = new System.Drawing.Size(148, 26);
            this.NameTextbox.TabIndex = 18;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(168, 331);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(148, 26);
            this.IDTextBox.TabIndex = 19;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(141, 282);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(292, 26);
            this.EmailTextBox.TabIndex = 20;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(150, 242);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.ReadOnly = true;
            this.AddressTextBox.Size = new System.Drawing.Size(344, 26);
            this.AddressTextBox.TabIndex = 21;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(164, 202);
            this.LastNameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.ReadOnly = true;
            this.LastNameTextbox.Size = new System.Drawing.Size(148, 26);
            this.LastNameTextbox.TabIndex = 22;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(196, 372);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.ReadOnly = true;
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.PhoneNumberTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Client details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 454);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "policy details:";
            // 
            // PolicyNumberTextBox
            // 
            this.PolicyNumberTextBox.Location = new System.Drawing.Point(192, 515);
            this.PolicyNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PolicyNumberTextBox.Name = "PolicyNumberTextBox";
            this.PolicyNumberTextBox.ReadOnly = true;
            this.PolicyNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.PolicyNumberTextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 520);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "PolicyNumber:";
            // 
            // StartDateTextBox
            // 
            this.StartDateTextBox.Location = new System.Drawing.Point(192, 595);
            this.StartDateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartDateTextBox.Name = "StartDateTextBox";
            this.StartDateTextBox.ReadOnly = true;
            this.StartDateTextBox.Size = new System.Drawing.Size(148, 26);
            this.StartDateTextBox.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 565);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "PolicyType:";
            // 
            // PolicyTypeTextBox
            // 
            this.PolicyTypeTextBox.Location = new System.Drawing.Point(192, 555);
            this.PolicyTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PolicyTypeTextBox.Name = "PolicyTypeTextBox";
            this.PolicyTypeTextBox.ReadOnly = true;
            this.PolicyTypeTextBox.Size = new System.Drawing.Size(148, 26);
            this.PolicyTypeTextBox.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 600);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "start date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(366, 569);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "status:";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(432, 569);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(148, 26);
            this.StatusTextBox.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(84, 640);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "end date:";
            // 
            // EndDateTextBox
            // 
            this.EndDateTextBox.Location = new System.Drawing.Point(196, 635);
            this.EndDateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndDateTextBox.Name = "EndDateTextBox";
            this.EndDateTextBox.ReadOnly = true;
            this.EndDateTextBox.Size = new System.Drawing.Size(148, 26);
            this.EndDateTextBox.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(366, 520);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "premium amount:";
            // 
            // PremiumAmoutTextBox
            // 
            this.PremiumAmoutTextBox.Location = new System.Drawing.Point(506, 515);
            this.PremiumAmoutTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PremiumAmoutTextBox.Name = "PremiumAmoutTextBox";
            this.PremiumAmoutTextBox.ReadOnly = true;
            this.PremiumAmoutTextBox.Size = new System.Drawing.Size(148, 26);
            this.PremiumAmoutTextBox.TabIndex = 36;
            // 
            // policyError
            // 
            this.policyError.AutoSize = true;
            this.policyError.Location = new System.Drawing.Point(184, 454);
            this.policyError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.policyError.Name = "policyError";
            this.policyError.Size = new System.Drawing.Size(0, 20);
            this.policyError.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(610, 409);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 20);
            this.label17.TabIndex = 39;
            // 
            // clientError
            // 
            this.clientError.AutoSize = true;
            this.clientError.Location = new System.Drawing.Point(830, 72);
            this.clientError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientError.Name = "clientError";
            this.clientError.Size = new System.Drawing.Size(0, 20);
            this.clientError.TabIndex = 40;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(693, 320);
            this.YearTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.ReadOnly = true;
            this.YearTextBox.Size = new System.Drawing.Size(148, 26);
            this.YearTextBox.TabIndex = 46;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(622, 325);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 20);
            this.label20.TabIndex = 45;
            this.label20.Text = "Year";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(693, 288);
            this.ModelTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.ReadOnly = true;
            this.ModelTextBox.Size = new System.Drawing.Size(148, 26);
            this.ModelTextBox.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(622, 292);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 20);
            this.label21.TabIndex = 47;
            this.label21.Text = "Model";
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Location = new System.Drawing.Point(693, 242);
            this.MakeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.ReadOnly = true;
            this.MakeTextBox.Size = new System.Drawing.Size(148, 26);
            this.MakeTextBox.TabIndex = 50;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(622, 246);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 20);
            this.label22.TabIndex = 49;
            this.label22.Text = "Make";
            // 
            // VinTextBox
            // 
            this.VinTextBox.Location = new System.Drawing.Point(693, 202);
            this.VinTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VinTextBox.Name = "VinTextBox";
            this.VinTextBox.ReadOnly = true;
            this.VinTextBox.Size = new System.Drawing.Size(148, 26);
            this.VinTextBox.TabIndex = 52;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(622, 206);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 20);
            this.label23.TabIndex = 51;
            this.label23.Text = "Vin:";
            // 
            // RegistrationNumberTextBox
            // 
            this.RegistrationNumberTextBox.Location = new System.Drawing.Point(693, 160);
            this.RegistrationNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegistrationNumberTextBox.Name = "RegistrationNumberTextBox";
            this.RegistrationNumberTextBox.ReadOnly = true;
            this.RegistrationNumberTextBox.Size = new System.Drawing.Size(148, 26);
            this.RegistrationNumberTextBox.TabIndex = 54;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(525, 165);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(159, 20);
            this.label24.TabIndex = 53;
            this.label24.Text = "Registration Number:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(525, 125);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(88, 20);
            this.label25.TabIndex = 55;
            this.label25.Text = "Car details:";
            // 
            // carError
            // 
            this.carError.AutoSize = true;
            this.carError.Location = new System.Drawing.Point(622, 125);
            this.carError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carError.Name = "carError";
            this.carError.Size = new System.Drawing.Size(0, 20);
            this.carError.TabIndex = 56;
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.carError);
            this.Controls.Add(this.label25);
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
            this.Controls.Add(this.PolicyNumberTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
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
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientIDTextBox);
            this.Name = "SearchPage";
            this.Size = new System.Drawing.Size(1221, 1118);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ClientIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PolicyNumberTextBox;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label carError;
    }
}
