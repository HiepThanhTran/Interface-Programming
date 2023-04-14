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
    public partial class Form4 : Form
    {
        private string[] phepTinh = { "+", "-", "*", "/" };
        Random random = new Random();

        public Form4()
        {
            InitializeComponent();
        }

        private void solve()
        {
            try
            {
                int t = int.Parse(txtTraLoi.Text);
                int a = int.Parse(lbSo1.Text);
                int b = int.Parse(lbSo2.Text);
                string c = lbPhepTinh.Text;
                double d = 0;
                switch (c)
                {
                    case "+":
                        d = a + b;
                        break;
                    case "-":
                        d = a - b;
                        break;
                    case "*":
                        d = a * b;
                        break;
                    case "/":
                        d = (double)a / b;
                        break;
                }
                if (t == d) lbKetQua.Text = "Đúng rồi!";
                else lbKetQua.Text = "Sai rồi! Kết quả là " + d;
            }
            catch (FormatException)
            {
                lbKetQua.Text = "Sai định dạng. Nhập lại!";
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            string toanTu = phepTinh[random.Next(0, phepTinh.Length)];
            int soThu1 = random.Next(0, 10);
            int soThu2 = random.Next(0, 10);
            while (soThu2 == 0 && toanTu == "/")
            {
                soThu1 = random.Next(0, 10);
                soThu2 = random.Next(0, 10);
            }
            lbSo1.Text = soThu1.ToString();
            lbPhepTinh.Text = toanTu;
            lbSo2.Text = soThu2.ToString();
            lbKetQua.Text = "";
            txtTraLoi.Text = "";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            solve();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtTraLoi.Text += btn.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTraLoi.Text.Length > 0)
            {
                txtTraLoi.Text = txtTraLoi.Text.Remove(txtTraLoi.Text.Length - 1);
            }
        }
    }
}
