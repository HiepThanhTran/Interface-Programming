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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = checked(int.Parse(txtSo1.Text));
                int b = checked(int.Parse(txtSo2.Text));
                if (b == 0) throw new DivideByZeroException();
                if (rdCong.Checked) txtKq.Text = String.Format("{0}", checked(a + b));
                else if (rdTru.Checked) txtKq.Text = String.Format("{0}", checked(a - b));
                else if (rdNhan.Checked) txtKq.Text = String.Format("{0}", checked(a * b));
                else if (rdMod.Checked) txtKq.Text = String.Format("{0}", checked(a % b));
                else txtKq.Text = String.Format("{0:0.##}", checked((double)a / b));
            }
            catch (FormatException)
            {
                txtKq.Text = "Bạn phải nhập 2 số";
            }
            catch (DivideByZeroException)
            {
                txtKq.Text = "Không thể chia cho 0";
            }
            catch (OverflowException)
            {
                txtKq.Text = "Không thể tính toán số quá lớn";
            }
        }
    }
}
