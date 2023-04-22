using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string Shape;
        public static Brush Brush;
        public static bool IsDraw;

        private Bitmap bmp;
        private Rectangle rc1;
        private Rectangle rc2;
        private Rectangle rc3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsDraw = true;
            Shape = "Triangle";
            Brush = new SolidBrush(Color.Red);
            rc1 = new Rectangle(70, 90, 100, 80);
            rc2 = new Rectangle(300, 240, 130, 90);
            rc3 = new Rectangle(670, 130, 150, 70);
            bmp = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (IsDraw)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(BackColor);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                switch (Shape)
                {
                    case "Rectangle":
                        g.FillRectangle(Brush, rc1);
                        g.FillRectangle(Brush, rc2);
                        g.FillRectangle(Brush, rc3);
                        break;
                    case "Ellipse":
                        g.FillEllipse(Brush, rc1);
                        g.FillEllipse(Brush, rc2);
                        g.FillEllipse(Brush, rc3);
                        break;
                    case "Triangle":
                        Point[] arrP1 = new Point[]
                        {
                        new Point(rc1.Left + rc1.Width/2, rc1.Top),
                        new Point(rc1.Left, rc1.Bottom),
                        new Point(rc1.Right, rc1.Bottom)
                        };
                        Point[] arrP2 = new Point[]
                        {
                        new Point(rc2.Left + rc2.Width/2, rc2.Top),
                        new Point(rc2.Left, rc2.Bottom),
                        new Point(rc2.Right, rc2.Bottom)
                        };
                        Point[] arrP3 = new Point[]
                        {
                        new Point(rc3.Left + rc3.Width/2, rc3.Top),
                        new Point(rc3.Left, rc3.Bottom),
                        new Point(rc3.Right, rc3.Bottom)
                        };
                        g.FillPolygon(Brush, arrP1);
                        g.FillPolygon(Brush, arrP2);
                        g.FillPolygon(Brush, arrP3);
                        break;
                }
                e.Graphics.DrawImage(bmp, 0, 0);
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(BackColor);
            IsDraw = false;
            Invalidate();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOption_Click(object sender, EventArgs e)
        {
            Form1_Option options = new Form1_Option(this);
            options.ShowDialog();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
