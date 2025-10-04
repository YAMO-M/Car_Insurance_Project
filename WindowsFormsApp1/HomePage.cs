using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            
        }
       

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // pictureBox1.Image = Properties.Resources.cars; // "car" is the resource name
           // pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.BackgroundImage != null)
            {
                float controlAspect = (float)this.Width / this.Height;
                float imageAspect = (float)BackgroundImage.Width / BackgroundImage.Height;

                Rectangle drawRect;

                if (controlAspect > imageAspect)
                {
                    // Control is wider → match width, crop height
                    int scaledHeight = (int)(this.Width / (float)BackgroundImage.Width * BackgroundImage.Height);
                    int offsetY = (this.Height - scaledHeight) / 2;
                    drawRect = new Rectangle(0, offsetY, this.Width, scaledHeight);
                }
                else
                {
                    // Control is taller → match height, crop width
                    int scaledWidth = (int)(this.Height / (float)BackgroundImage.Height * BackgroundImage.Width);
                    int offsetX = (this.Width - scaledWidth) / 2;
                    drawRect = new Rectangle(offsetX, 0, scaledWidth, this.Height);
                }

                e.Graphics.DrawImage(BackgroundImage, drawRect);
            }
        }

        private void PolicyBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
