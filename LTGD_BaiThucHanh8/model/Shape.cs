using System.Drawing;

namespace LTGD_BaiThucHanh8.model
{
    public class Shape
    {
        private IDrawBehavior drawBehavior;
        private ShapeType type;
        private Rectangle rect;
        private Color color;

        public IDrawBehavior DrawBehavior { get { return drawBehavior; } set { drawBehavior = value; } }
        public ShapeType Type { get { return type; } set { type = value; } }
        public Rectangle Rect { get { return rect; } set { rect = value; } }
        public Color Color { get { return color; } set { color = value; } }

        public void Draw(Graphics g)
        {
            this.drawBehavior.Draw(g, this.color, this.rect);
        }

        public void Fill(Graphics g)
        {
            this.drawBehavior.Fill(g, this.color, this.rect);
        }
    }
}
