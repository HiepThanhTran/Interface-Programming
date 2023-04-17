using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTGD_GK2022_2023
{
    public partial class Form3 : Form
    {
        private Random rand = new Random();
        private Point blueRectTopLeft;
        private Point redRectTopLeft;
        private int thickness;
        private int diameter;

        public Form3()
        {
            InitializeComponent();
        }

        #region CustomFunction

        private bool CheckDistance(Point center, Point other)
        {
            double distance = Math.Sqrt(Math.Pow(other.X - center.X, 2) + Math.Pow(other.Y - center.Y, 2));
            return distance < diameter / 2 - thickness;
        }

        private void DrawRandomPointInCircle(int centerX, int centerY, int radius, Color color)
        {
            int x = rand.Next(centerX - radius, centerX + radius);
            int y = rand.Next(centerY - radius, centerY + radius);
            while (!CheckDistance(new Point(centerX, centerY), new Point(x, y)))
            {
                x = rand.Next(centerX - radius, centerX + radius);
                y = rand.Next(centerY - radius, centerY + radius);
            }
            Graphics g = this.CreateGraphics();
            g.FillEllipse(new SolidBrush(color), x, y, 7, 7);
            g.Dispose();
        }

        #endregion

        private void Form3_Load(object sender, EventArgs e)
        {
            blueRectTopLeft = new Point(400, 150);
            redRectTopLeft = new Point(50, 150);
            diameter = 300;
            thickness = 5;
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rectRed = new Rectangle(redRectTopLeft.X, redRectTopLeft.Y, diameter, diameter);
            Rectangle rectBlue = new Rectangle(blueRectTopLeft.X, blueRectTopLeft.Y, diameter, diameter);
            e.Graphics.DrawEllipse(new Pen(Color.Red, thickness), rectRed);
            e.Graphics.DrawEllipse(new Pen(Color.Blue, thickness), rectBlue);
        }

        private void BtnXepLoai_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                if (number % 2 == 0)
                {
                    DrawRandomPointInCircle(redRectTopLeft.X + diameter / 2, redRectTopLeft.Y + diameter / 2, diameter / 2, Color.Red);
                }
                if (number % 3 == 0)
                {
                    DrawRandomPointInCircle(blueRectTopLeft.X + diameter / 2, blueRectTopLeft.Y + diameter / 2, diameter / 2, Color.Blue);
                }
            }
        }
    }
}
