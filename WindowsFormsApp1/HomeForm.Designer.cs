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
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicle4 = new WindowsFormsApp1.AddVehicle();
            this.searchPage2 = new WindowsFormsApp1.SearchPage();
            this.makeClaim1 = new WindowsFormsApp1.MakeClaim();
            this.addClient3 = new WindowsFormsApp1.AddClient();
            this.homePage4 = new WindowsFormsApp1.HomePage();
            this.update1 = new WindowsFormsApp1.Update();
            this.addClient2 = new WindowsFormsApp1.AddClient();
            this.searchPage1 = new WindowsFormsApp1.SearchPage();
            this.addVehicle3 = new WindowsFormsApp1.AddVehicle();
            this.makeClaim3 = new WindowsFormsApp1.MakeClaim();
            this.updatePersonalInfo1 = new WindowsFormsApp1.AddClient();
            this.addClient1 = new WindowsFormsApp1.AddClient();
            this.makeClaim4 = new WindowsFormsApp1.MakeClaim();
            this.addVehicle2 = new WindowsFormsApp1.AddVehicle();
            this.addVehicle1 = new WindowsFormsApp1.AddVehicle();
            this.homePage3 = new WindowsFormsApp1.HomePage();
            this.homePage1 = new WindowsFormsApp1.HomePage();
            this.homePage2 = new WindowsFormsApp1.HomePage();
            this.update2 = new WindowsFormsApp1.Update();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.addPolicyToolStripMenuItem,
            this.addClientToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1854, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
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
            this.addPolicyToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.addPolicyToolStripMenuItem.Text = "Policy";
            this.addPolicyToolStripMenuItem.Click += new System.EventHandler(this.addPolicyToolStripMenuItem1_Click);
            // 
            // addPolicyToolStripMenuItem1
            // 
            this.addPolicyToolStripMenuItem1.Name = "addPolicyToolStripMenuItem1";
            this.addPolicyToolStripMenuItem1.Size = new System.Drawing.Size(213, 34);
            this.addPolicyToolStripMenuItem1.Text = "Add Policy";
            this.addPolicyToolStripMenuItem1.Click += new System.EventHandler(this.addPolicyToolStripMenuItem1_Click);
            // 
            // makeClaimToolStripMenuItem1
            // 
            this.makeClaimToolStripMenuItem1.Name = "makeClaimToolStripMenuItem1";
            this.makeClaimToolStripMenuItem1.Size = new System.Drawing.Size(213, 34);
            this.makeClaimToolStripMenuItem1.Text = "Make Claim";
            this.makeClaimToolStripMenuItem1.Click += new System.EventHandler(this.makeClaimToolStripMenuItem1_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem1});
            this.addClientToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.addClientToolStripMenuItem.Text = "Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem1_Click);
            // 
            // addClientToolStripMenuItem1
            // 
            this.addClientToolStripMenuItem1.Name = "addClientToolStripMenuItem1";
            this.addClientToolStripMenuItem1.Size = new System.Drawing.Size(203, 34);
            this.addClientToolStripMenuItem1.Text = "Add Client";
            this.addClientToolStripMenuItem1.Click += new System.EventHandler(this.addClientToolStripMenuItem1_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // addVehicle4
            // 
            this.addVehicle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicle4.Location = new System.Drawing.Point(-19, 31);
            this.addVehicle4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addVehicle4.Name = "addVehicle4";
            this.addVehicle4.Size = new System.Drawing.Size(1851, 971);
            this.addVehicle4.TabIndex = 6;
            this.addVehicle4.Load += new System.EventHandler(this.addVehicle4_Load);
            // 
            // searchPage2
            // 
            this.searchPage2.AutoScroll = true;
            this.searchPage2.Location = new System.Drawing.Point(0, 31);
            this.searchPage2.Margin = new System.Windows.Forms.Padding(2);
            this.searchPage2.Name = "searchPage2";
            this.searchPage2.Size = new System.Drawing.Size(1156, 728);
            this.searchPage2.TabIndex = 5;
            // 
            // makeClaim1
            // 
            this.makeClaim1.AutoScroll = true;
            this.makeClaim1.BackColor = System.Drawing.SystemColors.Control;
            this.makeClaim1.Location = new System.Drawing.Point(0, 34);
            this.makeClaim1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.makeClaim1.Name = "makeClaim1";
            this.makeClaim1.Size = new System.Drawing.Size(1156, 728);
            this.makeClaim1.TabIndex = 4;
            // 
            // addClient3
            // 
            this.addClient3.BackColor = System.Drawing.SystemColors.Control;
            this.addClient3.Location = new System.Drawing.Point(0, 34);
            this.addClient3.Margin = new System.Windows.Forms.Padding(2);
            this.addClient3.Name = "addClient3";
            this.addClient3.Size = new System.Drawing.Size(1156, 728);
            this.addClient3.TabIndex = 3;
            // 
            // homePage4
            // 
            this.homePage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePage4.BackgroundImage")));
            this.homePage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePage4.Location = new System.Drawing.Point(0, 31);
            this.homePage4.Margin = new System.Windows.Forms.Padding(1);
            this.homePage4.Name = "homePage4";
            this.homePage4.Size = new System.Drawing.Size(1156, 730);
            this.homePage4.TabIndex = 1;
            // 
            // update1
            // 
            this.update1.Location = new System.Drawing.Point(0, 27);
            this.update1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update1.Name = "update1";
            this.update1.Size = new System.Drawing.Size(1028, 582);
            this.update1.TabIndex = 2;
            // 
            // addClient2
            // 
            this.addClient2.BackColor = System.Drawing.SystemColors.Control;
            this.addClient2.Location = new System.Drawing.Point(0, 24);
            this.addClient2.Margin = new System.Windows.Forms.Padding(2);
            this.addClient2.Name = "addClient2";
            this.addClient2.Size = new System.Drawing.Size(1568, 1127);
            this.addClient2.TabIndex = 21;
            this.addClient2.Load += new System.EventHandler(this.addClient2_Load_1);
            // 
            // searchPage1
            // 
            this.searchPage1.AutoScroll = true;
            this.searchPage1.Location = new System.Drawing.Point(0, 24);
            this.searchPage1.Margin = new System.Windows.Forms.Padding(2);
            this.searchPage1.Name = "searchPage1";
            this.searchPage1.Size = new System.Drawing.Size(1488, 858);
            this.searchPage1.TabIndex = 19;
            // 
            // addVehicle3
            // 
            this.addVehicle3.AutoScroll = true;
            this.addVehicle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicle3.Location = new System.Drawing.Point(81, 382);
            this.addVehicle3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addVehicle3.Name = "addVehicle3";
            this.addVehicle3.Size = new System.Drawing.Size(1628, 638);
            this.addVehicle3.TabIndex = 18;
            // 
            // makeClaim3
            // 
            this.makeClaim3.AutoScroll = true;
            this.makeClaim3.BackColor = System.Drawing.SystemColors.Control;
            this.makeClaim3.Location = new System.Drawing.Point(0, 33);
            this.makeClaim3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.makeClaim3.Name = "makeClaim3";
            this.makeClaim3.Size = new System.Drawing.Size(2091, 1385);
            this.makeClaim3.TabIndex = 17;
            // 
            // updatePersonalInfo1
            // 
            this.updatePersonalInfo1.AutoScroll = true;
            this.updatePersonalInfo1.BackColor = System.Drawing.SystemColors.Control;
            this.updatePersonalInfo1.Location = new System.Drawing.Point(0, 39);
            this.updatePersonalInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updatePersonalInfo1.Name = "updatePersonalInfo1";
            this.updatePersonalInfo1.Size = new System.Drawing.Size(1488, 1023);
            this.updatePersonalInfo1.TabIndex = 11;
            // 
            // addClient1
            // 
            this.addClient1.BackColor = System.Drawing.SystemColors.Control;
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
            this.makeClaim4.Location = new System.Drawing.Point(0, 0);
            this.makeClaim4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.makeClaim4.Name = "makeClaim4";
            this.makeClaim4.Size = new System.Drawing.Size(1580, 827);
            this.makeClaim4.TabIndex = 0;
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
            // homePage1
            // 
            this.homePage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePage1.BackgroundImage")));
            this.homePage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePage1.Location = new System.Drawing.Point(0, 30);
            this.homePage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(1394, 937);
            this.homePage1.TabIndex = 14;
            // 
            // homePage2
            // 
            this.homePage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homePage2.BackgroundImage")));
            this.homePage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homePage2.Location = new System.Drawing.Point(-13, 34);
            this.homePage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePage2.Name = "homePage2";
            this.homePage2.Size = new System.Drawing.Size(2091, 1385);
            this.homePage2.TabIndex = 20;
            this.homePage2.Load += new System.EventHandler(this.homePage3_Load);
            // 
            // update2
            // 
            this.update2.Location = new System.Drawing.Point(-48, 31);
            this.update2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update2.Name = "update2";
            this.update2.Size = new System.Drawing.Size(2352, 1734);
            this.update2.TabIndex = 7;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 1034);
            this.Controls.Add(this.update2);
            this.Controls.Add(this.addVehicle4);
            this.Controls.Add(this.searchPage2);
            this.Controls.Add(this.makeClaim1);
            this.Controls.Add(this.addClient3);
            this.Controls.Add(this.homePage4);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
        private AddVehicle addVehicle2;
        private AddClient updatePersonalInfo1;
        //private UpdateCarDetails updateCarDetails2;
        private MakeClaim makeClaim3;
        private AddVehicle addVehicle3;
        private SearchPage searchPage1;
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
        private AddClient addClient2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private HomePage homePage3;
        private HomePage homePage1;
        private HomePage homePage2;
        private HomePage homePage4;
        private Update update1;
        private AddClient addClient3;
        private MakeClaim makeClaim1;
        private SearchPage searchPage2;
        private AddVehicle addVehicle4;
        private Update update2;
    }
}