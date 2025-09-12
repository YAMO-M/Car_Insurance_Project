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
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cornfirmnmaskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Final Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "E - Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password :";
            // 
            // passwordTextBox1
            // 
            this.passwordTextBox1.Location = new System.Drawing.Point(289, 141);
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Size = new System.Drawing.Size(245, 20);
            this.passwordTextBox1.TabIndex = 4;
            // 
            // cornfirmnmaskedTextBox2
            // 
            this.cornfirmnmaskedTextBox2.Location = new System.Drawing.Point(289, 197);
            this.cornfirmnmaskedTextBox2.Name = "cornfirmnmaskedTextBox2";
            this.cornfirmnmaskedTextBox2.Size = new System.Drawing.Size(245, 20);
            this.cornfirmnmaskedTextBox2.TabIndex = 5;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(289, 88);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(245, 20);
            this.emailTextbox.TabIndex = 6;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(317, 427);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 7;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // CreateAccountFormFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.cornfirmnmaskedTextBox2);
            this.Controls.Add(this.passwordTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateAccountFormFinal";
            this.Size = new System.Drawing.Size(896, 857);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox passwordTextBox1;
        private System.Windows.Forms.MaskedTextBox cornfirmnmaskedTextBox2;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Button Submit;
    }
}
