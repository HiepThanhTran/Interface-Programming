using System.Drawing;

namespace LTGD_BaiThucHanh8.model
{
    public class Shape
    {
        private ShapeType type;
        private Rectangle rect;
        private Color color;

        public IDrawBehavior DrawBehavior { get; set; }
        public ShapeType Type { get => type; set => type = value; }
        public Rectangle Rect { get => rect; set => rect = value; }
        public Color Color { get => color; set => color = value; }
        public int X { get => rect.X; set => rect.X = value; }
        public int Y { get => rect.Y; set => rect.Y = value; }
        public int Width { get => rect.Width; set => rect.Width = value; }
        public int Height { get => rect.Height; set => rect.Height = value; }

        public void Draw(Graphics g)
        {
            DrawBehavior.Draw(g, this.color, this.rect);
        }

        public void Fill(Graphics g)
        {
            DrawBehavior.Fill(g, this.color, this.rect);
        }
    }
}
