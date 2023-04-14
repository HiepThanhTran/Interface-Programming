using System.Drawing;
using System.Windows.Forms;

namespace LTGD_GK2018_2019
{
    public partial class Form1_Image : Form
    {
        private int stepX = 10;

        public Form1_Image()
        {
            InitializeComponent();
        }

        private void Form1_Image_Load(object sender, System.EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("dragon.png");
        }

        private void OpenToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Jpeg file(*.jpeg) |*.jpeg" +
                "| Gif file(*.gif) |*.gif" +
                "| Png file(*.png) |*.png" +
                "| Bitmap file(*.bmp) |*.bmp";
            if (od.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(od.FileName);
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    if (pictureBox1.Right <= 0)
                    {
                        pictureBox1.Left = ClientRectangle.Width;
                    }
                    pictureBox1.Left -= stepX;
                    break;
                case Keys.Right:
                    if (pictureBox1.Left >= ClientRectangle.Width)
                    {
                        pictureBox1.Left = -pictureBox1.Width;
                    }
                    pictureBox1.Left += stepX;
                    break;
            }
            return true;
        }
    }
}
