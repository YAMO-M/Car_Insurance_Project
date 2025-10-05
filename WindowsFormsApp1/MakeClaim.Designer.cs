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
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IncidentDetailsLabel
            // 
            this.IncidentDetailsLabel.AutoSize = true;
            this.IncidentDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.IncidentDetailsLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.IncidentDetailsLabel.Location = new System.Drawing.Point(68, 329);
            this.IncidentDetailsLabel.Name = "IncidentDetailsLabel";
            this.IncidentDetailsLabel.Size = new System.Drawing.Size(186, 29);
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
            this.TypeOfClaimComboBox.Location = new System.Drawing.Point(72, 405);
            this.TypeOfClaimComboBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TypeOfClaimComboBox.Name = "TypeOfClaimComboBox";
            this.TypeOfClaimComboBox.Size = new System.Drawing.Size(643, 28);
            this.TypeOfClaimComboBox.TabIndex = 9;
            // 
            // TypeOfClaimLabel
            // 
            this.TypeOfClaimLabel.AutoSize = true;
            this.TypeOfClaimLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfClaimLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TypeOfClaimLabel.Location = new System.Drawing.Point(69, 379);
            this.TypeOfClaimLabel.Name = "TypeOfClaimLabel";
            this.TypeOfClaimLabel.Size = new System.Drawing.Size(125, 22);
            this.TypeOfClaimLabel.TabIndex = 10;
            this.TypeOfClaimLabel.Text = "Type Of Claim";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(838, 403);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateTimePicker1.MinDate = new System.DateTime(2025, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(786, 26);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2025, 10, 1, 0, 0, 0, 0);
            // 
            // DateAndTimeLabel
            // 
            this.DateAndTimeLabel.AutoSize = true;
            this.DateAndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAndTimeLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DateAndTimeLabel.Location = new System.Drawing.Point(836, 379);
            this.DateAndTimeLabel.Name = "DateAndTimeLabel";
            this.DateAndTimeLabel.Size = new System.Drawing.Size(135, 22);
            this.DateAndTimeLabel.TabIndex = 12;
            this.DateAndTimeLabel.Text = "Date of Incident";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DescriptionLabel.Location = new System.Drawing.Point(68, 482);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(167, 22);
            this.DescriptionLabel.TabIndex = 20;
            this.DescriptionLabel.Text = "Incident Description";
            // 
            // DescriptionRichTextBox
            // 
            this.DescriptionRichTextBox.Location = new System.Drawing.Point(72, 509);
            this.DescriptionRichTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            this.DescriptionRichTextBox.Size = new System.Drawing.Size(1554, 78);
            this.DescriptionRichTextBox.TabIndex = 21;
            this.DescriptionRichTextBox.Text = "";
            // 
            // ClaimButton
            // 
            this.ClaimButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClaimButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ClaimButton.Location = new System.Drawing.Point(454, 616);
            this.ClaimButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ClaimButton.Name = "ClaimButton";
            this.ClaimButton.Size = new System.Drawing.Size(250, 46);
            this.ClaimButton.TabIndex = 27;
            this.ClaimButton.Text = "Approve";
            this.ClaimButton.UseVisualStyleBackColor = false;
            this.ClaimButton.Click += new System.EventHandler(this.ClaimButton_Click);
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(68, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Enter Client ID";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchButton.ForeColor = System.Drawing.SystemColors.Window;
            this.searchButton.Location = new System.Drawing.Point(1426, 58);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(174, 38);
            this.searchButton.TabIndex = 46;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(914, 616);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 46);
            this.button1.TabIndex = 47;
            this.button1.Text = "Disapprove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(69, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "Policy Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(68, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "Policy Status";
            // 
            // PolicyStatus
            // 
            this.PolicyStatus.Enabled = false;
            this.PolicyStatus.Location = new System.Drawing.Point(280, 236);
            this.PolicyStatus.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PolicyStatus.Name = "PolicyStatus";
            this.PolicyStatus.Size = new System.Drawing.Size(1074, 26);
            this.PolicyStatus.TabIndex = 54;
            // 
            // policyType
            // 
            this.policyType.Enabled = false;
            this.policyType.Location = new System.Drawing.Point(280, 176);
            this.policyType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.policyType.Name = "policyType";
            this.policyType.Size = new System.Drawing.Size(1074, 26);
            this.policyType.TabIndex = 57;
            // 
            // policyError
            // 
            this.policyError.AutoSize = true;
            this.policyError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policyError.Location = new System.Drawing.Point(788, 120);
            this.policyError.Name = "policyError";
            this.policyError.Size = new System.Drawing.Size(0, 22);
            this.policyError.TabIndex = 60;
            // 
            // ClientIDTextbox
            // 
            this.ClientIDTextbox.Location = new System.Drawing.Point(280, 119);
            this.ClientIDTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientIDTextbox.Name = "ClientIDTextbox";
            this.ClientIDTextbox.Size = new System.Drawing.Size(1074, 26);
            this.ClientIDTextbox.TabIndex = 61;
            this.ClientIDTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientIDTextbox_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(668, 39);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 29);
            this.label18.TabIndex = 110;
            this.label18.Text = "MAKE CLAIM";
            // 
            // MakeClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label18);
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
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MakeClaim";
            this.Size = new System.Drawing.Size(1778, 1034);
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
        private System.Windows.Forms.Label label18;
    }
}
