using System.Drawing;

namespace LTGD_BaiThucHanh8.model
{
    public class EllipseDrawBehavior : IDrawBehavior
    {
        public void Draw(Graphics g, Color color, Rectangle rect)
        {
            g.DrawEllipse(new Pen(color), rect);
        }

        public void Fill(Graphics g, Color color, Rectangle rect)
        {
            g.FillEllipse(new SolidBrush(color), rect);
        }
    }
}
