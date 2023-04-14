using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh2
{
    public partial class BTTL_Form2 : Form
    {
        public BTTL_Form2()
        {
            InitializeComponent();
        }

        private void giaiPT(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        lbKetQua.Text = "Phương trình vô số nghiệm";
                    }
                    else
                    {
                        lbKetQua.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    lbKetQua.Text = "Phương trình có 1 nghiệm x = " + ((double)c / b);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    lbKetQua.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    lbKetQua.Text = "Phương trình có nghiệm kép x1 = x2 = " + ((double)(-b / (2 * a)));
                }
                else
                {
                    double x1 = (-b + (Math.Sqrt(delta))) / (2 * a);
                    double x2 = (-b - (Math.Sqrt(delta))) / (2 * a);
                    lbKetQua.Text = String.Format("Phương trình có 2 nghiệm:\nx1 = {0:0.##}\nx2 = {1:0.##}", x1, x2);
                }
            }
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                giaiPT(a, b, c);
            }
            catch (FormatException)
            {
                lbKetQua.Text = "Chỉ được nhập số!";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
