using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh8
{
    public partial class Form1_DrawImage : Form
    {
        public Form1_DrawImage()
        {
            InitializeComponent();
        }

        private void Form1_DrawImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc1 = new Rectangle(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc2 = new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rc3 = new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height);
            DrawImage(rc1, e.Graphics);
            DrawText(rc2, e.Graphics);
            DrawPolygon(rc3, e.Graphics);
        }

        private void DrawImage(Rectangle rc, Graphics g)
        {
            Image img = Image.FromFile(Application.StartupPath + @"\img.png");
            g.DrawImage(img, rc);
            SolidBrush br = new SolidBrush(Color.FromArgb(50, 255, 255, 0));
            Font font = new Font("Arial", 36, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Far;
            g.DrawString("Anita", font, br, rc, format);
            g.Dispose();
        }

        private void DrawText(Rectangle rc, Graphics g)
        {
            LinearGradientBrush linearBr1 = new LinearGradientBrush(rc, Color.Black, Color.White, 45);
            g.FillRectangle(linearBr1, rc);
            LinearGradientBrush linearBr2 = new LinearGradientBrush(new Rectangle(0, 0, 40, 40), Color.Red, Color.Yellow, LinearGradientMode.BackwardDiagonal);
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Font font = new Font("Arial", 48, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("HELLO", font, linearBr2, rc, format);
            g.Dispose();
        }

        private void DrawPolygon(Rectangle rc, Graphics g)
        {
            Point[] arrPoint =
            {
                new Point(rc.Left, rc.Height / 4),
                new Point(rc.Left + rc.Width / 2, 0),
                new Point(rc.Left + rc.Width, rc.Height / 4),
                new Point(rc.Left + rc.Width / 2, rc.Height)
            };
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(arrPoint);
            PathGradientBrush pathBr = new PathGradientBrush(path);
            pathBr.CenterColor = Color.White;
            Color[] arrColor =
            {
                Color.Red,
                Color.Yellow,
                Color.Cyan
            };
            pathBr.SurroundColors = arrColor;
            g.FillPolygon(pathBr, arrPoint);
            g.Dispose();
        }

        private void Form1_DrawImage_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
