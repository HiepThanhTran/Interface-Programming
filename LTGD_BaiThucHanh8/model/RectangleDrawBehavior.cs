using System.Drawing;

namespace LTGD_BaiThucHanh8.model
{
    public class RectangleDrawBehavior : IDrawBehavior
    {
        public void Draw(Graphics g, Color color, Rectangle rect)
        {
            g.DrawRectangle(new Pen(color), rect);
        }

        public void Fill(Graphics g, Color color, Rectangle rect)
        {
            g.FillRectangle(new SolidBrush(color), rect);
        }
    }
}
