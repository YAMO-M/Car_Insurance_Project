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
            this.policyError = new System.Windows.Forms.Label();
            this.ClientIDTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IncidentDetailsLabel
            // 
            this.IncidentDetailsLabel.AutoSize = true;
            this.IncidentDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.IncidentDetailsLabel.Location = new System.Drawing.Point(45, 179);
            this.IncidentDetailsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IncidentDetailsLabel.Name = "IncidentDetailsLabel";
            this.IncidentDetailsLabel.Size = new System.Drawing.Size(125, 20);
            this.IncidentDetailsLabel.TabIndex = 8;
            this.IncidentDetailsLabel.Text = "Incident Details";
            // 
            // TypeOfClaimComboBox
            // 
            this.TypeOfClaimComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOfClaimComboBox.FormattingEnabled = true;
            this.TypeOfClaimComboBox.Items.AddRange(new object[] {
            "Accident",
            "Theft",
            "Fire",
            "Natural Disaster",
            "Vandalism"});
            this.TypeOfClaimComboBox.Location = new System.Drawing.Point(48, 228);
            this.TypeOfClaimComboBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TypeOfClaimComboBox.Name = "TypeOfClaimComboBox";
            this.TypeOfClaimComboBox.Size = new System.Drawing.Size(215, 21);
            this.TypeOfClaimComboBox.TabIndex = 9;
            // 
            // TypeOfClaimLabel
            // 
            this.TypeOfClaimLabel.AutoSize = true;
            this.TypeOfClaimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfClaimLabel.Location = new System.Drawing.Point(46, 211);
            this.TypeOfClaimLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeOfClaimLabel.Name = "TypeOfClaimLabel";
            this.TypeOfClaimLabel.Size = new System.Drawing.Size(83, 15);
            this.TypeOfClaimLabel.TabIndex = 10;
            this.TypeOfClaimLabel.Text = "Type Of Claim";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 227);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2025, 10, 1, 0, 0, 0, 0);
            // 
            // DateAndTimeLabel
            // 
            this.DateAndTimeLabel.AutoSize = true;
            this.DateAndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAndTimeLabel.Location = new System.Drawing.Point(311, 210);
            this.DateAndTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateAndTimeLabel.Name = "DateAndTimeLabel";
            this.DateAndTimeLabel.Size = new System.Drawing.Size(92, 15);
            this.DateAndTimeLabel.TabIndex = 12;
            this.DateAndTimeLabel.Text = "Date of Incident";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(51, 273);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(115, 15);
            this.DescriptionLabel.TabIndex = 20;
            this.DescriptionLabel.Text = "Incident Description";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(48, 296);
            this.DescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(464, 52);
            this.DescriptionRichTextBox.TabIndex = 21;
            this.DescriptionRichTextBox.Text = "";
            // 
            // ClaimButton
            // 
            this.ClaimButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClaimButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ClaimButton.Location = new System.Drawing.Point(104, 365);
            this.ClaimButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ClaimButton.Name = "ClaimButton";
            this.ClaimButton.Size = new System.Drawing.Size(137, 30);
            this.ClaimButton.TabIndex = 27;
            this.ClaimButton.Text = "Approve";
            this.ClaimButton.UseVisualStyleBackColor = false;
            this.ClaimButton.Click += new System.EventHandler(this.ClaimButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, -22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Description Of The Incident";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Enter Client ID";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.searchButton.Location = new System.Drawing.Point(423, 38);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 25);
            this.searchButton.TabIndex = 46;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(329, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 30);
            this.button1.TabIndex = 47;
            this.button1.Text = "Disapprove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Policy Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "Policy Status";
            // 
            // PolicyStatus
            // 
            this.PolicyStatus.Enabled = false;
            this.PolicyStatus.Location = new System.Drawing.Point(183, 120);
            this.PolicyStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PolicyStatus.Name = "PolicyStatus";
            this.PolicyStatus.Size = new System.Drawing.Size(205, 20);
            this.PolicyStatus.TabIndex = 54;
            // 
            // policyType
            // 
            this.policyType.Enabled = false;
            this.policyType.Location = new System.Drawing.Point(187, 79);
            this.policyType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.policyType.Name = "policyType";
            this.policyType.Size = new System.Drawing.Size(202, 20);
            this.policyType.TabIndex = 57;
            // 
            // policyError
            // 
            this.policyError.AutoSize = true;
            this.policyError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policyError.Location = new System.Drawing.Point(525, 43);
            this.policyError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.policyError.Name = "policyError";
            this.policyError.Size = new System.Drawing.Size(0, 15);
            this.policyError.TabIndex = 60;
            // 
            // ClientIDTextbox
            // 
            this.ClientIDTextbox.Location = new System.Drawing.Point(187, 42);
            this.ClientIDTextbox.Name = "ClientIDTextbox";
            this.ClientIDTextbox.Size = new System.Drawing.Size(201, 20);
            this.ClientIDTextbox.TabIndex = 61;
            this.ClientIDTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientIDTextbox_KeyPress);
            // 
            // MakeClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ClientIDTextbox);
            this.Controls.Add(this.policyError);
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
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MakeClaim";
            this.Size = new System.Drawing.Size(867, 638);
 
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
        private System.Windows.Forms.Label policyError;
        private System.Windows.Forms.TextBox ClientIDTextbox;
    }
}
