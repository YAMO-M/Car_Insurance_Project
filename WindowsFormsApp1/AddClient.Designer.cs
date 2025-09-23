namespace WindowsFormsApp1
{
    partial class AddClient
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
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.StreetAddressLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.ProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.CustomerLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.IDErrorLabel = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.MaskedTextBox();
            this.PostalCodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PhoneNumTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EmailErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonalDetailsLabel
            // 
            this.PersonalDetailsLabel.AutoSize = true;
            this.PersonalDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsLabel.Location = new System.Drawing.Point(67, 33);
            this.PersonalDetailsLabel.Name = "PersonalDetailsLabel";
            this.PersonalDetailsLabel.Size = new System.Drawing.Size(110, 20);
            this.PersonalDetailsLabel.TabIndex = 11;
            this.PersonalDetailsLabel.Text = "Client Details";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(427, 208);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(345, 22);
            this.EmailTextBox.TabIndex = 17;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "E - mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Current Address";
            // 
            // StreetAddressTextBox
            // 
            this.StreetAddressTextBox.Location = new System.Drawing.Point(68, 313);
            this.StreetAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StreetAddressTextBox.Name = "StreetAddressTextBox";
            this.StreetAddressTextBox.Size = new System.Drawing.Size(703, 22);
            this.StreetAddressTextBox.TabIndex = 24;
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Location = new System.Drawing.Point(68, 294);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.Size = new System.Drawing.Size(99, 16);
            this.StreetAddressLabel.TabIndex = 26;
            this.StreetAddressLabel.Text = "Street Address ";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(68, 356);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(29, 16);
            this.CityLabel.TabIndex = 28;
            this.CityLabel.Text = "City";
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(424, 356);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(60, 16);
            this.ProvinceLabel.TabIndex = 29;
            this.ProvinceLabel.Text = "Province";
            // 
            // ProvinceComboBox
            // 
            this.ProvinceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.ProvinceComboBox.Location = new System.Drawing.Point(425, 389);
            this.ProvinceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProvinceComboBox.Name = "ProvinceComboBox";
            this.ProvinceComboBox.Size = new System.Drawing.Size(345, 24);
            this.ProvinceComboBox.TabIndex = 31;
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(68, 434);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(104, 16);
            this.PostalCodeLabel.TabIndex = 33;
            this.PostalCodeLabel.Text = "Postal/Zip Code";
            // 
            // AddClientButton
            // 
            this.AddClientButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddClientButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AddClientButton.Location = new System.Drawing.Point(328, 510);
            this.AddClientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(161, 33);
            this.AddClientButton.TabIndex = 34;
            this.AddClientButton.Text = "Add Client";
            this.AddClientButton.UseVisualStyleBackColor = false;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.Location = new System.Drawing.Point(425, 84);
            this.CustomerLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Size = new System.Drawing.Size(345, 22);
            this.CustomerLastName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Last Name";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(68, 84);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(339, 22);
            this.CustomerName.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "ID";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(68, 389);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(339, 22);
            this.CityTextBox.TabIndex = 30;
            // 
            // IDErrorLabel
            // 
            this.IDErrorLabel.AutoSize = true;
            this.IDErrorLabel.Location = new System.Drawing.Point(433, 145);
            this.IDErrorLabel.Name = "IDErrorLabel";
            this.IDErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.IDErrorLabel.TabIndex = 41;
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(68, 145);
            this.CustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(340, 22);
            this.CustomerID.TabIndex = 42;
            this.CustomerID.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(72, 454);
            this.PostalCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(132, 22);
            this.PostalCodeTextBox.TabIndex = 43;
            // 
            // PhoneNumTextBox
            // 
            this.PhoneNumTextBox.Location = new System.Drawing.Point(68, 209);
            this.PhoneNumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneNumTextBox.Name = "PhoneNumTextBox";
            this.PhoneNumTextBox.Size = new System.Drawing.Size(339, 22);
            this.PhoneNumTextBox.TabIndex = 44;
            // 
            // EmailErrorLabel
            // 
            this.EmailErrorLabel.AutoSize = true;
            this.EmailErrorLabel.Location = new System.Drawing.Point(795, 213);
            this.EmailErrorLabel.Name = "EmailErrorLabel";
            this.EmailErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.EmailErrorLabel.TabIndex = 45;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmailErrorLabel);
            this.Controls.Add(this.PhoneNumTextBox);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.IDErrorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerLastName);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.PostalCodeLabel);
            this.Controls.Add(this.ProvinceComboBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.ProvinceLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StreetAddressLabel);
            this.Controls.Add(this.StreetAddressTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PersonalDetailsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddClient";
            this.Size = new System.Drawing.Size(1156, 671);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PersonalDetailsLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StreetAddressTextBox;
        private System.Windows.Forms.Label StreetAddressLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.ComboBox ProvinceComboBox;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.TextBox CustomerLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label IDErrorLabel;
        private System.Windows.Forms.MaskedTextBox CustomerID;
        private System.Windows.Forms.MaskedTextBox PostalCodeTextBox;
        private System.Windows.Forms.MaskedTextBox PhoneNumTextBox;
        private System.Windows.Forms.Label EmailErrorLabel;
    }
}
