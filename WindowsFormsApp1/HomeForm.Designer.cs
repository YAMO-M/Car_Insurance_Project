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
            this.MakeClaimButton = new System.Windows.Forms.Button();
            this.MakePaymentButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddCarButton = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.UpdatePersonalDetButton = new System.Windows.Forms.Button();
            this.updateCarButton = new System.Windows.Forms.Button();
            this.updatePersonalInfo1 = new WindowsFormsApp1.UpdatePersonalInfo();
            this.makeClaim2 = new WindowsFormsApp1.MakeClaim();
            this.addVehicle2 = new WindowsFormsApp1.AddVehicle();
            this.paymentDetails1 = new WindowsFormsApp1.PaymentDetails();
            this.makeClaim1 = new WindowsFormsApp1.MakeClaim();
            this.addVehicle1 = new WindowsFormsApp1.AddVehicle();
            this.updateCarDetails1 = new WindowsFormsApp1.UpdateCarDetails();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updateCarButton);
            this.panel2.Controls.Add(this.UpdatePersonalDetButton);
            this.panel2.Controls.Add(this.MakeClaimButton);
            this.panel2.Controls.Add(this.MakePaymentButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.AddCarButton);
            this.panel2.Controls.Add(this.UserLabel);
            this.panel2.Controls.Add(this.HomeButton);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 1054);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // MakeClaimButton
            // 
            this.MakeClaimButton.Location = new System.Drawing.Point(0, 619);
            this.MakeClaimButton.Name = "MakeClaimButton";
            this.MakeClaimButton.Size = new System.Drawing.Size(229, 99);
            this.MakeClaimButton.TabIndex = 6;
            this.MakeClaimButton.Text = "Make Claim";
            this.MakeClaimButton.UseVisualStyleBackColor = true;
            this.MakeClaimButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // MakePaymentButton
            // 
            this.MakePaymentButton.Location = new System.Drawing.Point(-1, 525);
            this.MakePaymentButton.Name = "MakePaymentButton";
            this.MakePaymentButton.Size = new System.Drawing.Size(230, 97);
            this.MakePaymentButton.TabIndex = 5;
            this.MakePaymentButton.Text = "Make Payment";
            this.MakePaymentButton.UseVisualStyleBackColor = true;
            this.MakePaymentButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 228);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AddCarButton
            // 
            this.AddCarButton.Location = new System.Drawing.Point(-1, 419);
            this.AddCarButton.Name = "AddCarButton";
            this.AddCarButton.Size = new System.Drawing.Size(230, 108);
            this.AddCarButton.TabIndex = 3;
            this.AddCarButton.Text = "Add Car";
            this.AddCarButton.UseVisualStyleBackColor = true;
            this.AddCarButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(89, 261);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(45, 20);
            this.UserLabel.TabIndex = 4;
            this.UserLabel.Text = "User";
            this.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.AllowDrop = true;
            this.HomeButton.Location = new System.Drawing.Point(-1, 309);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(230, 110);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdatePersonalDetButton
            // 
            this.UpdatePersonalDetButton.Location = new System.Drawing.Point(0, 715);
            this.UpdatePersonalDetButton.Name = "UpdatePersonalDetButton";
            this.UpdatePersonalDetButton.Size = new System.Drawing.Size(229, 106);
            this.UpdatePersonalDetButton.TabIndex = 11;
            this.UpdatePersonalDetButton.Text = "Update Personal Details";
            this.UpdatePersonalDetButton.UseVisualStyleBackColor = true;
            this.UpdatePersonalDetButton.Click += new System.EventHandler(this.UpdatePersonalDetButton_Click);
            // 
            // updateCarButton
            // 
            this.updateCarButton.Location = new System.Drawing.Point(-1, 818);
            this.updateCarButton.Name = "updateCarButton";
            this.updateCarButton.Size = new System.Drawing.Size(230, 93);
            this.updateCarButton.TabIndex = 12;
            this.updateCarButton.Text = "Update Car Details";
            this.updateCarButton.UseVisualStyleBackColor = true;
            this.updateCarButton.Click += new System.EventHandler(this.updateCarButton_Click);
            // 
            // updatePersonalInfo1
            // 
            this.updatePersonalInfo1.AutoScroll = true;
            this.updatePersonalInfo1.Location = new System.Drawing.Point(232, 4);
            this.updatePersonalInfo1.Name = "updatePersonalInfo1";
            this.updatePersonalInfo1.Size = new System.Drawing.Size(1134, 1051);
            this.updatePersonalInfo1.TabIndex = 11;
            // 
            // makeClaim2
            // 
            this.makeClaim2.AutoScroll = true;
            this.makeClaim2.Location = new System.Drawing.Point(232, 4);
            this.makeClaim2.Name = "makeClaim2";
            this.makeClaim2.Size = new System.Drawing.Size(1122, 828);
            this.makeClaim2.TabIndex = 10;
            // 
            // addVehicle2
            // 
            this.addVehicle2.AutoScroll = true;
            this.addVehicle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicle2.Location = new System.Drawing.Point(232, 4);
            this.addVehicle2.Name = "addVehicle2";
            this.addVehicle2.Size = new System.Drawing.Size(1134, 821);
            this.addVehicle2.TabIndex = 9;
            // 
            // paymentDetails1
            // 
            this.paymentDetails1.AutoScroll = true;
            this.paymentDetails1.Location = new System.Drawing.Point(232, 1);
            this.paymentDetails1.Name = "paymentDetails1";
            this.paymentDetails1.Size = new System.Drawing.Size(1134, 821);
            this.paymentDetails1.TabIndex = 8;
            // 
            // makeClaim1
            // 
            this.makeClaim1.AutoScroll = true;
            this.makeClaim1.Location = new System.Drawing.Point(381, 196);
            this.makeClaim1.Name = "makeClaim1";
            this.makeClaim1.Size = new System.Drawing.Size(1122, 957);
            this.makeClaim1.TabIndex = 7;
            // 
            // addVehicle1
            // 
            this.addVehicle1.AutoScroll = true;
            this.addVehicle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicle1.Location = new System.Drawing.Point(232, 4);
            this.addVehicle1.Name = "addVehicle1";
            this.addVehicle1.Size = new System.Drawing.Size(1122, 798);
            this.addVehicle1.TabIndex = 6;
            // 
            // updateCarDetails1
            // 
            this.updateCarDetails1.AutoScroll = true;
            this.updateCarDetails1.Location = new System.Drawing.Point(232, 4);
            this.updateCarDetails1.Name = "updateCarDetails1";
            this.updateCarDetails1.Size = new System.Drawing.Size(1134, 1051);
            this.updateCarDetails1.TabIndex = 12;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 1055);
            this.Controls.Add(this.updateCarDetails1);
            this.Controls.Add(this.updatePersonalInfo1);
            this.Controls.Add(this.makeClaim2);
            this.Controls.Add(this.addVehicle2);
            this.Controls.Add(this.paymentDetails1);
            this.Controls.Add(this.makeClaim1);
            this.Controls.Add(this.addVehicle1);
            this.Controls.Add(this.panel2);
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
        private System.Windows.Forms.Button MakePaymentButton;
        private System.Windows.Forms.Button MakeClaimButton;
        private AddVehicle addVehicle1;
        private MakeClaim makeClaim1;
        private PaymentDetails paymentDetails1;
        private AddVehicle addVehicle2;
        private MakeClaim makeClaim2;
        private System.Windows.Forms.Button UpdatePersonalDetButton;
        private UpdatePersonalInfo updatePersonalInfo1;
        private System.Windows.Forms.Button updateCarButton;
        private UpdateCarDetails updateCarDetails1;
    }
}