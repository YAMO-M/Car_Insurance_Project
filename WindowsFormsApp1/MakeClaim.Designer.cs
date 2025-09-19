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
            this.IncidentDetailsLabel = new System.Windows.Forms.Label();
            this.TypeOfClaimComboBox = new System.Windows.Forms.ComboBox();
            this.TypeOfClaimLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateAndTimeLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ClaimButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PolicyStatus = new System.Windows.Forms.TextBox();
            this.policyType = new System.Windows.Forms.TextBox();
            this.MaskedClientID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // IncidentDetailsLabel
            // 
            this.IncidentDetailsLabel.AutoSize = true;
            this.IncidentDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.IncidentDetailsLabel.Location = new System.Drawing.Point(67, 276);
            this.IncidentDetailsLabel.Name = "IncidentDetailsLabel";
            this.IncidentDetailsLabel.Size = new System.Drawing.Size(186, 29);
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
            "Vandalism"});
            this.TypeOfClaimComboBox.Location = new System.Drawing.Point(72, 351);
            this.TypeOfClaimComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TypeOfClaimComboBox.Name = "TypeOfClaimComboBox";
            this.TypeOfClaimComboBox.Size = new System.Drawing.Size(321, 28);
            this.TypeOfClaimComboBox.TabIndex = 9;
            // 
            // TypeOfClaimLabel
            // 
            this.TypeOfClaimLabel.AutoSize = true;
            this.TypeOfClaimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfClaimLabel.Location = new System.Drawing.Point(69, 324);
            this.TypeOfClaimLabel.Name = "TypeOfClaimLabel";
            this.TypeOfClaimLabel.Size = new System.Drawing.Size(125, 22);
            this.TypeOfClaimLabel.TabIndex = 10;
            this.TypeOfClaimLabel.Text = "Type Of Claim";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(470, 349);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // DateAndTimeLabel
            // 
            this.DateAndTimeLabel.AutoSize = true;
            this.DateAndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAndTimeLabel.Location = new System.Drawing.Point(466, 323);
            this.DateAndTimeLabel.Name = "DateAndTimeLabel";
            this.DateAndTimeLabel.Size = new System.Drawing.Size(135, 22);
            this.DateAndTimeLabel.TabIndex = 12;
            this.DateAndTimeLabel.Text = "Date of Incident";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(77, 420);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(167, 22);
            this.DescriptionLabel.TabIndex = 20;
            this.DescriptionLabel.Text = "Incident Description";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(72, 455);
            this.DescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(694, 78);
            this.DescriptionRichTextBox.TabIndex = 21;
            this.DescriptionRichTextBox.Text = "";
            // 
            // ClaimButton
            // 
            this.ClaimButton.Location = new System.Drawing.Point(156, 562);
            this.ClaimButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClaimButton.Name = "ClaimButton";
            this.ClaimButton.Size = new System.Drawing.Size(205, 46);
            this.ClaimButton.TabIndex = 27;
            this.ClaimButton.Text = "Approve";
            this.ClaimButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Description Of The Incident";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Enter Client Policy ID";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(635, 58);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 39);
            this.searchButton.TabIndex = 46;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 562);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 46);
            this.button1.TabIndex = 47;
            this.button1.Text = "Disapprove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Policy Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "Policy Status";
            // 
            // PolicyStatus
            // 
            this.PolicyStatus.Enabled = false;
            this.PolicyStatus.Location = new System.Drawing.Point(275, 185);
            this.PolicyStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PolicyStatus.Name = "PolicyStatus";
            this.PolicyStatus.Size = new System.Drawing.Size(306, 26);
            this.PolicyStatus.TabIndex = 54;
            // 
            // policyType
            // 
            this.policyType.Enabled = false;
            this.policyType.Location = new System.Drawing.Point(280, 122);
            this.policyType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.policyType.Name = "policyType";
            this.policyType.Size = new System.Drawing.Size(301, 26);
            this.policyType.TabIndex = 57;
            this.policyType.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // MaskedClientID
            // 
            this.MaskedClientID.Location = new System.Drawing.Point(280, 64);
            this.MaskedClientID.Name = "MaskedClientID";
            this.MaskedClientID.Size = new System.Drawing.Size(301, 26);
            this.MaskedClientID.TabIndex = 59;
            // 
            // MakeClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaskedClientID);
            this.Controls.Add(this.policyType);
            this.Controls.Add(this.PolicyStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClaimButton);
            this.Controls.Add(this.DescriptionRichTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DateAndTimeLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TypeOfClaimLabel);
            this.Controls.Add(this.TypeOfClaimComboBox);
            this.Controls.Add(this.IncidentDetailsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MakeClaim";
            this.Size = new System.Drawing.Size(1300, 982);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IncidentDetailsLabel;
        private System.Windows.Forms.ComboBox TypeOfClaimComboBox;
        private System.Windows.Forms.Label TypeOfClaimLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DateAndTimeLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox DescriptionRichTextBox;
        private System.Windows.Forms.Button ClaimButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PolicyStatus;
        private System.Windows.Forms.TextBox policyType;
        private System.Windows.Forms.MaskedTextBox MaskedClientID;
    }
}
