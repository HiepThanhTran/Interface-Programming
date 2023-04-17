using System.Drawing;

namespace LTGD_GK2022_2023_MT.model
{
    public class MyShape
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private int thickness;
        private Color backColor;
        private Color borderColor;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public int Thickness { get => thickness; set => thickness = value; }
        public Color BackColor { get => backColor; set => backColor = value; }
        public Color BorderColor { get => borderColor; set => borderColor = value; }

        public MyShape() { }

        public MyShape(Rectangle rect, int thickness, Color backColor, Color borderColor)
        {
            this.X = rect.X;
            this.Y = rect.Y;
            this.Width = rect.Width;
            this.Height = rect.Height;
            this.Thickness = thickness;
            this.BackColor = backColor;
            this.BorderColor = borderColor;
        }

        public MyShape(int x, int y, int width, int height, int thickness, Color backColor, Color borderColor)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Thickness = thickness;
            this.BackColor = backColor;
            this.BorderColor = borderColor;
        }
    }
}
