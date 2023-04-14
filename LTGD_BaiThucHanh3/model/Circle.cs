using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BaiThucHanh3.model
{
    internal class Circle
    {
        private MPoint center;
        private double radius;

        public Circle() { }

        public Circle(MPoint center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public Circle(double dx, double dy, double radius)
        {
            center.Dx = dx;
            center.Dy = dy;
            this.radius = radius;
        }

        public MPoint Center { get { return center; } set { center = value; } }
        public double Radius { get { return radius; } set { radius = value; } }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public bool Check(MPoint other)
        {
            double distance = Math.Sqrt(Math.Pow(other.Dx - center.Dx,2) + Math.Pow(other.Dy - center.Dy, 2));
            return distance <= radius;
        }
    }
}
