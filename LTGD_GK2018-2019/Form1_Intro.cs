using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LTGD_GK2018_2019
{
    public partial class Form1_Intro : Form
    {
        private int count = 0;

        public Form1_Intro()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Tô nền
            LinearGradientBrush linearBrush = new LinearGradientBrush(ClientRectangle, Color.Red, Color.Yellow, 45);
            e.Graphics.FillRectangle(linearBrush, ClientRectangle);

            // Vẽ chữ
            Font font = new Font("Arial", 36, FontStyle.Bold | FontStyle.Italic);
            Brush brush = new HatchBrush(HatchStyle.Percent10, Color.Blue, Color.White);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("Trần Thanh Hiệp", font, brush, ClientRectangle, format);
        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            count++;
            if (count == 3)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
