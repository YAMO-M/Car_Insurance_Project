namespace WindowsFormsApp1
{
    partial class SignUpPersonalDetails
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
            this.Personal = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDNumbermaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IDNumberTextBox = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StreetAddress2TextBox = new System.Windows.Forms.TextBox();
            this.StreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.ProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.PostalCodemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Personal
            // 
            this.Personal.AutoSize = true;
            this.Personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personal.Location = new System.Drawing.Point(0, 25);
            this.Personal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(166, 25);
            this.Personal.TabIndex = 2;
            this.Personal.Text = "Personal Details";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(4, 94);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(391, 22);
            this.NameTextBox.TabIndex = 36;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // SurnameTextBox2
            // 
            this.SurnameTextBox2.Location = new System.Drawing.Point(419, 94);
            this.SurnameTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SurnameTextBox2.Name = "SurnameTextBox2";
            this.SurnameTextBox2.Size = new System.Drawing.Size(393, 22);
            this.SurnameTextBox2.TabIndex = 35;
            this.SurnameTextBox2.TextChanged += new System.EventHandler(this.SurnameTextBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Surname";
            // 
            // IDNumbermaskedTextBox
            // 
            this.IDNumbermaskedTextBox.Location = new System.Drawing.Point(4, 164);
            this.IDNumbermaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDNumbermaskedTextBox.Mask = "0000000000000";
            this.IDNumbermaskedTextBox.Name = "IDNumbermaskedTextBox";
            this.IDNumbermaskedTextBox.Size = new System.Drawing.Size(387, 22);
            this.IDNumbermaskedTextBox.TabIndex = 39;
            // 
            // IDNumberTextBox
            // 
            this.IDNumberTextBox.AutoSize = true;
            this.IDNumberTextBox.Location = new System.Drawing.Point(1, 143);
            this.IDNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDNumberTextBox.Name = "IDNumberTextBox";
            this.IDNumberTextBox.Size = new System.Drawing.Size(71, 16);
            this.IDNumberTextBox.TabIndex = 41;
            this.IDNumberTextBox.Text = "lD Number";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(417, 143);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(97, 16);
            this.label.TabIndex = 42;
            this.label.Text = "Phone Number";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(4, 244);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(0, 16);
            this.PhoneNumberLabel.TabIndex = 43;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(420, 164);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneNumberTextBox.Mask = "(999) 000-0000";
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(383, 22);
            this.PhoneNumberTextBox.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Street Address Line 2";
            // 
            // StreetAddress2TextBox
            // 
            this.StreetAddress2TextBox.Location = new System.Drawing.Point(7, 310);
            this.StreetAddress2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StreetAddress2TextBox.Name = "StreetAddress2TextBox";
            this.StreetAddress2TextBox.Size = new System.Drawing.Size(796, 22);
            this.StreetAddress2TextBox.TabIndex = 47;
            // 
            // StreetAddressTextBox
            // 
            this.StreetAddressTextBox.Location = new System.Drawing.Point(7, 244);
            this.StreetAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StreetAddressTextBox.Name = "StreetAddressTextBox";
            this.StreetAddressTextBox.Size = new System.Drawing.Size(796, 22);
            this.StreetAddressTextBox.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 356);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Province";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Street Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 356);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(7, 376);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(387, 22);
            this.CityTextBox.TabIndex = 52;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // ProvinceComboBox
            // 
            this.ProvinceComboBox.FormattingEnabled = true;
            this.ProvinceComboBox.Items.AddRange(new object[] {
            "KwaZulu-Natal ",
            "Eastern Cape",
            "Gauteng",
            "Free State",
            "Limpopo",
            "Mpumalanga",
            "Northern Cape",
            "North West",
            "Western Cape"});
            this.ProvinceComboBox.Location = new System.Drawing.Point(419, 376);
            this.ProvinceComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProvinceComboBox.Name = "ProvinceComboBox";
            this.ProvinceComboBox.Size = new System.Drawing.Size(383, 24);
            this.ProvinceComboBox.TabIndex = 53;
            // 
            // PostalCodemaskedTextBox
            // 
            this.PostalCodemaskedTextBox.Location = new System.Drawing.Point(4, 444);
            this.PostalCodemaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PostalCodemaskedTextBox.Mask = "0000";
            this.PostalCodemaskedTextBox.Name = "PostalCodemaskedTextBox";
            this.PostalCodemaskedTextBox.Size = new System.Drawing.Size(139, 22);
            this.PostalCodemaskedTextBox.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 424);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Postal/Zip Code";
            // 
            // SignUpPersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PostalCodemaskedTextBox);
            this.Controls.Add(this.ProvinceComboBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StreetAddressTextBox);
            this.Controls.Add(this.StreetAddress2TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.IDNumberTextBox);
            this.Controls.Add(this.IDNumbermaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameTextBox2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Personal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignUpPersonalDetails";
            this.Size = new System.Drawing.Size(896, 857);
            this.Load += new System.EventHandler(this.SignUpPersonalDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Personal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDNumberTextBox;
    
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.TextBox SurnameTextBox2;
        public System.Windows.Forms.MaskedTextBox IDNumbermaskedTextBox;
        public System.Windows.Forms.MaskedTextBox PhoneNumberTextBox;
        public System.Windows.Forms.TextBox StreetAddress2TextBox;
        public System.Windows.Forms.TextBox StreetAddressTextBox;
        public System.Windows.Forms.TextBox CityTextBox;
        public System.Windows.Forms.ComboBox ProvinceComboBox;
        public System.Windows.Forms.MaskedTextBox PostalCodemaskedTextBox;
    }
}
