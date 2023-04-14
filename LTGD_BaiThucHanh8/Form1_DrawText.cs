using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh8
{
    public partial class Form1_DrawText : Form
    {
        public Form1_DrawText()
        {
            InitializeComponent();
        }

        private void Form1_Sub_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Arial", 60, FontStyle.Bold);
            StringFormat format = new StringFormat();

            format.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("HELLO", font, Brushes.DarkGreen, ClientRectangle, format);

            TextureBrush textureBrush = new TextureBrush(Image.FromFile(Application.StartupPath + @"\hoa.png"));
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("HELLO", font, textureBrush, ClientRectangle, format);

            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DarkVertical, Color.Yellow, Color.Red);
            format.FormatFlags = StringFormatFlags.DirectionVertical;
            format.LineAlignment = StringAlignment.Near;
            e.Graphics.DrawString("HELLO", font, hatchBrush, ClientRectangle, format);

            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(50, 50, 10, 10), Color.Blue, Color.White, 45);
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("HELLO", font, linearGradientBrush, ClientRectangle, format);
        }

        private void Form1_Sub_SizeChanged(object sender, System.EventArgs e)
        {
            Invalidate();
        }
    }
}
