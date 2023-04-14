using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LTGD_GK2021_2022
{
    public partial class Form1_Intro : Form
    {
        private int imgWidth = 150;
        private int imgHeight = 80;
        private Rectangle rect1;
        private Rectangle rect2;
        private int step = 10;
        private string path;
        private Image img1;
        private Image img2;

        public Form1_Intro()
        {
            InitializeComponent();
        }

        private void Form1_Intro_Load(object sender, System.EventArgs e)
        {
            // Hình bên trái
            rect1 = new Rectangle(ClientRectangle.Width - (ClientRectangle.Width - imgWidth - 10) - imgWidth, ClientRectangle.Height - imgHeight - 5, imgWidth, imgHeight);
            // Hình bên phải
            rect2 = new Rectangle(ClientRectangle.Width - imgWidth - 10, ClientRectangle.Height - imgHeight - 5, imgWidth, imgHeight);

            path = Application.StartupPath + @"\bird.png";
            img1 = Image.FromFile(path);
            img2 = Image.FromFile(path);
            img1.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        private void Form1_Intro_Paint(object sender, PaintEventArgs e)
        {
            // Tô nền
            LinearGradientBrush linearBrush = new LinearGradientBrush(ClientRectangle, Color.Yellow, Color.Red, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(linearBrush, ClientRectangle);

            // Vẽ chữ
            Font font = new Font("Arial", 36, FontStyle.Bold);
            Brush brush = new HatchBrush(HatchStyle.Percent10, Color.White, Color.Blue);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            e.Graphics.DrawString("Trần Thanh Hiệp", font, brush, ClientRectangle, format);

            // Vẽ hình
            DrawImage(e.Graphics);

            timer1.Start();
        }

        private void DrawImage(Graphics g)
        {
            g.DrawImage(img1, rect1);
            g.DrawImage(img2, rect2);
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
