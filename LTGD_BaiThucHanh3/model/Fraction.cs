using LTGD_BaiThucHanh3.exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTGD_BaiThucHanh3.model
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;

        // Constructor 0 tham số
        public Fraction() { }

        // Constructor 2 tham số
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) throw new FractionException("Mẫu không thể bằng 0. Nhập lại!");
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // Property
        public int Numerator { get { return numerator; } set { numerator = value; } }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0) throw new FractionException("Mẫu không thể bằng 0. Nhập lại!");
                if (value < 0)
                {
                    numerator *= -1;
                    value *= -1;
                }
                denominator = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Fraction)) return false;
            Fraction fraction = obj as Fraction;
            int _numerator = numerator / GCF(numerator, denominator);
            int _denominator = denominator / GCF(numerator, denominator);
            int numerator_ = fraction.numerator / GCF(fraction.numerator, fraction.denominator);
            int denominator_ = fraction.denominator / GCF(fraction.numerator, fraction.denominator);
            return _numerator == numerator_ && _denominator == denominator_;
        }

        public override int GetHashCode()
        {
            int _numerator = numerator / GCF(numerator, denominator);
            int _denominator = denominator / GCF(numerator, denominator);
            int hashCode = -671859081;
            hashCode = hashCode * -1521134295 + _numerator.GetHashCode();
            hashCode = hashCode * -1521134295 + _denominator.GetHashCode();
            return hashCode;
        }

        // Greatest Common Factor
        // Tìm ước chung lớn nhất của 2 số nguyên
        public static int GCF(int a, int b)
        {
            if (b == 0) return a;
            if (a % b == 0) return b;
            return GCF(b, a % b);
        }

        // Rút gọn phân số
        public static Fraction Reduce(Fraction f)
        {
            int gcf = GCF(f.Numerator, f.Denominator);
            return new Fraction(f.Numerator / gcf, f.Denominator / gcf);
        }

        // Cộng 2 phân số
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            res.Denominator = f1.Denominator * f2.Denominator;
            return Reduce(res);
        }

        // Trừ 2 phân số
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            res.Denominator = f1.Denominator * f2.Denominator;
            return Reduce(res);
        }

        // Nhân 2 phân số
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Numerator = f1.Numerator * f2.Numerator;
            res.Denominator = f1.Denominator * f2.Denominator;
            return Reduce(res);
        }

        // Chia 2 phân số
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction();
            res.Numerator = f1.Numerator * f2.Denominator;
            res.Denominator = f1.Denominator * f2.Numerator;
            return Reduce(res);
        }

        // So sánh 2 phân số có bằng nhau hay không
        // True nếu bằng
        // False nếu khôngg bằng
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            if ((f1 - f2).Numerator == 0) return true;
            return false;
        }

        // So sánh 2 phân số có khác nhau hay không
        // True nếu khác nhau
        // False nếu không khác nhau
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            if ((f1 - f2).Numerator != 0) return true;
            return false;
        }

        // So sánh phân số f1 có lớn hơn phân số f2 không
        // True nếu lớn hơn
        // False nếu không lớn hơn
        public static bool operator >(Fraction f1, Fraction f2)
        {
            if ((f1 - f2).Numerator > 0) return true;
            return false;
        }

        // So sánh phân số f1 có nhỏ hơn phân số f2 không
        // True nếu nhỏ hơn
        // False nếu không nhỏ hơn
        public static bool operator <(Fraction f1, Fraction f2)
        {
            if ((f1 - f2).Numerator < 0) return true;
            return false;
        }

        // So sánh phân số f1 có lớn hơn hoặc bằng phân số f2 không
        // True nếu lớn hơn hoặc bằng
        // False nếu không lớn hơn hoặc bằng
        public static bool operator >=(Fraction f1, Fraction f2)
        {
            if ((f1 - f2).Numerator >= 0) return true;
            return false;
        }

        // So sánh phân số f1 có nhỏ hơn hoặc bằng phân số f2 không
        // True nếu nhỏ hơn hoặc bằng
        // False nếu không nhỏ hơn hoặc bằng
        public static bool operator <=(Fraction f1, Fraction f2)
        {
            if ((f1 - f2).Numerator <= 0) return true;
            return false;
        }
    }
}
