using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LTGD_GK2022_2023_MT_2
{
    public partial class FrmVe : Form
    {
        public FrmVe()
        {
            InitializeComponent();
        }

        private void FrmVe_Paint(object sender, PaintEventArgs e)
        {
            Image img1 = Image.FromFile("dragon.png");
            Image img2 = Image.FromFile("dragon.png");
            img1.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Rectangle rect1 = new Rectangle(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rect2 = new Rectangle(ClientRectangle.Width / 2, 0, ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rect3 = new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width, ClientRectangle.Height / 2);

            e.Graphics.DrawImage(img1, rect1);
            e.Graphics.DrawImage(img2, rect2);

            GraphicsPath gp = new GraphicsPath();
            gp.AddRectangle(rect3);
            PathGradientBrush pgb = new PathGradientBrush(gp)
            {
                CenterColor = Color.White,
                SurroundColors = new Color[] { Color.Orange }
            };
            e.Graphics.FillPath(pgb, gp);

            Font font = new Font("Arial", 74, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.OrangeRed);
            StringFormat format = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            e.Graphics.DrawString("Trần Thanh Hiệp", font, brush, rect3, format);
        }

        private void FrmVe_Resize(object sender, System.EventArgs e)
        {
            Invalidate();
        }
    }
}
