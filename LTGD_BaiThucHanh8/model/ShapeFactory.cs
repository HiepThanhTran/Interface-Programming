using System.Collections.Generic;
using System.Drawing;

namespace LTGD_BaiThucHanh8.model
{
    public static class ShapeFactory
    {
        private static Dictionary<ShapeType, IDrawBehavior> drawBehaviors;

        static ShapeFactory()
        {
            drawBehaviors = new Dictionary<ShapeType, IDrawBehavior>
            {
                { ShapeType.Rectangle, new RectangleDrawBehavior() },
                { ShapeType.Ellipse, new EllipseDrawBehavior() },
                { ShapeType.Triangle, new TriangleDrawBehavior() }
            };
        }

        public static Shape CreateShape(ShapeType type)
        {
            Shape shape = new Shape
            {
                Type = type,
                DrawBehavior = drawBehaviors[type]
            };
            return shape;
        }

        public static Shape CreateShape(ShapeType type, Color color)
        {
            Shape shape = new Shape
            {
                Type = type,
                Color = color,
                DrawBehavior = drawBehaviors[type]
            };
            return shape;
        }
    }
}
