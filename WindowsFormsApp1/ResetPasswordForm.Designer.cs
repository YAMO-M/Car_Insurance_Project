namespace WindowsFormsApp1
{
    partial class ResetPasswordForm
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
            this.ResetPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.createNewPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.resetPasswordButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ResetPasswordLabel
            // 
            this.ResetPasswordLabel.AutoSize = true;
            this.ResetPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPasswordLabel.Location = new System.Drawing.Point(152, 100);
            this.ResetPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResetPasswordLabel.Name = "ResetPasswordLabel";
            this.ResetPasswordLabel.Size = new System.Drawing.Size(227, 31);
            this.ResetPasswordLabel.TabIndex = 0;
            this.ResetPasswordLabel.Text = "Reset Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(83, 311);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(409, 22);
            this.confirmPassword.TabIndex = 1;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(83, 223);
            this.newPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(409, 22);
            this.newPassword.TabIndex = 2;
            // 
            // createNewPasswordLabel
            // 
            this.createNewPasswordLabel.AutoSize = true;
            this.createNewPasswordLabel.Location = new System.Drawing.Point(79, 292);
            this.createNewPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createNewPasswordLabel.Name = "createNewPasswordLabel";
            this.createNewPasswordLabel.Size = new System.Drawing.Size(145, 16);
            this.createNewPasswordLabel.TabIndex = 3;
            this.createNewPasswordLabel.Text = "Confirm New Password";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(79, 203);
            this.newPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(97, 16);
            this.newPasswordLabel.TabIndex = 4;
            this.newPasswordLabel.Text = "New Password";
            // 
            // resetPasswordButton
            // 
            this.resetPasswordButton.Location = new System.Drawing.Point(171, 415);
            this.resetPasswordButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetPasswordButton.Name = "resetPasswordButton";
            this.resetPasswordButton.Size = new System.Drawing.Size(236, 28);
            this.resetPasswordButton.TabIndex = 5;
            this.resetPasswordButton.Text = "Reset Password";
            this.resetPasswordButton.UseVisualStyleBackColor = true;
            this.resetPasswordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 554);
            this.Controls.Add(this.resetPasswordButton);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.createNewPasswordLabel);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.ResetPasswordLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResetPasswordLabel;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label createNewPasswordLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Button resetPasswordButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}