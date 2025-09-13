namespace WindowsFormsApp1
{
    partial class UpdatePersonalInfo
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
            this.PersonalDetailsLabel = new System.Windows.Forms.Label();
            this.PhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.StreetAddress2TextBox = new System.Windows.Forms.TextBox();
            this.StreetAddressLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.ProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersonalDetailsLabel
            // 
            this.PersonalDetailsLabel.AutoSize = true;
            this.PersonalDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsLabel.Location = new System.Drawing.Point(19, 46);
            this.PersonalDetailsLabel.Name = "PersonalDetailsLabel";
            this.PersonalDetailsLabel.Size = new System.Drawing.Size(169, 25);
            this.PersonalDetailsLabel.TabIndex = 11;
            this.PersonalDetailsLabel.Text = "Personal Details";
            // 
            // PhoneNumTextBox
            // 
            this.PhoneNumTextBox.Location = new System.Drawing.Point(11, 115);
            this.PhoneNumTextBox.Name = "PhoneNumTextBox";
            this.PhoneNumTextBox.Size = new System.Drawing.Size(380, 26);
            this.PhoneNumTextBox.TabIndex = 16;
            this.PhoneNumTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(413, 115);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(388, 26);
            this.EmailTextBox.TabIndex = 17;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Phone Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "E - mail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Current Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // StreetAddressTextBox
            // 
            this.StreetAddressTextBox.Location = new System.Drawing.Point(9, 246);
            this.StreetAddressTextBox.Name = "StreetAddressTextBox";
            this.StreetAddressTextBox.Size = new System.Drawing.Size(790, 26);
            this.StreetAddressTextBox.TabIndex = 24;
            this.StreetAddressTextBox.TextChanged += new System.EventHandler(this.StreetAddressTextBox_TextChanged);
            // 
            // StreetAddress2TextBox
            // 
            this.StreetAddress2TextBox.Location = new System.Drawing.Point(12, 331);
            this.StreetAddress2TextBox.Name = "StreetAddress2TextBox";
            this.StreetAddress2TextBox.Size = new System.Drawing.Size(788, 26);
            this.StreetAddress2TextBox.TabIndex = 25;
            this.StreetAddress2TextBox.TextChanged += new System.EventHandler(this.StreetAddress2TextBox_TextChanged);
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Location = new System.Drawing.Point(9, 223);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.Size = new System.Drawing.Size(120, 20);
            this.StreetAddressLabel.TabIndex = 26;
            this.StreetAddressLabel.Text = "Street Address ";
            this.StreetAddressLabel.Click += new System.EventHandler(this.StreetAddressLabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Street Address Line 2";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(9, 395);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 20);
            this.CityLabel.TabIndex = 28;
            this.CityLabel.Text = "City";
            this.CityLabel.Click += new System.EventHandler(this.CityLabel_Click);
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(408, 395);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(69, 20);
            this.ProvinceLabel.TabIndex = 29;
            this.ProvinceLabel.Text = "Province";
            this.ProvinceLabel.Click += new System.EventHandler(this.ProvinceLabel_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(9, 420);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(380, 26);
            this.CityTextBox.TabIndex = 30;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // ProvinceComboBox
            // 
            this.ProvinceComboBox.FormattingEnabled = true;
            this.ProvinceComboBox.Items.AddRange(new object[] {
            "KwaZulu-Natal",
            "Gauteng",
            "Eastern Cape",
            "Western Cape",
            "Free-State",
            "Limpopo",
            "Northern Cape",
            "North West",
            "Mpumalanga"});
            this.ProvinceComboBox.Location = new System.Drawing.Point(411, 420);
            this.ProvinceComboBox.Name = "ProvinceComboBox";
            this.ProvinceComboBox.Size = new System.Drawing.Size(388, 28);
            this.ProvinceComboBox.TabIndex = 31;
            this.ProvinceComboBox.SelectedIndexChanged += new System.EventHandler(this.ProvinceComboBox_SelectedIndexChanged);
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(12, 505);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(146, 26);
            this.PostalCodeTextBox.TabIndex = 32;
            this.PostalCodeTextBox.TextChanged += new System.EventHandler(this.PostalCodeTextBox_TextChanged);
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(9, 480);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(121, 20);
            this.PostalCodeLabel.TabIndex = 33;
            this.PostalCodeLabel.Text = "Postal/Zip Code";
            this.PostalCodeLabel.Click += new System.EventHandler(this.PostalCodeLabel_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(263, 555);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(182, 42);
            this.SubmitButton.TabIndex = 34;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // UpdatePersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.ProvinceComboBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.ProvinceLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StreetAddressLabel);
            this.Controls.Add(this.StreetAddress2TextBox);
            this.Controls.Add(this.StreetAddressTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneNumTextBox);
            this.Controls.Add(this.PersonalDetailsLabel);
            this.Name = "UpdatePersonalInfo";
            this.Size = new System.Drawing.Size(820, 1109);
            this.Load += new System.EventHandler(this.UpdatePersonalInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PersonalDetailsLabel;
        private System.Windows.Forms.TextBox PhoneNumTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StreetAddressTextBox;
        private System.Windows.Forms.TextBox StreetAddress2TextBox;
        private System.Windows.Forms.Label StreetAddressLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.ComboBox ProvinceComboBox;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Button SubmitButton;
    }
}
