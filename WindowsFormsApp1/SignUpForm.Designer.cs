namespace WindowsFormsApp1
{
    partial class SignUpForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.createAccountFormFinal1 = new WindowsFormsApp1.CreateAccountFormFinal();
            this.signUpPersonalDetails1 = new WindowsFormsApp1.SignUpPersonalDetails();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(550, 736);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "NextButton";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 736);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 736);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // createAccountFormFinal1
            // 
            this.createAccountFormFinal1.Location = new System.Drawing.Point(-2, -1);
            this.createAccountFormFinal1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createAccountFormFinal1.Name = "createAccountFormFinal1";
            this.createAccountFormFinal1.Size = new System.Drawing.Size(848, 696);
            this.createAccountFormFinal1.TabIndex = 7;
            this.createAccountFormFinal1.Load += new System.EventHandler(this.createAccountFormFinal1_Load);
            // 
            // signUpPersonalDetails1
            // 
            this.signUpPersonalDetails1.Location = new System.Drawing.Point(-2, -1);
            this.signUpPersonalDetails1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signUpPersonalDetails1.Name = "signUpPersonalDetails1";
            this.signUpPersonalDetails1.Size = new System.Drawing.Size(832, 696);
            this.signUpPersonalDetails1.TabIndex = 6;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(859, 789);
            this.Controls.Add(this.createAccountFormFinal1);
            this.Controls.Add(this.signUpPersonalDetails1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NextButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SignUpForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

     
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private SignUpPersonalDetails signUpPersonalDetails1;
        private CreateAccountFormFinal createAccountFormFinal1;
    }
}