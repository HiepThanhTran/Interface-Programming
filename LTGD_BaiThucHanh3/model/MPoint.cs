using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BaiThucHanh3.model
{
    internal class MPoint
    {
        private double dx;
        private double dy;

        public MPoint() { }

        public MPoint(double dx, double dy)
        {
            this.dx = dx;
            this.dy = dy;
        }

        public double Dx { get { return dx; } set { dx = value; } }
        public double Dy { get { return dy; } set { dy = value; } }
    }
}
