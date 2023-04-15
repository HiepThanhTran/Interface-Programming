using System.Drawing;
using System.Windows.Forms;

namespace LTGD_GK2019_2020_Crown_Anchor
{
    public partial class Form1_Intro : Form
    {
        private int imgWidth = 100;
        private int padding = 40;
        private Rectangle rect1;
        private Rectangle rect2;
        private int step = 10;
        private Image img1;
        private Image img2;

        public Form1_Intro()
        {
            InitializeComponent();
        }

        private void DrawImage(Graphics g)
        {
            g.DrawImage(img1, rect1);
            g.DrawImage(img2, rect2);
        }

        private void Form1_Intro_Load(object sender, System.EventArgs e)
        {
            rect1 = new Rectangle(padding, (ClientRectangle.Height - imgWidth) / 2, imgWidth, imgWidth);
            rect2 = new Rectangle(ClientRectangle.Width - imgWidth - padding, (ClientRectangle.Height - imgWidth) / 2, imgWidth, imgWidth);
            img1 = Image.FromFile(@"Hinh\bau.jpg");
            img2 = Image.FromFile(@"Hinh\cua.jpg");
        }

        private void Form1_Intro_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
            timer1.Start();
        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            rect1.X += step;
            rect2.X -= step;
            DrawImage(this.CreateGraphics());
            Invalidate();

            if (rect1.IntersectsWith(rect2))
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
