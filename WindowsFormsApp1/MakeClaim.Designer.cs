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
            this.ClaimAmountLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(30, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(57, 22);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(34, 52);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(327, 26);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.Location = new System.Drawing.Point(381, 28);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(82, 22);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Surname";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(385, 52);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(343, 26);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // PolicyNumberLabel
            // 
            this.PolicyNumberLabel.AutoSize = true;
            this.PolicyNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolicyNumberLabel.Location = new System.Drawing.Point(35, 113);
            this.PolicyNumberLabel.Name = "PolicyNumberLabel";
            this.PolicyNumberLabel.Size = new System.Drawing.Size(126, 22);
            this.PolicyNumberLabel.TabIndex = 4;
            this.PolicyNumberLabel.Text = "Policy Number";
            // 
            // PolicyNumTextBox
            // 
            this.PolicyNumTextBox.Location = new System.Drawing.Point(34, 136);
            this.PolicyNumTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PolicyNumTextBox.Name = "PolicyNumTextBox";
            this.PolicyNumTextBox.Size = new System.Drawing.Size(327, 26);
            this.PolicyNumTextBox.TabIndex = 5;
            // 
            // DriverLicenseLabel
            // 
            this.DriverLicenseLabel.AutoSize = true;
            this.DriverLicenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverLicenseLabel.Location = new System.Drawing.Point(371, 113);
            this.DriverLicenseLabel.Name = "DriverLicenseLabel";
            this.DriverLicenseLabel.Size = new System.Drawing.Size(206, 22);
            this.DriverLicenseLabel.TabIndex = 6;
            this.DriverLicenseLabel.Text = "Driver\'s License Number";
            // 
            // DriverLicenseTextBox
            // 
            this.DriverLicenseTextBox.Location = new System.Drawing.Point(375, 139);
            this.DriverLicenseTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DriverLicenseTextBox.Name = "DriverLicenseTextBox";
            this.DriverLicenseTextBox.Size = new System.Drawing.Size(343, 26);
            this.DriverLicenseTextBox.TabIndex = 7;
            // 
            // IncidentDetailsLabel
            // 
            this.IncidentDetailsLabel.AutoSize = true;
            this.IncidentDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncidentDetailsLabel.Location = new System.Drawing.Point(34, 318);
            this.IncidentDetailsLabel.Name = "IncidentDetailsLabel";
            this.IncidentDetailsLabel.Size = new System.Drawing.Size(159, 25);
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
            this.TypeOfClaimComboBox.Location = new System.Drawing.Point(39, 393);
            this.TypeOfClaimComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TypeOfClaimComboBox.Name = "TypeOfClaimComboBox";
            this.TypeOfClaimComboBox.Size = new System.Drawing.Size(321, 28);
            this.TypeOfClaimComboBox.TabIndex = 9;
            // 
            // TypeOfClaimLabel
            // 
            this.TypeOfClaimLabel.AutoSize = true;
            this.TypeOfClaimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfClaimLabel.Location = new System.Drawing.Point(36, 366);
            this.TypeOfClaimLabel.Name = "TypeOfClaimLabel";
            this.TypeOfClaimLabel.Size = new System.Drawing.Size(125, 22);
            this.TypeOfClaimLabel.TabIndex = 10;
            this.TypeOfClaimLabel.Text = "Type Of Claim";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 390);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // DateAndTimeLabel
            // 
            this.DateAndTimeLabel.AutoSize = true;
            this.DateAndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAndTimeLabel.Location = new System.Drawing.Point(381, 364);
            this.DateAndTimeLabel.Name = "DateAndTimeLabel";
            this.DateAndTimeLabel.Size = new System.Drawing.Size(135, 22);
            this.DateAndTimeLabel.TabIndex = 12;
            this.DateAndTimeLabel.Text = "Date of Incident";
            // 
            // LocationOfTheIncidentLabel
            // 
            this.LocationOfTheIncidentLabel.AutoSize = true;
            this.LocationOfTheIncidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationOfTheIncidentLabel.Location = new System.Drawing.Point(34, 442);
            this.LocationOfTheIncidentLabel.Name = "LocationOfTheIncidentLabel";
            this.LocationOfTheIncidentLabel.Size = new System.Drawing.Size(235, 25);
            this.LocationOfTheIncidentLabel.TabIndex = 13;
            this.LocationOfTheIncidentLabel.Text = "Location of the Incident";
            // 
            // StreetAddressTextBox
            // 
            this.StreetAddressTextBox.Location = new System.Drawing.Point(33, 505);
            this.StreetAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StreetAddressTextBox.Name = "StreetAddressTextBox";
            this.StreetAddressTextBox.Size = new System.Drawing.Size(648, 26);
            this.StreetAddressTextBox.TabIndex = 14;
            // 
            // StreetAddressLabel
            // 
            this.StreetAddressLabel.AutoSize = true;
            this.StreetAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetAddressLabel.Location = new System.Drawing.Point(35, 479);
            this.StreetAddressLabel.Name = "StreetAddressLabel";
            this.StreetAddressLabel.Size = new System.Drawing.Size(129, 22);
            this.StreetAddressLabel.TabIndex = 15;
            this.StreetAddressLabel.Text = "Street Address";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(30, 545);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(41, 22);
            this.CityLabel.TabIndex = 16;
            this.CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(33, 571);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(327, 26);
            this.CityTextBox.TabIndex = 17;
            // 
            // ProvinceLabel
            // 
            this.ProvinceLabel.AutoSize = true;
            this.ProvinceLabel.Location = new System.Drawing.Point(381, 547);
            this.ProvinceLabel.Name = "ProvinceLabel";
            this.ProvinceLabel.Size = new System.Drawing.Size(69, 20);
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
            this.ProvinceComboBox.Location = new System.Drawing.Point(385, 571);
            this.ProvinceComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProvinceComboBox.Name = "ProvinceComboBox";
            this.ProvinceComboBox.Size = new System.Drawing.Size(311, 28);
            this.ProvinceComboBox.TabIndex = 19;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(29, 617);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(228, 22);
            this.DescriptionLabel.TabIndex = 20;
            this.DescriptionLabel.Text = "Description Of The Incident";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(24, 652);
            this.DescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(694, 78);
            this.DescriptionRichTextBox.TabIndex = 21;
            this.DescriptionRichTextBox.Text = "";
            // 
            // CaseNumberTextBox
            // 
            this.CaseNumberTextBox.Location = new System.Drawing.Point(24, 792);
            this.CaseNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CaseNumberTextBox.Name = "CaseNumberTextBox";
            this.CaseNumberTextBox.Size = new System.Drawing.Size(327, 26);
            this.CaseNumberTextBox.TabIndex = 23;
            // 
            // CaseNumberLabel
            // 
            this.CaseNumberLabel.AutoSize = true;
            this.CaseNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseNumberLabel.Location = new System.Drawing.Point(20, 753);
            this.CaseNumberLabel.Name = "CaseNumberLabel";
            this.CaseNumberLabel.Size = new System.Drawing.Size(227, 22);
            this.CaseNumberLabel.TabIndex = 24;
            this.CaseNumberLabel.Text = "Case Number(if applicable)";
            // 
            // PayoutMethodLabel
            // 
            this.PayoutMethodLabel.AutoSize = true;
            this.PayoutMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayoutMethodLabel.Location = new System.Drawing.Point(386, 753);
            this.PayoutMethodLabel.Name = "PayoutMethodLabel";
            this.PayoutMethodLabel.Size = new System.Drawing.Size(130, 22);
            this.PayoutMethodLabel.TabIndex = 25;
            this.PayoutMethodLabel.Text = "Payout Method";
            // 
            // PayoutMethodComboBox
            // 
            this.PayoutMethodComboBox.FormattingEnabled = true;
            this.PayoutMethodComboBox.Items.AddRange(new object[] {
            "Bank Transfer",
            "Cheque"});
            this.PayoutMethodComboBox.Location = new System.Drawing.Point(385, 792);
            this.PayoutMethodComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PayoutMethodComboBox.Name = "PayoutMethodComboBox";
            this.PayoutMethodComboBox.Size = new System.Drawing.Size(311, 28);
            this.PayoutMethodComboBox.TabIndex = 26;
            // 
            // ClaimButton
            // 
            this.ClaimButton.Location = new System.Drawing.Point(258, 919);
            this.ClaimButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClaimButton.Name = "ClaimButton";
            this.ClaimButton.Size = new System.Drawing.Size(205, 46);
            this.ClaimButton.TabIndex = 27;
            this.ClaimButton.Text = "Claim";
            this.ClaimButton.UseVisualStyleBackColor = true;
            // 
            // VINlabel
            // 
            this.VINlabel.AutoSize = true;
            this.VINlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VINlabel.Location = new System.Drawing.Point(30, 202);
            this.VINlabel.Name = "VINlabel";
            this.VINlabel.Size = new System.Drawing.Size(242, 22);
            this.VINlabel.TabIndex = 28;
            this.VINlabel.Text = "Vehicle Identification Number";
            // 
            // VINtextBox
            // 
            this.VINtextBox.Location = new System.Drawing.Point(34, 225);
            this.VINtextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VINtextBox.Name = "VINtextBox";
            this.VINtextBox.Size = new System.Drawing.Size(327, 26);
            this.VINtextBox.TabIndex = 29;
            // 
            // LicensePlateTextBox
            // 
            this.LicensePlateTextBox.Location = new System.Drawing.Point(375, 225);
            this.LicensePlateTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LicensePlateTextBox.Name = "LicensePlateTextBox";
            this.LicensePlateTextBox.Size = new System.Drawing.Size(343, 26);
            this.LicensePlateTextBox.TabIndex = 30;
            // 
            // LicensePlateLabel
            // 
            this.LicensePlateLabel.AutoSize = true;
            this.LicensePlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicensePlateLabel.Location = new System.Drawing.Point(371, 202);
            this.LicensePlateLabel.Name = "LicensePlateLabel";
            this.LicensePlateLabel.Size = new System.Drawing.Size(118, 22);
            this.LicensePlateLabel.TabIndex = 31;
            this.LicensePlateLabel.Text = "License Plate";
            // 
            // ClaimAmountLabel
            // 
            this.ClaimAmountLabel.AutoSize = true;
            this.ClaimAmountLabel.Location = new System.Drawing.Point(289, 850);
            this.ClaimAmountLabel.Name = "ClaimAmountLabel";
            this.ClaimAmountLabel.Size = new System.Drawing.Size(108, 20);
            this.ClaimAmountLabel.TabIndex = 43;
            this.ClaimAmountLabel.Text = "Claim Amount";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(233, 874);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.ReadOnly = true;
            this.AmountTextBox.Size = new System.Drawing.Size(256, 26);
            this.AmountTextBox.TabIndex = 42;
            // 
            // MakeClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClaimAmountLabel);
            this.Controls.Add(this.AmountTextBox);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MakeClaim";
            this.Size = new System.Drawing.Size(1300, 838);
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
        private System.Windows.Forms.Label ClaimAmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}
