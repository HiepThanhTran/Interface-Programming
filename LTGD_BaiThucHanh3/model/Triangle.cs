using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BaiThucHanh3.model
{
    internal class Triangle
    {
        private double edgeA, edgeB, edgeC;

        public double EdgeA
        {
            get { return edgeA; }
            set { if (value > 0) edgeA = value; }
        }
        public double EdgeB
        {
            get { return edgeB; }
            set { if (value > 0) edgeB = value; }
        }
        public double EdgeC
        {
            get { return edgeC; }
            set { if (value > 0) edgeC = value; }
        }

        public bool IsTriangle()
        {
            if ((edgeA + edgeB) > edgeC && (edgeA + edgeC) > edgeB && (edgeB + edgeC) > edgeA)
            {
                return true;
            }
            return false;
        }

        public string CheckType()
        {
            if (edgeA == edgeB && edgeB == edgeC)
            {
                return "Đây là tam giác đều";
            }
            if (edgeA == edgeB || edgeA == edgeC || edgeB == edgeC)
            {
                return "Đây là tam giác cân";
            }
            if ((edgeA * edgeA) == (edgeB * edgeB + edgeC * edgeC) ||
                (edgeB * edgeB) == (edgeA * edgeA + edgeC * edgeC) ||
                (edgeC * edgeC) == (edgeB * edgeB + edgeA * edgeA))
            {
                return "Đây là tam giác vuông";
            }
            return "Đây là tam giác bình thường";
        }

        public double GetArea()
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - edgeA) * (halfPerimeter - edgeB) * (halfPerimeter - edgeC));
        }

        public double GetPerimeter()
        {
            return edgeA + edgeB + edgeC;
        }
    }
}
