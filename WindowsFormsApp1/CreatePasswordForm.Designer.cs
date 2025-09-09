namespace WindowsFormsApp1
{
    partial class CreatePasswordForm
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
            this.components = new System.ComponentModel.Container();
            this.createPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.createPasswordTextbox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.createPasswordButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // createPasswordLabel
            // 
            this.createPasswordLabel.AutoSize = true;
            this.createPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPasswordLabel.Location = new System.Drawing.Point(128, 100);
            this.createPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createPasswordLabel.Name = "createPasswordLabel";
            this.createPasswordLabel.Size = new System.Drawing.Size(238, 31);
            this.createPasswordLabel.TabIndex = 0;
            this.createPasswordLabel.Text = "Create Password";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(65, 196);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 16);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // createPasswordTextbox
            // 
            this.createPasswordTextbox.Location = new System.Drawing.Point(68, 216);
            this.createPasswordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.createPasswordTextbox.Name = "createPasswordTextbox";
            this.createPasswordTextbox.Size = new System.Drawing.Size(412, 22);
            this.createPasswordTextbox.TabIndex = 2;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(65, 292);
            this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(115, 16);
            this.confirmPasswordLabel.TabIndex = 3;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(69, 311);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(412, 22);
            this.confirmPassword.TabIndex = 4;
            // 
            // createPasswordButton
            // 
            this.createPasswordButton.Location = new System.Drawing.Point(135, 427);
            this.createPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.createPasswordButton.Name = "createPasswordButton";
            this.createPasswordButton.Size = new System.Drawing.Size(224, 28);
            this.createPasswordButton.TabIndex = 5;
            this.createPasswordButton.Text = "Create Password";
            this.createPasswordButton.UseVisualStyleBackColor = true;
            this.createPasswordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreatePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 554);
            this.Controls.Add(this.createPasswordButton);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.createPasswordTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.createPasswordLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreatePasswordForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox createPasswordTextbox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Button createPasswordButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}