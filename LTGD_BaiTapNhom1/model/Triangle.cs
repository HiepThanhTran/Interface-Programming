using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BaiTapNhomL1.model
{
    internal class Triangle
    {
        private double edgeA, edgeB, edgeC;

        public bool isTamGiac()
        {
            if ((edgeA + edgeB) <= edgeC ||
                    (edgeA + edgeC) <= edgeB ||
                    (edgeB + edgeC) <= edgeA)
            {
                return false;
            }
            return true;
        }

        public double EdgeA
        {
            get { return edgeA; }
            set
            {
                if (value > 0)
                {
                    edgeA = value;
                }
                else
                {
                    edgeA = 0;
                }
            }
        }

        public double EdgeB
        {
            get { return edgeB; }
            set
            {
                if (value > 0)
                {
                    edgeB = value;
                }
                else
                {
                    edgeB = 0;
                }
            }
        }

        public double EdgeC
        {
            get { return edgeC; }
            set
            {
                if (value > 0)
                {
                    edgeC = value;
                }
                else
                {
                    edgeC = 0;
                }
            }
        }

        public double TinhDienTich()
        {
            double t = (edgeA + edgeB + edgeC) / 2;
            return Math.Sqrt(t * (t - edgeA) * (t - edgeB) * (t - edgeC));
        }

        public double TinhChuVi()
        {
            return edgeA + edgeB + edgeC;
        }
    }
}
