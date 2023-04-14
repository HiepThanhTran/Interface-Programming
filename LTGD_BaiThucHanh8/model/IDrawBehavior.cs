using System.Drawing;

namespace LTGD_BaiThucHanh8.model
{
    public interface IDrawBehavior
    {
        void Draw(Graphics g, Color color, Rectangle rect);
        void Fill(Graphics g, Color color, Rectangle rect);
    }
}
