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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDNumbermaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IDNumberTextBox = new System.Windows.Forms.Label();
            this.dataSet11 = new WindowsFormsApp1.DataSet1();
            this.label = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Personal Details";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(3, 89);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(294, 20);
            this.NameTextBox.TabIndex = 36;
            // 
            // SurnameTextBox2
            // 
            this.SurnameTextBox2.Location = new System.Drawing.Point(316, 89);
            this.SurnameTextBox2.Name = "SurnameTextBox2";
            this.SurnameTextBox2.Size = new System.Drawing.Size(296, 20);
            this.SurnameTextBox2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Surname";
            // 
            // IDNumbermaskedTextBox
            // 
            this.IDNumbermaskedTextBox.Location = new System.Drawing.Point(6, 149);
            this.IDNumbermaskedTextBox.Name = "IDNumbermaskedTextBox";
            this.IDNumbermaskedTextBox.Size = new System.Drawing.Size(291, 20);
            this.IDNumbermaskedTextBox.TabIndex = 39;
            // 
            // IDNumberTextBox
            // 
            this.IDNumberTextBox.AutoSize = true;
            this.IDNumberTextBox.Location = new System.Drawing.Point(3, 133);
            this.IDNumberTextBox.Name = "IDNumberTextBox";
            this.IDNumberTextBox.Size = new System.Drawing.Size(57, 13);
            this.IDNumberTextBox.TabIndex = 41;
            this.IDNumberTextBox.Text = "lD Number";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(313, 133);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(78, 13);
            this.label.TabIndex = 42;
            this.label.Text = "Phone Number";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(3, 198);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(0, 13);
            this.PhoneNumberLabel.TabIndex = 43;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(316, 149);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(288, 20);
            this.PhoneNumberTextBox.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Current Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Street Address Line 2";
            // 
            // StreetAddress2TextBox
            // 
            this.StreetAddress2TextBox.Location = new System.Drawing.Point(6, 303);
            this.StreetAddress2TextBox.Name = "StreetAddress2TextBox";
            this.StreetAddress2TextBox.Size = new System.Drawing.Size(598, 20);
            this.StreetAddress2TextBox.TabIndex = 47;
            // 
            // StreetAddressTextBox
            // 
            this.StreetAddressTextBox.Location = new System.Drawing.Point(6, 243);
            this.StreetAddressTextBox.Name = "StreetAddressTextBox";
            this.StreetAddressTextBox.Size = new System.Drawing.Size(598, 20);
            this.StreetAddressTextBox.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Province";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Street Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(6, 366);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(291, 20);
            this.CityTextBox.TabIndex = 52;
            // 
            // ProvinceComboBox
            // 
            this.ProvinceComboBox.FormattingEnabled = true;
            this.ProvinceComboBox.Location = new System.Drawing.Point(316, 366);
            this.ProvinceComboBox.Name = "ProvinceComboBox";
            this.ProvinceComboBox.Size = new System.Drawing.Size(288, 21);
            this.ProvinceComboBox.TabIndex = 53;
            // 
            // PostalCodemaskedTextBox
            // 
            this.PostalCodemaskedTextBox.Location = new System.Drawing.Point(6, 441);
            this.PostalCodemaskedTextBox.Name = "PostalCodemaskedTextBox";
            this.PostalCodemaskedTextBox.Size = new System.Drawing.Size(105, 20);
            this.PostalCodemaskedTextBox.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Postal/Zip Code";
            // 
            // SignUpPersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.IDNumberTextBox);
            this.Controls.Add(this.IDNumbermaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameTextBox2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SignUpPersonalDetails";
            this.Size = new System.Drawing.Size(672, 696);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox IDNumbermaskedTextBox;
        private System.Windows.Forms.Label IDNumberTextBox;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.MaskedTextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StreetAddress2TextBox;
        private System.Windows.Forms.TextBox StreetAddressTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.ComboBox ProvinceComboBox;
        private System.Windows.Forms.MaskedTextBox PostalCodemaskedTextBox;
        private System.Windows.Forms.Label label9;
    }
}
