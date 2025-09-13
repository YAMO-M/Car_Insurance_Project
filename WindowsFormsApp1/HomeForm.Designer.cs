namespace WindowsFormsApp1
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddPolicyButton = new System.Windows.Forms.Button();
            this.UpdatePersonalDetButton = new System.Windows.Forms.Button();
            this.MakeClaimButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.addVehicle3 = new WindowsFormsApp1.AddVehicle();
            this.makeClaim3 = new WindowsFormsApp1.MakeClaim();
            this.paymentDetails2 = new WindowsFormsApp1.PaymentDetails();
            this.homePage1 = new WindowsFormsApp1.HomePage();
            this.policyPage1 = new WindowsFormsApp1.PolicyPage();
            this.updatePersonalInfo1 = new WindowsFormsApp1.UpdatePersonalInfo();
            this.makeClaim2 = new WindowsFormsApp1.MakeClaim();
            this.paymentDetails1 = new WindowsFormsApp1.PaymentDetails();
            this.makeClaim1 = new WindowsFormsApp1.MakeClaim();
            this.addVehicle2 = new WindowsFormsApp1.AddVehicle();
            this.addVehicle1 = new WindowsFormsApp1.AddVehicle();
          
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddPolicyButton);
            this.panel2.Controls.Add(this.MakeClaimButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.AddCarButton);
            this.panel2.Controls.Add(this.UserLabel);
            this.panel2.Controls.Add(this.HomeButton);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 1318);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // AddPolicyButton
            // 
            this.AddPolicyButton.AllowDrop = true;
            this.AddPolicyButton.Location = new System.Drawing.Point(-2, 501);
            this.AddPolicyButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddPolicyButton.Name = "AddPolicyButton";
            this.AddPolicyButton.Size = new System.Drawing.Size(260, 92);
            this.AddPolicyButton.TabIndex = 13;
            this.AddPolicyButton.Text = "Add Policy";
            this.AddPolicyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddPolicyButton.UseVisualStyleBackColor = true;
            this.AddPolicyButton.Click += new System.EventHandler(this.AddPolicyButton_Click);
            // 
            // UpdatePersonalDetButton
            // 
            this.UpdatePersonalDetButton.Location = new System.Drawing.Point(-2, 682);
            this.UpdatePersonalDetButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UpdatePersonalDetButton.Name = "UpdatePersonalDetButton";
            this.UpdatePersonalDetButton.Size = new System.Drawing.Size(258, 98);
            this.UpdatePersonalDetButton.TabIndex = 11;
            this.UpdatePersonalDetButton.Text = "Update Personal Details";
            this.UpdatePersonalDetButton.UseVisualStyleBackColor = true;
            this.UpdatePersonalDetButton.Click += new System.EventHandler(this.UpdatePersonalDetButton_Click);
            // 
            // MakeClaimButton
            // 
            this.MakeClaimButton.Location = new System.Drawing.Point(-3, 593);
            this.MakeClaimButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MakeClaimButton.Name = "MakeClaimButton";
            this.MakeClaimButton.Size = new System.Drawing.Size(258, 94);
            this.MakeClaimButton.TabIndex = 6;
            this.MakeClaimButton.Text = "Make Claim";
            this.MakeClaimButton.UseVisualStyleBackColor = true;
            this.MakeClaimButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 285);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddCarButton
            // 
            this.AddCarButton.Location = new System.Drawing.Point(0, 0);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(75, 23);
            this.AddCarButton.TabIndex = 12;
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(100, 326);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(57, 25);
            this.UserLabel.TabIndex = 4;
            this.UserLabel.Text = "User";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.AllowDrop = true;
            this.HomeButton.Location = new System.Drawing.Point(-2, 389);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(260, 120);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addVehicle3
            // 
            this.addVehicle3.AutoScroll = true;
            this.addVehicle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicle3.Location = new System.Drawing.Point(261, 2);
            this.addVehicle3.Name = "addVehicle3";
            this.addVehicle3.Size = new System.Drawing.Size(1250, 1048);
            this.addVehicle3.TabIndex = 18;
            // 
            // makeClaim3
            // 
            this.makeClaim3.AutoScroll = true;
            this.makeClaim3.Location = new System.Drawing.Point(261, 2);
            this.makeClaim3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.makeClaim3.Name = "makeClaim3";
            this.makeClaim3.Size = new System.Drawing.Size(1026, 1178);
            this.makeClaim3.TabIndex = 17;
            this.makeClaim3.Load += new System.EventHandler(this.makeClaim3_Load);
            // 
            // paymentDetails2
            // 
            this.paymentDetails2.AutoScroll = true;
            this.paymentDetails2.Location = new System.Drawing.Point(261, 2);
            this.paymentDetails2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.paymentDetails2.Name = "paymentDetails2";
            this.paymentDetails2.Size = new System.Drawing.Size(1026, 1183);
            this.paymentDetails2.TabIndex = 16;
            // 
            // homePage1
            // 
            this.homePage1.Location = new System.Drawing.Point(261, 2);
            this.homePage1.Margin = new System.Windows.Forms.Padding(2);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(1026, 1183);
            this.homePage1.TabIndex = 14;
            // 
            // policyPage1
            // 
            this.policyPage1.Location = new System.Drawing.Point(261, 2);
            this.policyPage1.Margin = new System.Windows.Forms.Padding(2);
            this.policyPage1.Name = "policyPage1";
            this.policyPage1.Size = new System.Drawing.Size(1026, 1157);
            this.policyPage1.TabIndex = 13;
            // 
            // updatePersonalInfo1
            // 
            this.updatePersonalInfo1.AutoScroll = true;
            this.updatePersonalInfo1.Location = new System.Drawing.Point(261, 5);
            this.updatePersonalInfo1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.updatePersonalInfo1.Name = "updatePersonalInfo1";
            this.updatePersonalInfo1.Size = new System.Drawing.Size(1276, 1314);
            this.updatePersonalInfo1.TabIndex = 11;
            // 
            // makeClaim2
            // 
            this.makeClaim2.AutoScroll = true;
            this.makeClaim2.Location = new System.Drawing.Point(261, 5);
            this.makeClaim2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.makeClaim2.Name = "makeClaim2";
            this.makeClaim2.Size = new System.Drawing.Size(1262, 1035);
            this.makeClaim2.TabIndex = 10;
            // 
            // paymentDetails1
            // 
            this.paymentDetails1.AutoScroll = true;
            this.paymentDetails1.Location = new System.Drawing.Point(261, 2);
            this.paymentDetails1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.paymentDetails1.Name = "paymentDetails1";
            this.paymentDetails1.Size = new System.Drawing.Size(1276, 1026);
            this.paymentDetails1.TabIndex = 8;
            // 
            // makeClaim1
            // 
            this.makeClaim1.AutoScroll = true;
            this.makeClaim1.Location = new System.Drawing.Point(429, 245);
            this.makeClaim1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.makeClaim1.Name = "makeClaim1";
            this.makeClaim1.Size = new System.Drawing.Size(1262, 1195);
            this.makeClaim1.TabIndex = 7;
            // 
            // addVehicle2
            // 
            this.addVehicle2.AutoScroll = true;
            this.addVehicle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicle2.Location = new System.Drawing.Point(0, 0);
            this.addVehicle2.Name = "addVehicle2";
            this.addVehicle2.Size = new System.Drawing.Size(914, 838);
            this.addVehicle2.TabIndex = 0;
            // 
            // addVehicle1
            // 
            this.addVehicle1.AutoScroll = true;
            this.addVehicle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicle1.Location = new System.Drawing.Point(0, 0);
            this.addVehicle1.Name = "addVehicle1";
            this.addVehicle1.Size = new System.Drawing.Size(914, 838);
            this.addVehicle1.TabIndex = 0;
           
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 1062);
            this.Controls.Add(this.addVehicle3);
            this.Controls.Add(this.UpdatePersonalDetButton);
            this.Controls.Add(this.makeClaim3);
            this.Controls.Add(this.paymentDetails2);
            this.Controls.Add(this.homePage1);
            this.Controls.Add(this.policyPage1);
            this.Controls.Add(this.updatePersonalInfo1);
            this.Controls.Add(this.makeClaim2);
            this.Controls.Add(this.paymentDetails1);
            this.Controls.Add(this.makeClaim1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "HomeForm";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddCarButton;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button MakeClaimButton;
        private AddVehicle addVehicle1;
        private MakeClaim makeClaim1;
        private PaymentDetails paymentDetails1;
        private AddVehicle addVehicle2;
        private MakeClaim makeClaim2;
        private System.Windows.Forms.Button UpdatePersonalDetButton;
        private UpdatePersonalInfo updatePersonalInfo1;
        //private UpdateCarDetails updateCarDetails1;
        private PolicyPage policyPage1;
        private HomePage homePage1;
        //private UpdateCarDetails updateCarDetails2;
        private PaymentDetails paymentDetails2;
        private MakeClaim makeClaim3;
        private System.Windows.Forms.Button AddPolicyButton;
        private AddVehicle addVehicle3;
    }
}