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
            rememberMe.AutoSize = true;
            rememberMe.Location = new System.Drawing.Point(47, 363);
            rememberMe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            rememberMe.Name = "rememberMe";
            rememberMe.Size = new System.Drawing.Size(93, 17);
            rememberMe.TabIndex = 4;
            rememberMe.Text = "Remember me";
            rememberMe.UseVisualStyleBackColor = true;
            rememberMe.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(47, 414);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(314, 50);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Location = new System.Drawing.Point(214, 366);
            this.forgotPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(92, 13);
            this.forgotPassword.TabIndex = 5;
            this.forgotPassword.TabStop = true;
            this.forgotPassword.Text = "Forgot Password?";
            this.forgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(45, 232);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(55, 13);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "Username";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(47, 307);
            this.password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(267, 20);
            this.password.TabIndex = 7;
            this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(47, 248);
            this.userName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(267, 20);
            this.userName.TabIndex = 8;
            this.userName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(45, 292);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // dontHaveAccountLabel
            // 
            this.dontHaveAccountLabel.AutoSize = true;
            this.dontHaveAccountLabel.Location = new System.Drawing.Point(45, 500);
            this.dontHaveAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dontHaveAccountLabel.Name = "dontHaveAccountLabel";
            this.dontHaveAccountLabel.Size = new System.Drawing.Size(122, 13);
            this.dontHaveAccountLabel.TabIndex = 11;
            this.dontHaveAccountLabel.Text = "Don\'t have an account?";
            // 
            // signUpLink
            // 
            this.signUpLink.AutoSize = true;
            this.signUpLink.Location = new System.Drawing.Point(274, 500);
            this.signUpLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Size = new System.Drawing.Size(43, 13);
            this.signUpLink.TabIndex = 12;
            this.signUpLink.TabStop = true;
            this.signUpLink.Text = "Sign up";
            this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // welcomeBackLabel
            // 
            this.welcomeBackLabel.AutoSize = true;
            this.welcomeBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBackLabel.Location = new System.Drawing.Point(94, 102);
            this.welcomeBackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeBackLabel.Name = "welcomeBackLabel";
            this.welcomeBackLabel.Size = new System.Drawing.Size(221, 36);
            this.welcomeBackLabel.TabIndex = 13;
            this.welcomeBackLabel.Text = "Welcome back";
            this.welcomeBackLabel.Click += new System.EventHandler(this.welcomeBackLabel_Click);
            // 
            // enterDetailsLabel
            // 
            this.enterDetailsLabel.AutoSize = true;
            this.enterDetailsLabel.Location = new System.Drawing.Point(45, 174);
            this.enterDetailsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterDetailsLabel.Name = "enterDetailsLabel";
            this.enterDetailsLabel.Size = new System.Drawing.Size(122, 13);
            this.enterDetailsLabel.TabIndex = 14;
            this.enterDetailsLabel.Text = "Please enter your details";
            this.enterDetailsLabel.Click += new System.EventHandler(this.enterDetailsLabel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Aweh";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 622);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Car Insurance";
            this.Load += new System.EventHandler(this.Form1_Load);
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

