namespace WindowsFormsApp1
{
    partial class MakeClaim
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.PolicyNumberLabel = new System.Windows.Forms.Label();
            this.PolicyNumTextBox = new System.Windows.Forms.TextBox();
            this.DriverLicenseLabel = new System.Windows.Forms.Label();
            this.DriverLicenseTextBox = new System.Windows.Forms.TextBox();
            this.IncidentDetailsLabel = new System.Windows.Forms.Label();
            this.TypeOfClaimComboBox = new System.Windows.Forms.ComboBox();
            this.TypeOfClaimLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateAndTimeLabel = new System.Windows.Forms.Label();
            this.LocationOfTheIncidentLabel = new System.Windows.Forms.Label();
            this.StreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.StreetAddressLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.ProvinceComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CaseNumberTextBox = new System.Windows.Forms.TextBox();
            this.CaseNumberLabel = new System.Windows.Forms.Label();
            this.PayoutMethodLabel = new System.Windows.Forms.Label();
            this.PayoutMethodComboBox = new System.Windows.Forms.ComboBox();
            this.ClaimButton = new System.Windows.Forms.Button();
            this.VINlabel = new System.Windows.Forms.Label();
            this.VINtextBox = new System.Windows.Forms.TextBox();
            this.LicensePlateTextBox = new System.Windows.Forms.TextBox();
            this.LicensePlateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(10, 107);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(48, 18);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(13, 126);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(291, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.Location = new System.Drawing.Point(322, 107);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(68, 18);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Surname";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(325, 126);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(305, 22);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // PolicyNumberLabel
            // 
            this.PolicyNumberLabel.AutoSize = true;
            this.PolicyNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolicyNumberLabel.Location = new System.Drawing.Point(14, 175);
            this.PolicyNumberLabel.Name = "PolicyNumberLabel";
            this.PolicyNumberLabel.Size = new System.Drawing.Size(105, 18);
            this.PolicyNumberLabel.TabIndex = 4;
            this.PolicyNumberLabel.Text = "Policy Number";
            // 
            // PolicyNumTextBox
            // 
            this.PolicyNumTextBox.Location = new System.Drawing.Point(13, 194);
            this.PolicyNumTextBox.Name = "PolicyNumTextBox";
            this.PolicyNumTextBox.Size = new System.Drawing.Size(291, 22);
            this.PolicyNumTextBox.TabIndex = 5;
            // 
            // DriverLicenseLabel
            // 
            this.DriverLicenseLabel.AutoSize = true;
            this.DriverLicenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverLicenseLabel.Location = new System.Drawing.Point(313, 175);
            this.DriverLicenseLabel.Name = "DriverLicenseLabel";
            this.DriverLicenseLabel.Size = new System.Drawing.Size(170, 18);
            this.DriverLicenseLabel.TabIndex = 6;
            this.DriverLicenseLabel.Text = "Driver\'s License Number";
            // 
            // DriverLicenseTextBox
            // 
            this.DriverLicenseTextBox.Location = new System.Drawing.Point(316, 196);
            this.DriverLicenseTextBox.Name = "DriverLicenseTextBox";
            this.DriverLicenseTextBox.Size = new System.Drawing.Size(305, 22);
            this.DriverLicenseTextBox.TabIndex = 7;
            // 
            // IncidentDetailsLabel
            // 
            this.IncidentDetailsLabel.AutoSize = true;
            this.IncidentDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncidentDetailsLabel.Location = new System.Drawing.Point(13, 339);
            this.IncidentDetailsLabel.Name = "IncidentDetailsLabel";
            this.IncidentDetailsLabel.Size = new System.Drawing.Size(125, 20);
            this.IncidentDetailsLabel.TabIndex = 8;
            this.IncidentDetailsLabel.Text = "Incident Details";
            // 
            // TypeOfClaimComboBox
            // 
            this.TypeOfClaimComboBox.FormattingEnabled = true;
            this.TypeOfClaimComboBox.Items.AddRange(new object[] {
            "Accident",
            "Theft",
            "Fire",
            "Natural Disaster",
            "Vandalism",
            "Windshield"});
            this.TypeOfClaimComboBox.Location = new System.Drawing.Point(18, 399);
            this.TypeOfClaimComboBox.Name = "TypeOfClaimComboBox";
            this.TypeOfClaimComboBox.Size = new System.Drawing.Size(286, 24);
            this.TypeOfClaimComboBox.TabIndex = 9;
            // 
            // TypeOfClaimLabel
            // 
            this.TypeOfClaimLabel.AutoSize = true;
            this.TypeOfClaimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfClaimLabel.Location = new System.Drawing.Point(15, 378);
            this.TypeOfClaimLabel.Name = "TypeOfClaimLabel";
            this.TypeOfClaimLabel.Size = new System.Drawing.Size(102, 18);
            this.TypeOfClaimLabel.TabIndex = 10;
            this.TypeOfClaimLabel.Text = "Type Of Claim";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(325, 397);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(264, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // DateAndTimeLabel
            // 
            this.DateAndTimeLabel.AutoSize = true;
            this.DateAndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAndTimeLabel.Location = new System.Drawing.Point(322, 376);
            this.DateAndTimeLabel.Name = "DateAndTimeLabel";
            this.DateAndTimeLabel.Size = new System.Drawing.Size(175, 18);
            this.DateAndTimeLabel.TabIndex = 12;
            this.DateAndTimeLabel.Text = "Date and Time of Incident";
            // 
            // LocationOfTheIncidentLabel
            // 
            this.LocationOfTheIncidentLabel.AutoSize = true;
            this.LocationOfTheIncidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationOfTheIncidentLabel.Location = new System.Drawing.Point(13, 459);
            this.LocationOfTheIncidentLabel.Name = "LocationOfTheIncidentLabel";
            this.LocationOfTheIncidentLabel.Size = new System.Drawing.Size(183, 20);
            this.LocationOfTheIncidentLabel.TabIndex = 13;
            this.LocationOfTheIncidentLabel.Text = "Location of the Incident";
            // 
            // StreetAddressTextBox
            // 
            this.StreetAddressTextBox.Location = new System.Drawing.Point(13, 535);
            this.StreetAddressTextBox.Name = "StreetAddressTextBox";
            this.StreetAddressTextBox.Size = new System.Drawing.Size(576, 22);
            this.StreetAddressTextBox.TabIndex = 14;
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetAddressLabel.Location = new System.Drawing.Point(14, 505);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.Size = new System.Drawing.Size(105, 18);
            this.StreetAddressLabel.TabIndex = 15;
            this.StreetAddressLabel.Text = "Street Address";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(10, 576);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(33, 18);
            this.CityLabel.TabIndex = 16;
            this.CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(13, 597);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(291, 22);
            this.CityTextBox.TabIndex = 17;
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(322, 578);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(60, 16);
            this.ProvinceLabel.TabIndex = 18;
            this.ProvinceLabel.Text = "Province";
            // 
            // ProvinceComboBox
            // 
            this.ProvinceComboBox.FormattingEnabled = true;
            this.ProvinceComboBox.Items.AddRange(new object[] {
            "KwaZulu-Natal",
            "Mpumalanga",
            "Gauteng",
            "Free-State",
            "Eastern Cape",
            "Western Cape",
            "North West",
            "Limpopo",
            "Northern Cape"});
            this.ProvinceComboBox.Location = new System.Drawing.Point(325, 595);
            this.ProvinceComboBox.Name = "ProvinceComboBox";
            this.ProvinceComboBox.Size = new System.Drawing.Size(277, 24);
            this.ProvinceComboBox.TabIndex = 19;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(10, 650);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(186, 18);
            this.DescriptionLabel.TabIndex = 20;
            this.DescriptionLabel.Text = "Description Of The Incident";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(4, 671);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(617, 63);
            this.DescriptionRichTextBox.TabIndex = 21;
            this.DescriptionRichTextBox.Text = "";
            // 
            // CaseNumberTextBox
            // 
            this.CaseNumberTextBox.Location = new System.Drawing.Point(13, 783);
            this.CaseNumberTextBox.Name = "CaseNumberTextBox";
            this.CaseNumberTextBox.Size = new System.Drawing.Size(291, 22);
            this.CaseNumberTextBox.TabIndex = 23;
            // 
            // CaseNumberLabel
            // 
            this.CaseNumberLabel.AutoSize = true;
            this.CaseNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseNumberLabel.Location = new System.Drawing.Point(10, 762);
            this.CaseNumberLabel.Name = "CaseNumberLabel";
            this.CaseNumberLabel.Size = new System.Drawing.Size(186, 18);
            this.CaseNumberLabel.TabIndex = 24;
            this.CaseNumberLabel.Text = "Case Number(if applicable)";
            // 
            // PayoutMethodLabel
            // 
            this.PayoutMethodLabel.AutoSize = true;
            this.PayoutMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayoutMethodLabel.Location = new System.Drawing.Point(322, 760);
            this.PayoutMethodLabel.Name = "PayoutMethodLabel";
            this.PayoutMethodLabel.Size = new System.Drawing.Size(108, 18);
            this.PayoutMethodLabel.TabIndex = 25;
            this.PayoutMethodLabel.Text = "Payout Method";
            // 
            // PayoutMethodComboBox
            // 
            this.PayoutMethodComboBox.FormattingEnabled = true;
            this.PayoutMethodComboBox.Items.AddRange(new object[] {
            "Bank Transfer",
            "Cheque"});
            this.PayoutMethodComboBox.Location = new System.Drawing.Point(325, 781);
            this.PayoutMethodComboBox.Name = "PayoutMethodComboBox";
            this.PayoutMethodComboBox.Size = new System.Drawing.Size(277, 24);
            this.PayoutMethodComboBox.TabIndex = 26;
            // 
            // ClaimButton
            // 
            this.ClaimButton.Location = new System.Drawing.Point(236, 871);
            this.ClaimButton.Name = "ClaimButton";
            this.ClaimButton.Size = new System.Drawing.Size(182, 37);
            this.ClaimButton.TabIndex = 27;
            this.ClaimButton.Text = "Claim";
            this.ClaimButton.UseVisualStyleBackColor = true;
            // 
            // VINlabel
            // 
            this.VINlabel.AutoSize = true;
            this.VINlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VINlabel.Location = new System.Drawing.Point(10, 246);
            this.VINlabel.Name = "VINlabel";
            this.VINlabel.Size = new System.Drawing.Size(197, 18);
            this.VINlabel.TabIndex = 28;
            this.VINlabel.Text = "Vehicle Identification Number";
            // 
            // VINtextBox
            // 
            this.VINtextBox.Location = new System.Drawing.Point(13, 265);
            this.VINtextBox.Name = "VINtextBox";
            this.VINtextBox.Size = new System.Drawing.Size(291, 22);
            this.VINtextBox.TabIndex = 29;
            // 
            // LicensePlateTextBox
            // 
            this.LicensePlateTextBox.Location = new System.Drawing.Point(316, 265);
            this.LicensePlateTextBox.Name = "LicensePlateTextBox";
            this.LicensePlateTextBox.Size = new System.Drawing.Size(305, 22);
            this.LicensePlateTextBox.TabIndex = 30;
            // 
            // LicensePlateLabel
            // 
            this.LicensePlateLabel.AutoSize = true;
            this.LicensePlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicensePlateLabel.Location = new System.Drawing.Point(313, 246);
            this.LicensePlateLabel.Name = "LicensePlateLabel";
            this.LicensePlateLabel.Size = new System.Drawing.Size(96, 18);
            this.LicensePlateLabel.TabIndex = 31;
            this.LicensePlateLabel.Text = "License Plate";
            // 
            // MakeClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LicensePlateLabel);
            this.Controls.Add(this.LicensePlateTextBox);
            this.Controls.Add(this.VINtextBox);
            this.Controls.Add(this.VINlabel);
            this.Controls.Add(this.ClaimButton);
            this.Controls.Add(this.PayoutMethodComboBox);
            this.Controls.Add(this.PayoutMethodLabel);
            this.Controls.Add(this.CaseNumberLabel);
            this.Controls.Add(this.CaseNumberTextBox);
            this.Controls.Add(this.DescriptionRichTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ProvinceComboBox);
            this.Controls.Add(this.ProvinceLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StreetAddressLabel);
            this.Controls.Add(this.StreetAddressTextBox);
            this.Controls.Add(this.LocationOfTheIncidentLabel);
            this.Controls.Add(this.DateAndTimeLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TypeOfClaimLabel);
            this.Controls.Add(this.TypeOfClaimComboBox);
            this.Controls.Add(this.IncidentDetailsLabel);
            this.Controls.Add(this.DriverLicenseTextBox);
            this.Controls.Add(this.DriverLicenseLabel);
            this.Controls.Add(this.PolicyNumTextBox);
            this.Controls.Add(this.PolicyNumberLabel);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "MakeClaim";
            this.Size = new System.Drawing.Size(680, 937);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label PolicyNumberLabel;
        private System.Windows.Forms.TextBox PolicyNumTextBox;
        private System.Windows.Forms.Label DriverLicenseLabel;
        private System.Windows.Forms.TextBox DriverLicenseTextBox;
        private System.Windows.Forms.Label IncidentDetailsLabel;
        private System.Windows.Forms.ComboBox TypeOfClaimComboBox;
        private System.Windows.Forms.Label TypeOfClaimLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateAndTimeLabel;
        private System.Windows.Forms.Label LocationOfTheIncidentLabel;
        private System.Windows.Forms.TextBox StreetAddressTextBox;
        private System.Windows.Forms.Label StreetAddressLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.ComboBox ProvinceComboBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.TextBox CaseNumberTextBox;
        private System.Windows.Forms.Label CaseNumberLabel;
        private System.Windows.Forms.Label PayoutMethodLabel;
        private System.Windows.Forms.ComboBox PayoutMethodComboBox;
        private System.Windows.Forms.Button ClaimButton;
        private System.Windows.Forms.Label VINlabel;
        private System.Windows.Forms.TextBox VINtextBox;
        private System.Windows.Forms.TextBox LicensePlateTextBox;
        private System.Windows.Forms.Label LicensePlateLabel;
    }
}
