using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh8
{
    public partial class Form1_DrawByMouse : Form
    {
        private Color penColor;
        private int penWidth;
        private Point pOld;
        private Bitmap bmp;

        public Form1_DrawByMouse()
        {
            InitializeComponent();
        }

        private void Form1_DrawByMouse_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            penColor = Color.Red;
            penWidth = 1;
        }

        private void Form1_DrawByMouse_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void Form1_DrawByMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(penColor, penWidth);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate();
                g.Dispose();
            }
        }

        private void Form1_DrawByMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.R: penColor = Color.Red; break;
                case Keys.G: penColor = Color.Green; break;
                case Keys.B: penColor = Color.Blue; break;
                case Keys.Up: penWidth++; break;
                case Keys.Down: penWidth--; break;
            }
            return true;
        }
    }
}
