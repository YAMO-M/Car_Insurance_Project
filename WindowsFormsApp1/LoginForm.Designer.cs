using System;

namespace WindowsFormsApp1
{
    partial class LoginForm
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
            System.Windows.Forms.RadioButton rememberMe;
            this.loginButton = new System.Windows.Forms.Button();
            this.forgotPassword = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.dontHaveAccountLabel = new System.Windows.Forms.Label();
            this.signUpLink = new System.Windows.Forms.LinkLabel();
            this.welcomeBackLabel = new System.Windows.Forms.Label();
            this.enterDetailsLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            rememberMe = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rememberMe
            // 
            rememberMe.Location = new System.Drawing.Point(0, 0);
            rememberMe.Name = "rememberMe";
            rememberMe.Size = new System.Drawing.Size(104, 25);
            rememberMe.TabIndex = 15;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(70, 637);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(471, 77);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Location = new System.Drawing.Point(321, 563);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(138, 20);
            this.forgotPassword.TabIndex = 5;
            this.forgotPassword.TabStop = true;
            this.forgotPassword.Text = "Forgot Password?";
            this.forgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPassword_LinkClicked);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(68, 357);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(48, 20);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "Email";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(70, 472);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(398, 26);
            this.password.TabIndex = 7;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(70, 382);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(398, 26);
            this.userName.TabIndex = 8;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(68, 449);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // dontHaveAccountLabel
            // 
            this.dontHaveAccountLabel.AutoSize = true;
            this.dontHaveAccountLabel.Location = new System.Drawing.Point(68, 769);
            this.dontHaveAccountLabel.Name = "dontHaveAccountLabel";
            this.dontHaveAccountLabel.Size = new System.Drawing.Size(177, 20);
            this.dontHaveAccountLabel.TabIndex = 11;
            this.dontHaveAccountLabel.Text = "Don\'t have an account?";
            // 
            // signUpLink
            // 
            this.signUpLink.AutoSize = true;
            this.signUpLink.Location = new System.Drawing.Point(411, 769);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Size = new System.Drawing.Size(63, 20);
            this.signUpLink.TabIndex = 12;
            this.signUpLink.TabStop = true;
            this.signUpLink.Text = "Sign up";
            this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLink_LinkClicked);
            // 
            // welcomeBackLabel
            // 
            this.welcomeBackLabel.AutoSize = true;
            this.welcomeBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBackLabel.Location = new System.Drawing.Point(141, 157);
            this.welcomeBackLabel.Name = "welcomeBackLabel";
            this.welcomeBackLabel.Size = new System.Drawing.Size(329, 52);
            this.welcomeBackLabel.TabIndex = 13;
            this.welcomeBackLabel.Text = "Welcome back";
            // 
            // enterDetailsLabel
            // 
            this.enterDetailsLabel.AutoSize = true;
            this.enterDetailsLabel.Location = new System.Drawing.Point(68, 268);
            this.enterDetailsLabel.Name = "enterDetailsLabel";
            this.enterDetailsLabel.Size = new System.Drawing.Size(182, 20);
            this.enterDetailsLabel.TabIndex = 14;
            this.enterDetailsLabel.Text = "Please enter your details";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 957);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterDetailsLabel);
            this.Controls.Add(this.welcomeBackLabel);
            this.Controls.Add(this.signUpLink);
            this.Controls.Add(this.dontHaveAccountLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(rememberMe);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginForm";
            this.Text = "Car Insurance";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel forgotPassword;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label dontHaveAccountLabel;
        private System.Windows.Forms.LinkLabel signUpLink;
        private System.Windows.Forms.Label welcomeBackLabel;
        private System.Windows.Forms.Label enterDetailsLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}

