using System.Drawing;

namespace LTGD_BaiThucHanh8.model
{
    internal class Shape
    {
        private string type;
        private Color color;
        private Rectangle rect;
        private Point[] points;

        public string Type { get { return type; } set { type = value; } }
        public Color Color { get { return color; } set { color = value; } }
        public Rectangle Rect
        {
            get { return rect; }
            set
            {
                rect = value;
                this.points = new Point[]
                {
                    new Point(rect.X + rect.Width / 2, rect.Y),
                    new Point(rect.X, rect.Bottom),
                    new Point(rect.Right, rect.Bottom)
                };
            }
        }
        public Point[] Points { get { return points; } set { points = value; } }

        public Shape() { }

        public Shape(string type, Color color, Rectangle rect)
        {
            this.type = type;
            this.color = color;
            this.rect = rect;
            this.points = new Point[]
            {
                new Point(rect.X + rect.Width / 2, rect.Y),
                new Point(rect.X, rect.Bottom),
                new Point(rect.Right, rect.Bottom)
            };
        }

        public Shape(string type, Color color, Rectangle rect, Point[] points)
        {
            this.type = type;
            this.color = color;
            this.rect = rect;
            this.points = points;
        }

        public void Draw(Graphics g)
        {
            switch (this.type)
            {
                case "Rectangle": g.DrawRectangle(new Pen(this.color), this.rect); break;
                case "Ellipse": g.DrawEllipse(new Pen(this.color), this.rect); break;
                case "Triangle": g.DrawPolygon(new Pen(this.color), this.points); break;
            }
        }

        public void Fill(Graphics g)
        {
            switch (this.type)
            {
                case "Rectangle": g.FillRectangle(new SolidBrush(this.color), this.rect); break;
                case "Ellipse": g.FillEllipse(new SolidBrush(this.color), this.rect); break;
                case "Triangle": g.FillPolygon(new SolidBrush(this.color), this.points); break;
            }
        }
    }
}
