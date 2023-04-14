using System.Drawing;

namespace LTGD_BaiThucHanh8.model
{
    public class TriangleDrawBehavior : IDrawBehavior
    {
        public void Draw(Graphics g, Color color, Rectangle rect)
        {
            Point[] points = GetPoints(rect);
            g.DrawPolygon(new Pen(color), points);
        }

        public void Fill(Graphics g, Color color, Rectangle rect)
        {
            Point[] points = GetPoints(rect);
            g.FillPolygon(new SolidBrush(color), points);
        }

        private Point[] GetPoints(Rectangle rect)
        {
            Point[] points = new Point[]
            {
            new Point(rect.X + rect.Width / 2, rect.Y),
            new Point(rect.X, rect.Bottom),
            new Point(rect.Right, rect.Bottom)
            };
            return points;
        }
    }
}
