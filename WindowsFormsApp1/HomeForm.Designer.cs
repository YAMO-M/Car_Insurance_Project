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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolicyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.makeClaimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePage2 = new WindowsFormsApp1.HomePage();
            this.searchPage1 = new WindowsFormsApp1.SearchPage();
            this.addVehicle3 = new WindowsFormsApp1.AddVehicle();
            this.makeClaim3 = new WindowsFormsApp1.MakeClaim();
            this.homePage1 = new WindowsFormsApp1.HomePage();
            this.updatePersonalInfo1 = new WindowsFormsApp1.AddClient();
            this.makeClaim2 = new WindowsFormsApp1.MakeClaim();
            this.makeClaim1 = new WindowsFormsApp1.MakeClaim();
            this.addClient1 = new WindowsFormsApp1.AddClient();
            this.makeClaim4 = new WindowsFormsApp1.MakeClaim();
            this.addVehicle2 = new WindowsFormsApp1.AddVehicle();
            this.addVehicle1 = new WindowsFormsApp1.AddVehicle();
            this.homePage3 = new WindowsFormsApp1.HomePage();
            this.addClient2 = new WindowsFormsApp1.AddClient();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addPolicyToolStripMenuItem,
            this.addClientToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // addPolicyToolStripMenuItem
            // 
            this.addPolicyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPolicyToolStripMenuItem1,
            this.makeClaimToolStripMenuItem1});
            this.addPolicyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.addPolicyToolStripMenuItem.Name = "addPolicyToolStripMenuItem";
            this.addPolicyToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.addPolicyToolStripMenuItem.Text = "Policy";
            this.addPolicyToolStripMenuItem.Click += new System.EventHandler(this.addPolicyToolStripMenuItem1_Click);
            // 
            // addPolicyToolStripMenuItem1
            // 
            this.addPolicyToolStripMenuItem1.Name = "addPolicyToolStripMenuItem1";
            this.addPolicyToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.addPolicyToolStripMenuItem1.Text = "Add Policy";
            this.addPolicyToolStripMenuItem1.Click += new System.EventHandler(this.addPolicyToolStripMenuItem1_Click);
            // 
            // makeClaimToolStripMenuItem1
            // 
            this.makeClaimToolStripMenuItem1.Name = "makeClaimToolStripMenuItem1";
            this.makeClaimToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.makeClaimToolStripMenuItem1.Text = "Make Claim";
            this.makeClaimToolStripMenuItem1.Click += new System.EventHandler(this.makeClaimToolStripMenuItem1_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem1});
            this.addClientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.addClientToolStripMenuItem.Text = "Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem1_Click);
            // 
            // addClientToolStripMenuItem1
            // 
            this.addClientToolStripMenuItem1.Name = "addClientToolStripMenuItem1";
            this.addClientToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.addClientToolStripMenuItem1.Text = "Add Client";
            this.addClientToolStripMenuItem1.Click += new System.EventHandler(this.addClientToolStripMenuItem1_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // homePage2
            // 
            this.homePage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePage2.BackgroundImage")));
            this.homePage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePage2.Location = new System.Drawing.Point(0, 26);
            this.homePage2.Margin = new System.Windows.Forms.Padding(2);
            this.homePage2.Name = "homePage2";
            this.homePage2.Size = new System.Drawing.Size(1568, 1125);
            this.homePage2.TabIndex = 20;
            // 
            // searchPage1
            // 
            this.searchPage1.AutoScroll = true;
            this.searchPage1.Location = new System.Drawing.Point(0, 26);
            this.searchPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchPage1.Name = "searchPage1";
            this.searchPage1.Size = new System.Drawing.Size(1116, 697);
            this.searchPage1.TabIndex = 19;
            // 
            // addVehicle3
            // 
            this.addVehicle3.AutoScroll = true;
            this.addVehicle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicle3.Location = new System.Drawing.Point(61, 310);
            this.addVehicle3.Margin = new System.Windows.Forms.Padding(2);
            this.addVehicle3.Name = "addVehicle3";
            this.addVehicle3.Size = new System.Drawing.Size(1221, 518);
            this.addVehicle3.TabIndex = 18;
            // 
            // makeClaim3
            // 
            this.makeClaim3.AutoScroll = true;
            this.makeClaim3.BackColor = System.Drawing.SystemColors.Control;
            this.makeClaim3.Location = new System.Drawing.Point(0, 27);
            this.makeClaim3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.makeClaim3.Name = "makeClaim3";
            this.makeClaim3.Size = new System.Drawing.Size(1568, 1125);
            this.makeClaim3.TabIndex = 17;
            // 
            // homePage1
            // 
            this.homePage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePage1.BackgroundImage")));
            this.homePage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePage1.Location = new System.Drawing.Point(61, 87);
            this.homePage1.Margin = new System.Windows.Forms.Padding(2);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(1394, 937);
            this.homePage1.TabIndex = 14;
            // 
            // updatePersonalInfo1
            // 
            this.updatePersonalInfo1.AutoScroll = true;
            this.updatePersonalInfo1.Location = new System.Drawing.Point(34, 89);
            this.updatePersonalInfo1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.updatePersonalInfo1.Name = "updatePersonalInfo1";
            this.updatePersonalInfo1.Size = new System.Drawing.Size(1116, 831);
            this.updatePersonalInfo1.TabIndex = 11;
            // 
            // makeClaim2
            // 
            this.makeClaim2.AutoScroll = true;
            this.makeClaim2.BackColor = System.Drawing.SystemColors.Control;
            this.makeClaim2.Location = new System.Drawing.Point(9, 109);
            this.makeClaim2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.makeClaim2.Name = "makeClaim2";
            this.makeClaim2.Size = new System.Drawing.Size(1178, 760);
            this.makeClaim2.TabIndex = 10;
            // 
            // makeClaim1
            // 
            this.makeClaim1.AutoScroll = true;
            this.makeClaim1.BackColor = System.Drawing.SystemColors.Control;
            this.makeClaim1.Location = new System.Drawing.Point(286, 159);
            this.makeClaim1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.makeClaim1.Name = "makeClaim1";
            this.makeClaim1.Size = new System.Drawing.Size(842, 777);
            this.makeClaim1.TabIndex = 7;
            // 
            // addClient1
            // 
            this.addClient1.Location = new System.Drawing.Point(0, 0);
            this.addClient1.Margin = new System.Windows.Forms.Padding(2);
            this.addClient1.Name = "addClient1";
            this.addClient1.Size = new System.Drawing.Size(867, 545);
            this.addClient1.TabIndex = 0;
            // 
            // makeClaim4
            // 
            this.makeClaim4.AutoScroll = true;
            this.makeClaim4.BackColor = System.Drawing.SystemColors.Control;
            this.makeClaim4.Location = new System.Drawing.Point(-11, 38);
            this.makeClaim4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.makeClaim4.Name = "makeClaim4";
            this.makeClaim4.Size = new System.Drawing.Size(1935, 1078);
            this.makeClaim4.TabIndex = 20;
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
            // 
            // homePage3
            // 
            this.homePage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePage3.BackgroundImage")));
            this.homePage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePage3.Location = new System.Drawing.Point(0, 37);
            this.homePage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePage3.Name = "homePage3";
            this.homePage3.Size = new System.Drawing.Size(1778, 1034);
            this.homePage3.TabIndex = 22;
            this.homePage3.Load += new System.EventHandler(this.homePage3_Load);
            // 
            // addClient2
            // 
            this.addClient2.Location = new System.Drawing.Point(0, 26);
            this.addClient2.Margin = new System.Windows.Forms.Padding(2);
            this.addClient2.Name = "addClient2";
            this.addClient2.Size = new System.Drawing.Size(1568, 1125);
            this.addClient2.TabIndex = 21;
            this.addClient2.Load += new System.EventHandler(this.addClient2_Load);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.addClient2);
            this.Controls.Add(this.homePage2);
            this.Controls.Add(this.searchPage1);
            this.Controls.Add(this.addVehicle3);
            this.Controls.Add(this.makeClaim3);
            this.Controls.Add(this.homePage1);
            this.Controls.Add(this.updatePersonalInfo1);
            this.Controls.Add(this.makeClaim2);
            this.Controls.Add(this.makeClaim1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "HomeForm";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AddVehicle addVehicle1;
        private MakeClaim makeClaim1;
        private AddVehicle addVehicle2;
        private MakeClaim makeClaim2;
        private AddClient updatePersonalInfo1;
        //private UpdateCarDetails updateCarDetails1;
        //private PolicyPage policyPage1;
        private HomePage homePage1;
        //private UpdateCarDetails updateCarDetails2;
        private MakeClaim makeClaim3;
        private AddVehicle addVehicle3;
        private SearchPage searchPage1;
        private HomePage homePage2;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPolicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPolicyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem makeClaimToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private MakeClaim makeClaim4;
        private AddClient addClient1;
        private HomePage homePage3;
        private AddClient addClient2;
    }
}