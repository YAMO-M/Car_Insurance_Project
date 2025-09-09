namespace WindowsFormsApp1
{
    partial class SignUpForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.surnameTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.idNumberTextbox = new System.Windows.Forms.TextBox();
            this.licenseNumberTextbox = new System.Windows.Forms.TextBox();
            this.IDNumberLabel = new System.Windows.Forms.Label();
            this.LicenseNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumberbox = new System.Windows.Forms.TextBox();
            this.personalDetailsLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.StreetAddress1Box = new System.Windows.Forms.TextBox();
            this.streetAddress2Box = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CurrentAddressLabel = new System.Windows.Forms.Label();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.streetAddressLine2Label = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(12, 70);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextbox.Multiline = true;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(313, 26);
            this.nameTextbox.TabIndex = 0;
            // 
            // surnameTextbox
            // 
            this.surnameTextbox.Location = new System.Drawing.Point(333, 70);
            this.surnameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameTextbox.Multiline = true;
            this.surnameTextbox.Name = "surnameTextbox";
            this.surnameTextbox.Size = new System.Drawing.Size(324, 26);
            this.surnameTextbox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(330, 51);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(76, 20);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Surname";
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Items.AddRange(new object[] {
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925"});
            this.yearComboBox.Location = new System.Drawing.Point(401, 177);
            this.yearComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(199, 28);
            this.yearComboBox.TabIndex = 7;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(192, 177);
            this.monthComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(203, 28);
            this.monthComboBox.TabIndex = 8;
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox.Location = new System.Drawing.Point(12, 177);
            this.dayComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(175, 28);
            this.dayComboBox.TabIndex = 9;
            this.dayComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(9, 123);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(102, 20);
            this.DateOfBirthLabel.TabIndex = 10;
            this.DateOfBirthLabel.Text = "Date of birth";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLabel.Location = new System.Drawing.Point(10, 162);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(33, 17);
            this.dayLabel.TabIndex = 11;
            this.dayLabel.Text = "Day";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(189, 162);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(47, 17);
            this.monthLabel.TabIndex = 12;
            this.monthLabel.Text = "Month";
            this.monthLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(398, 162);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(38, 17);
            this.yearLabel.TabIndex = 13;
            this.yearLabel.Text = "Year";
            // 
            // idNumberTextbox
            // 
            this.idNumberTextbox.Location = new System.Drawing.Point(12, 280);
            this.idNumberTextbox.Name = "idNumberTextbox";
            this.idNumberTextbox.Size = new System.Drawing.Size(313, 26);
            this.idNumberTextbox.TabIndex = 14;
            this.idNumberTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // licenseNumberTextbox
            // 
            this.licenseNumberTextbox.Location = new System.Drawing.Point(331, 280);
            this.licenseNumberTextbox.Name = "licenseNumberTextbox";
            this.licenseNumberTextbox.Size = new System.Drawing.Size(321, 26);
            this.licenseNumberTextbox.TabIndex = 15;
            // 
            // IDNumberLabel
            // 
            this.IDNumberLabel.AutoSize = true;
            this.IDNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNumberLabel.Location = new System.Drawing.Point(12, 264);
            this.IDNumberLabel.Name = "IDNumberLabel";
            this.IDNumberLabel.Size = new System.Drawing.Size(75, 17);
            this.IDNumberLabel.TabIndex = 16;
            this.IDNumberLabel.Text = "ID Number";
            // 
            // LicenseNumberLabel
            // 
            this.LicenseNumberLabel.AutoSize = true;
            this.LicenseNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseNumberLabel.Location = new System.Drawing.Point(331, 264);
            this.LicenseNumberLabel.Name = "LicenseNumberLabel";
            this.LicenseNumberLabel.Size = new System.Drawing.Size(163, 17);
            this.LicenseNumberLabel.TabIndex = 17;
            this.LicenseNumberLabel.Text = "Driver\'s License Number";
            // 
            // phoneNumberbox
            // 
            this.phoneNumberbox.Location = new System.Drawing.Point(12, 343);
            this.phoneNumberbox.Name = "phoneNumberbox";
            this.phoneNumberbox.Size = new System.Drawing.Size(313, 26);
            this.phoneNumberbox.TabIndex = 18;
            // 
            // personalDetailsLabel
            // 
            this.personalDetailsLabel.AutoSize = true;
            this.personalDetailsLabel.Location = new System.Drawing.Point(12, 215);
            this.personalDetailsLabel.Name = "personalDetailsLabel";
            this.personalDetailsLabel.Size = new System.Drawing.Size(133, 20);
            this.personalDetailsLabel.TabIndex = 19;
            this.personalDetailsLabel.Text = "Personal Details";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(331, 343);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(321, 26);
            this.emailTextBox.TabIndex = 20;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(12, 327);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.phoneNumberLabel.TabIndex = 21;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(331, 327);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 17);
            this.emailLabel.TabIndex = 22;
            this.emailLabel.Text = "E- mail";
            // 
            // StreetAddress1Box
            // 
            this.StreetAddress1Box.Location = new System.Drawing.Point(12, 507);
            this.StreetAddress1Box.Name = "StreetAddress1Box";
            this.StreetAddress1Box.Size = new System.Drawing.Size(644, 26);
            this.StreetAddress1Box.TabIndex = 23;
            // 
            // streetAddress2Box
            // 
            this.streetAddress2Box.Location = new System.Drawing.Point(12, 566);
            this.streetAddress2Box.Name = "streetAddress2Box";
            this.streetAddress2Box.Size = new System.Drawing.Size(644, 26);
            this.streetAddress2Box.TabIndex = 24;
            // 
            // provinceTextBox
            // 
            this.provinceTextBox.Location = new System.Drawing.Point(331, 618);
            this.provinceTextBox.Name = "provinceTextBox";
            this.provinceTextBox.Size = new System.Drawing.Size(321, 26);
            this.provinceTextBox.TabIndex = 25;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(12, 618);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(313, 26);
            this.CityTextBox.TabIndex = 26;
            // 
            // CurrentAddressLabel
            // 
            this.CurrentAddressLabel.AutoSize = true;
            this.CurrentAddressLabel.Location = new System.Drawing.Point(12, 452);
            this.CurrentAddressLabel.Name = "CurrentAddressLabel";
            this.CurrentAddressLabel.Size = new System.Drawing.Size(132, 20);
            this.CurrentAddressLabel.TabIndex = 27;
            this.CurrentAddressLabel.Text = "Current Address";
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetAddressLabel.Location = new System.Drawing.Point(9, 491);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(102, 17);
            this.streetAddressLabel.TabIndex = 28;
            this.streetAddressLabel.Text = "Street Address";
            // 
            // streetAddressLine2Label
            // 
            this.streetAddressLine2Label.AutoSize = true;
            this.streetAddressLine2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetAddressLine2Label.Location = new System.Drawing.Point(9, 550);
            this.streetAddressLine2Label.Name = "streetAddressLine2Label";
            this.streetAddressLine2Label.Size = new System.Drawing.Size(145, 17);
            this.streetAddressLine2Label.TabIndex = 29;
            this.streetAddressLine2Label.Text = "Street Address Line 2";
            this.streetAddressLine2Label.Click += new System.EventHandler(this.label14_Click);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(12, 602);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(31, 17);
            this.CityLabel.TabIndex = 30;
            this.CityLabel.Text = "City";
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinceLabel.Location = new System.Drawing.Point(328, 602);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(63, 17);
            this.ProvinceLabel.TabIndex = 31;
            this.ProvinceLabel.Text = "Province";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(12, 678);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(145, 26);
            this.PostalCodeTextBox.TabIndex = 32;
            this.PostalCodeTextBox.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCodeLabel.Location = new System.Drawing.Point(9, 662);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(108, 17);
            this.PostalCodeLabel.TabIndex = 33;
            this.PostalCodeLabel.Text = "Postal/Zip Code";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(12, 386);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(64, 20);
            this.GenderLabel.TabIndex = 34;
            this.GenderLabel.Text = "Gender";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.Location = new System.Drawing.Point(30, 414);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.maleRadioButton.TabIndex = 35;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.Location = new System.Drawing.Point(333, 411);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioButton.TabIndex = 36;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.Location = new System.Drawing.Point(192, 732);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(291, 33);
            this.SubmitButton.TabIndex = 37;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(708, 789);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.ProvinceLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.streetAddressLine2Label);
            this.Controls.Add(this.streetAddressLabel);
            this.Controls.Add(this.CurrentAddressLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.provinceTextBox);
            this.Controls.Add(this.streetAddress2Box);
            this.Controls.Add(this.StreetAddress1Box);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.personalDetailsLabel);
            this.Controls.Add(this.phoneNumberbox);
            this.Controls.Add(this.LicenseNumberLabel);
            this.Controls.Add(this.IDNumberLabel);
            this.Controls.Add(this.licenseNumberTextbox);
            this.Controls.Add(this.idNumberTextbox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUpForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox surnameTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox idNumberTextbox;
        private System.Windows.Forms.TextBox licenseNumberTextbox;
        private System.Windows.Forms.Label IDNumberLabel;
        private System.Windows.Forms.Label LicenseNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberbox;
        private System.Windows.Forms.Label personalDetailsLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox StreetAddress1Box;
        private System.Windows.Forms.TextBox streetAddress2Box;
        private System.Windows.Forms.TextBox provinceTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label CurrentAddressLabel;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.Label streetAddressLine2Label;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}