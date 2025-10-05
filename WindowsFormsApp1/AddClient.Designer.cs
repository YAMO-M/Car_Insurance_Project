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
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonalDetailsLabel
            // 
            this.PersonalDetailsLabel.AutoSize = true;
            this.PersonalDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsLabel.Location = new System.Drawing.Point(401, 113);
            this.PersonalDetailsLabel.Name = "PersonalDetailsLabel";
            this.PersonalDetailsLabel.Size = new System.Drawing.Size(139, 25);
            this.PersonalDetailsLabel.TabIndex = 11;
            this.PersonalDetailsLabel.Text = "Client Details";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(806, 332);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(388, 26);
            this.EmailTextBox.TabIndex = 17;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Phone No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(803, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // StreetAddressTextBox
            // 
            this.StreetAddressTextBox.Location = new System.Drawing.Point(406, 429);
            this.StreetAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StreetAddressTextBox.Name = "StreetAddressTextBox";
            this.StreetAddressTextBox.Size = new System.Drawing.Size(377, 26);
            this.StreetAddressTextBox.TabIndex = 24;
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Location = new System.Drawing.Point(403, 384);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.Size = new System.Drawing.Size(120, 20);
            this.StreetAddressLabel.TabIndex = 26;
            this.StreetAddressLabel.Text = "Street Address ";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(403, 483);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 20);
            this.CityLabel.TabIndex = 28;
            this.CityLabel.Text = "City";
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(803, 483);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(69, 20);
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
            this.ProvinceComboBox.Location = new System.Drawing.Point(807, 505);
            this.ProvinceComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProvinceComboBox.Name = "ProvinceComboBox";
            this.ProvinceComboBox.Size = new System.Drawing.Size(388, 28);
            this.ProvinceComboBox.TabIndex = 31;
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(402, 552);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(121, 20);
            this.PostalCodeLabel.TabIndex = 33;
            this.PostalCodeLabel.Text = "Postal/Zip Code";
            // 
            // AddClientButton
            // 
            this.AddClientButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddClientButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AddClientButton.Location = new System.Drawing.Point(670, 714);
            this.AddClientButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(181, 41);
            this.AddClientButton.TabIndex = 34;
            this.AddClientButton.Text = "Add Client";
            this.AddClientButton.UseVisualStyleBackColor = false;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // CustomerLastName
            // 
            this.CustomerLastName.Location = new System.Drawing.Point(804, 177);
            this.CustomerLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerLastName.Name = "CustomerLastName";
            this.CustomerLastName.Size = new System.Drawing.Size(388, 26);
            this.CustomerLastName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(802, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Last Name";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(402, 177);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(381, 26);
            this.CustomerName.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Identity No.";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(402, 505);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(381, 26);
            this.CityTextBox.TabIndex = 30;
            // 
            // IDErrorLabel
            // 
            this.IDErrorLabel.AutoSize = true;
            this.IDErrorLabel.Location = new System.Drawing.Point(813, 253);
            this.IDErrorLabel.Name = "IDErrorLabel";
            this.IDErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.IDErrorLabel.TabIndex = 41;
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(402, 253);
            this.CustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerID.Mask = "0000000000000";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.PromptChar = ' ';
            this.CustomerID.Size = new System.Drawing.Size(382, 26);
            this.CustomerID.TabIndex = 42;
            this.CustomerID.ValidatingType = typeof(int);
            this.CustomerID.Click += new System.EventHandler(this.CustomerID_Click);
            this.CustomerID.TextChanged += new System.EventHandler(this.CustomerID_TextChanged);
            this.CustomerID.Enter += new System.EventHandler(this.CustomerID_Enter);
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(407, 577);
            this.PostalCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostalCodeTextBox.Mask = "0000";
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.PromptChar = ' ';
            this.PostalCodeTextBox.Size = new System.Drawing.Size(148, 26);
            this.PostalCodeTextBox.TabIndex = 43;
            this.PostalCodeTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.PostalCodeTextBox_MaskInputRejected);
            this.PostalCodeTextBox.Click += new System.EventHandler(this.PostalCodeTextBox_Click);
            this.PostalCodeTextBox.Enter += new System.EventHandler(this.PostalCodeTextBox_Enter);
            // 
            // PhoneNumTextBox
            // 
            this.PhoneNumTextBox.Location = new System.Drawing.Point(402, 333);
            this.PhoneNumTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumTextBox.Mask = "999-000-0000";
            this.PhoneNumTextBox.Name = "PhoneNumTextBox";
            this.PhoneNumTextBox.PromptChar = ' ';
            this.PhoneNumTextBox.Size = new System.Drawing.Size(381, 26);
            this.PhoneNumTextBox.TabIndex = 44;
            this.PhoneNumTextBox.Click += new System.EventHandler(this.PhoneNumTextBox_Click);
            // 
            // EmailErrorLabel
            // 
            this.EmailErrorLabel.AutoSize = true;
            this.EmailErrorLabel.Location = new System.Drawing.Point(1225, 291);
            this.EmailErrorLabel.Name = "EmailErrorLabel";
            this.EmailErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.EmailErrorLabel.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(620, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 32);
            this.label5.TabIndex = 65;
            this.label5.Text = "ADD CLIENT";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PersonalDetailsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddClient";
            this.Size = new System.Drawing.Size(1395, 839);
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PersonalDetailsLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label5;
    }
}
