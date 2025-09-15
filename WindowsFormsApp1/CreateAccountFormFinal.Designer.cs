namespace WindowsFormsApp1
{
    partial class CreateAccountFormFinal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.EmailErrorLabel = new System.Windows.Forms.Label();
            this.passwordLabel1 = new System.Windows.Forms.Label();
            this.ErrorLength = new System.Windows.Forms.Label();
            this.UpperCaseLabel = new System.Windows.Forms.Label();
            this.lowercaseLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E - Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(248, 173);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(185, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(248, 118);
            this.emailTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(185, 20);
            this.emailTextbox.TabIndex = 6;
            this.emailTextbox.TextChanged += new System.EventHandler(this.emailTextbox_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(254, 289);
            this.Submit.Margin = new System.Windows.Forms.Padding(2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(104, 35);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // EmailErrorLabel
            // 
            this.EmailErrorLabel.AutoSize = true;
            this.EmailErrorLabel.Location = new System.Drawing.Point(455, 123);
            this.EmailErrorLabel.Name = "EmailErrorLabel";
            this.EmailErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.EmailErrorLabel.TabIndex = 9;
            // 
            // passwordLabel1
            // 
            this.passwordLabel1.AutoSize = true;
            this.passwordLabel1.Location = new System.Drawing.Point(438, 180);
            this.passwordLabel1.Name = "passwordLabel1";
            this.passwordLabel1.Size = new System.Drawing.Size(0, 13);
            this.passwordLabel1.TabIndex = 10;
            // 
            // ErrorLength
            // 
            this.ErrorLength.AutoSize = true;
            this.ErrorLength.ForeColor = System.Drawing.Color.Gray;
            this.ErrorLength.Location = new System.Drawing.Point(251, 214);
            this.ErrorLength.Name = "ErrorLength";
            this.ErrorLength.Size = new System.Drawing.Size(167, 13);
            this.ErrorLength.TabIndex = 11;
            this.ErrorLength.Text = "Must be at least 8 characters long";
            // 
            // UpperCaseLabel
            // 
            this.UpperCaseLabel.AutoSize = true;
            this.UpperCaseLabel.ForeColor = System.Drawing.Color.Gray;
            this.UpperCaseLabel.Location = new System.Drawing.Point(251, 227);
            this.UpperCaseLabel.Name = "UpperCaseLabel";
            this.UpperCaseLabel.Size = new System.Drawing.Size(142, 13);
            this.UpperCaseLabel.TabIndex = 12;
            this.UpperCaseLabel.Text = "At least one uppercase letter";
            // 
            // lowercaseLabel
            // 
            this.lowercaseLabel.AutoSize = true;
            this.lowercaseLabel.ForeColor = System.Drawing.Color.Gray;
            this.lowercaseLabel.Location = new System.Drawing.Point(251, 240);
            this.lowercaseLabel.Name = "lowercaseLabel";
            this.lowercaseLabel.Size = new System.Drawing.Size(140, 13);
            this.lowercaseLabel.TabIndex = 13;
            this.lowercaseLabel.Text = "At least one lowercase letter";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.ForeColor = System.Drawing.Color.Gray;
            this.numberLabel.Location = new System.Drawing.Point(251, 253);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(101, 13);
            this.numberLabel.TabIndex = 14;
            this.numberLabel.Text = "At least one number";
            // 
            // CreateAccountFormFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.lowercaseLabel);
            this.Controls.Add(this.UpperCaseLabel);
            this.Controls.Add(this.ErrorLength);
            this.Controls.Add(this.passwordLabel1);
            this.Controls.Add(this.EmailErrorLabel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccountFormFinal";
            this.Size = new System.Drawing.Size(672, 696);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label EmailErrorLabel;
        private System.Windows.Forms.Label passwordLabel1;
        private System.Windows.Forms.Label ErrorLength;
        private System.Windows.Forms.Label UpperCaseLabel;
        private System.Windows.Forms.Label lowercaseLabel;
        private System.Windows.Forms.Label numberLabel;
    }
}
