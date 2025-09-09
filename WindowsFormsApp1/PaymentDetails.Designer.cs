namespace WindowsFormsApp1
{
    partial class PaymentDetails
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
            this.PaymentDetailsLabel = new System.Windows.Forms.Label();
            this.PaymentMethodLabel = new System.Windows.Forms.Label();
            this.PaymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.CardHolderNameLabel = new System.Windows.Forms.Label();
            this.CardHolderNameTextBox = new System.Windows.Forms.TextBox();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.ExpirationDateLable = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.CVVlabel = new System.Windows.Forms.Label();
            this.CVVtextBox = new System.Windows.Forms.TextBox();
            this.PolicyNumberTextBox = new System.Windows.Forms.TextBox();
            this.PolicyNumberLabel = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaymentDetailsLabel
            // 
            this.PaymentDetailsLabel.AutoSize = true;
            this.PaymentDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDetailsLabel.Location = new System.Drawing.Point(242, 59);
            this.PaymentDetailsLabel.Name = "PaymentDetailsLabel";
            this.PaymentDetailsLabel.Size = new System.Drawing.Size(168, 25);
            this.PaymentDetailsLabel.TabIndex = 0;
            this.PaymentDetailsLabel.Text = "Payment Details";
            // 
            // PaymentMethodLabel
            // 
            this.PaymentMethodLabel.AutoSize = true;
            this.PaymentMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLabel.Location = new System.Drawing.Point(15, 155);
            this.PaymentMethodLabel.Name = "PaymentMethodLabel";
            this.PaymentMethodLabel.Size = new System.Drawing.Size(120, 18);
            this.PaymentMethodLabel.TabIndex = 1;
            this.PaymentMethodLabel.Text = "Payment Method";
            // 
            // PaymentMethodComboBox
            // 
            this.PaymentMethodComboBox.FormattingEnabled = true;
            this.PaymentMethodComboBox.Items.AddRange(new object[] {
            "Credit/Debit Card",
            "Bank Transfer",
            "Mobile Wallet",
            "Paypal"});
            this.PaymentMethodComboBox.Location = new System.Drawing.Point(18, 176);
            this.PaymentMethodComboBox.Name = "PaymentMethodComboBox";
            this.PaymentMethodComboBox.Size = new System.Drawing.Size(208, 24);
            this.PaymentMethodComboBox.TabIndex = 2;
            // 
            // CardHolderNameLabel
            // 
            this.CardHolderNameLabel.AutoSize = true;
            this.CardHolderNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardHolderNameLabel.Location = new System.Drawing.Point(15, 246);
            this.CardHolderNameLabel.Name = "CardHolderNameLabel";
            this.CardHolderNameLabel.Size = new System.Drawing.Size(143, 18);
            this.CardHolderNameLabel.TabIndex = 3;
            this.CardHolderNameLabel.Text = "CardHolder\'s Name ";
            // 
            // CardHolderNameTextBox
            // 
            this.CardHolderNameTextBox.Location = new System.Drawing.Point(18, 265);
            this.CardHolderNameTextBox.Name = "CardHolderNameTextBox";
            this.CardHolderNameTextBox.Size = new System.Drawing.Size(312, 22);
            this.CardHolderNameTextBox.TabIndex = 4;
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberLabel.Location = new System.Drawing.Point(357, 246);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(97, 18);
            this.CardNumberLabel.TabIndex = 5;
            this.CardNumberLabel.Text = "Card Number";
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Location = new System.Drawing.Point(360, 265);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(268, 22);
            this.CardNumberTextBox.TabIndex = 6;
            // 
            // ExpirationDateLable
            // 
            this.ExpirationDateLable.AutoSize = true;
            this.ExpirationDateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirationDateLable.Location = new System.Drawing.Point(15, 324);
            this.ExpirationDateLable.Name = "ExpirationDateLable";
            this.ExpirationDateLable.Size = new System.Drawing.Size(108, 18);
            this.ExpirationDateLable.TabIndex = 7;
            this.ExpirationDateLable.Text = "Expiration Date";
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.YearComboBox.Location = new System.Drawing.Point(145, 377);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(121, 24);
            this.YearComboBox.TabIndex = 8;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
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
            "12"});
            this.MonthComboBox.Location = new System.Drawing.Point(18, 377);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(121, 24);
            this.MonthComboBox.TabIndex = 9;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Location = new System.Drawing.Point(15, 358);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(43, 16);
            this.MonthLabel.TabIndex = 10;
            this.MonthLabel.Text = "Month";
            this.MonthLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(142, 358);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(36, 16);
            this.YearLabel.TabIndex = 11;
            this.YearLabel.Text = "Year";
            // 
            // CVVlabel
            // 
            this.CVVlabel.AutoSize = true;
            this.CVVlabel.Location = new System.Drawing.Point(15, 436);
            this.CVVlabel.Name = "CVVlabel";
            this.CVVlabel.Size = new System.Drawing.Size(34, 16);
            this.CVVlabel.TabIndex = 12;
            this.CVVlabel.Text = "CVV";
            // 
            // CVVtextBox
            // 
            this.CVVtextBox.Location = new System.Drawing.Point(18, 455);
            this.CVVtextBox.Name = "CVVtextBox";
            this.CVVtextBox.Size = new System.Drawing.Size(100, 22);
            this.CVVtextBox.TabIndex = 13;
            // 
            // PolicyNumberTextBox
            // 
            this.PolicyNumberTextBox.Location = new System.Drawing.Point(18, 541);
            this.PolicyNumberTextBox.Name = "PolicyNumberTextBox";
            this.PolicyNumberTextBox.Size = new System.Drawing.Size(208, 22);
            this.PolicyNumberTextBox.TabIndex = 14;
            // 
            // PolicyNumberLabel
            // 
            this.PolicyNumberLabel.AutoSize = true;
            this.PolicyNumberLabel.Location = new System.Drawing.Point(15, 522);
            this.PolicyNumberLabel.Name = "PolicyNumberLabel";
            this.PolicyNumberLabel.Size = new System.Drawing.Size(95, 16);
            this.PolicyNumberLabel.TabIndex = 15;
            this.PolicyNumberLabel.Text = "Policy Number";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(230, 624);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(185, 23);
            this.ConfirmButton.TabIndex = 16;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.PolicyNumberLabel);
            this.Controls.Add(this.PolicyNumberTextBox);
            this.Controls.Add(this.CVVtextBox);
            this.Controls.Add(this.CVVlabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.ExpirationDateLable);
            this.Controls.Add(this.CardNumberTextBox);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.CardHolderNameTextBox);
            this.Controls.Add(this.CardHolderNameLabel);
            this.Controls.Add(this.PaymentMethodComboBox);
            this.Controls.Add(this.PaymentMethodLabel);
            this.Controls.Add(this.PaymentDetailsLabel);
            this.Name = "PaymentDetails";
            this.Size = new System.Drawing.Size(754, 689);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaymentDetailsLabel;
        private System.Windows.Forms.Label PaymentMethodLabel;
        private System.Windows.Forms.ComboBox PaymentMethodComboBox;
        private System.Windows.Forms.Label CardHolderNameLabel;
        private System.Windows.Forms.TextBox CardHolderNameTextBox;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.Label ExpirationDateLable;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label CVVlabel;
        private System.Windows.Forms.TextBox CVVtextBox;
        private System.Windows.Forms.TextBox PolicyNumberTextBox;
        private System.Windows.Forms.Label PolicyNumberLabel;
        private System.Windows.Forms.Button ConfirmButton;
    }
}
