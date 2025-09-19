namespace WindowsFormsApp1
{
    partial class AddVehicle
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
            this.VINlabel = new System.Windows.Forms.Label();
            this.VINtextBox = new System.Windows.Forms.TextBox();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.MakeTextBox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelTextBox = new System.Windows.Forms.TextBox();
            this.PolicyCreation = new System.Windows.Forms.Button();
            this.RegistrationPlateLabel = new System.Windows.Forms.Label();
            this.RegistrationPlateTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.PaymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.PaymentDetailsLabel = new System.Windows.Forms.Label();
            this.Policy1 = new System.Windows.Forms.RadioButton();
            this.Policy2 = new System.Windows.Forms.RadioButton();
            this.Policy3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // VINlabel
            // 
            this.VINlabel.AutoSize = true;
            this.VINlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VINlabel.Location = new System.Drawing.Point(31, 82);
            this.VINlabel.Name = "VINlabel";
            this.VINlabel.Size = new System.Drawing.Size(242, 22);
            this.VINlabel.TabIndex = 1;
            this.VINlabel.Text = "Vehicle Identification Number";
            // 
            // VINtextBox
            // 
            this.VINtextBox.Location = new System.Drawing.Point(35, 108);
            this.VINtextBox.Name = "VINtextBox";
            this.VINtextBox.Size = new System.Drawing.Size(318, 28);
            this.VINtextBox.TabIndex = 2;
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeLabel.Location = new System.Drawing.Point(33, 147);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(53, 22);
            this.MakeLabel.TabIndex = 3;
            this.MakeLabel.Text = "Make";
            // 
            // MakeTextBox
            // 
            this.MakeTextBox.Location = new System.Drawing.Point(36, 169);
            this.MakeTextBox.Name = "MakeTextBox";
            this.MakeTextBox.Size = new System.Drawing.Size(319, 28);
            this.MakeTextBox.TabIndex = 4;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelLabel.Location = new System.Drawing.Point(31, 200);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(58, 22);
            this.ModelLabel.TabIndex = 5;
            this.ModelLabel.Text = "Model";
            // 
            // ModelTextBox
            // 
            this.ModelTextBox.Location = new System.Drawing.Point(35, 222);
            this.ModelTextBox.Name = "ModelTextBox";
            this.ModelTextBox.Size = new System.Drawing.Size(325, 28);
            this.ModelTextBox.TabIndex = 6;
            // 
            // PolicyCreation
            // 
            this.PolicyCreation.Location = new System.Drawing.Point(339, 528);
            this.PolicyCreation.Name = "PolicyCreation";
            this.PolicyCreation.Size = new System.Drawing.Size(256, 33);
            this.PolicyCreation.TabIndex = 11;
            this.PolicyCreation.Text = "Create Policy";
            this.PolicyCreation.UseVisualStyleBackColor = true;
            this.PolicyCreation.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RegistrationPlateLabel
            // 
            this.RegistrationPlateLabel.AutoSize = true;
            this.RegistrationPlateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationPlateLabel.Location = new System.Drawing.Point(33, 324);
            this.RegistrationPlateLabel.Name = "RegistrationPlateLabel";
            this.RegistrationPlateLabel.Size = new System.Drawing.Size(220, 22);
            this.RegistrationPlateLabel.TabIndex = 12;
            this.RegistrationPlateLabel.Text = "Registration Number/Plate";
            // 
            // RegistrationPlateTextBox
            // 
            this.RegistrationPlateTextBox.Location = new System.Drawing.Point(34, 348);
            this.RegistrationPlateTextBox.Name = "RegistrationPlateTextBox";
            this.RegistrationPlateTextBox.Size = new System.Drawing.Size(326, 28);
            this.RegistrationPlateTextBox.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(394, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 22);
            this.label12.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Car Details";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(32, 257);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(172, 22);
            this.YearLabel.TabIndex = 7;
            this.YearLabel.Text = "Year of manufacture";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(505, 400);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(71, 22);
            this.AmountLabel.TabIndex = 41;
            this.AmountLabel.Text = "Amount";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(500, 426);
            this.AmountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.ReadOnly = true;
            this.AmountTextBox.Size = new System.Drawing.Size(337, 28);
            this.AmountTextBox.TabIndex = 40;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberLabel.Location = new System.Drawing.Point(508, 154);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(240, 22);
            this.CardNumberLabel.TabIndex = 31;
            this.CardNumberLabel.Text = "Payment Date (Current year)";
            // 
            // PaymentMethodComboBox
            // 
            this.PaymentMethodComboBox.FormattingEnabled = true;
            this.PaymentMethodComboBox.Items.AddRange(new object[] {
            "Credit/Debit Card",
            "EFT"});
            this.PaymentMethodComboBox.Location = new System.Drawing.Point(508, 118);
            this.PaymentMethodComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PaymentMethodComboBox.Name = "PaymentMethodComboBox";
            this.PaymentMethodComboBox.Size = new System.Drawing.Size(329, 30);
            this.PaymentMethodComboBox.TabIndex = 28;
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLabel.Location = new System.Drawing.Point(504, 92);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(144, 22);
            this.PaymentMethodLabel.TabIndex = 27;
            this.PaymentMethodLabel.Text = "Payment Method";
            // 
            // PaymentDetailsLabel
            // 
            this.PaymentDetailsLabel.AutoSize = true;
            this.PaymentDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.PaymentDetailsLabel.Location = new System.Drawing.Point(507, 31);
            this.PaymentDetailsLabel.Name = "PaymentDetailsLabel";
            this.PaymentDetailsLabel.Size = new System.Drawing.Size(236, 32);
            this.PaymentDetailsLabel.TabIndex = 26;
            this.PaymentDetailsLabel.Text = "Payment Details";
            this.PaymentDetailsLabel.Click += new System.EventHandler(this.PaymentDetailsLabel_Click);
            // 
            // Policy1
            // 
            this.Policy1.AutoSize = true;
            this.Policy1.Location = new System.Drawing.Point(42, 437);
            this.Policy1.Name = "Policy1";
            this.Policy1.Size = new System.Drawing.Size(98, 26);
            this.Policy1.TabIndex = 43;
            this.Policy1.TabStop = true;
            this.Policy1.Text = "Policy 1";
            this.Policy1.UseVisualStyleBackColor = true;
            this.Policy1.CheckedChanged += new System.EventHandler(this.Policy1_CheckedChanged);
            // 
            // Policy2
            // 
            this.Policy2.AutoSize = true;
            this.Policy2.Location = new System.Drawing.Point(155, 437);
            this.Policy2.Name = "Policy2";
            this.Policy2.Size = new System.Drawing.Size(98, 26);
            this.Policy2.TabIndex = 44;
            this.Policy2.TabStop = true;
            this.Policy2.Text = "Policy 2";
            this.Policy2.UseVisualStyleBackColor = true;
            this.Policy2.CheckedChanged += new System.EventHandler(this.Policy2_CheckedChanged);
            // 
            // Policy3
            // 
            this.Policy3.AutoSize = true;
            this.Policy3.Location = new System.Drawing.Point(268, 437);
            this.Policy3.Name = "Policy3";
            this.Policy3.Size = new System.Drawing.Size(98, 26);
            this.Policy3.TabIndex = 45;
            this.Policy3.TabStop = true;
            this.Policy3.Text = "Policy 3";
            this.Policy3.UseVisualStyleBackColor = true;
            this.Policy3.CheckedChanged += new System.EventHandler(this.Policy3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 318);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(336, 28);
            this.textBox1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(504, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 47;
            this.label2.Text = "Reciept Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "Policy Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBox1.Location = new System.Drawing.Point(34, 283);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 30);
            this.comboBox1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 51;
            this.label4.Text = "End Date ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2025"});
            this.comboBox2.Location = new System.Drawing.Point(509, 180);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(328, 30);
            this.comboBox2.TabIndex = 52;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBox3.Location = new System.Drawing.Point(508, 247);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(328, 30);
            this.comboBox3.TabIndex = 53;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Policy3);
            this.Controls.Add(this.Policy2);
            this.Controls.Add(this.Policy1);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.PaymentMethodComboBox);
            this.Controls.Add(this.PaymentMethodLabel);
            this.Controls.Add(this.PaymentDetailsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RegistrationPlateTextBox);
            this.Controls.Add(this.RegistrationPlateLabel);
            this.Controls.Add(this.PolicyCreation);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.ModelTextBox);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.MakeTextBox);
            this.Controls.Add(this.MakeLabel);
            this.Controls.Add(this.VINtextBox);
            this.Controls.Add(this.VINlabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddVehicle";
            this.Size = new System.Drawing.Size(1300, 838);
            this.Load += new System.EventHandler(this.AddVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label VINlabel;
        private System.Windows.Forms.TextBox VINtextBox;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.TextBox MakeTextBox;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.TextBox ModelTextBox;
        private System.Windows.Forms.Button PolicyCreation;
        private System.Windows.Forms.Label RegistrationPlateLabel;
        private System.Windows.Forms.TextBox RegistrationPlateTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.ComboBox PaymentMethodComboBox;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.Label PaymentDetailsLabel;
        private System.Windows.Forms.RadioButton Policy1;
        private System.Windows.Forms.RadioButton Policy2;
        private System.Windows.Forms.RadioButton Policy3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}
