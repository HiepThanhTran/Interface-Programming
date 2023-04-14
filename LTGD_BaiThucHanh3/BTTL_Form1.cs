using LTGD_BaiThucHanh3.exception;
using LTGD_BaiThucHanh3.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh3
{
    public partial class BTTL_Form1 : Form
    {
        string[] operators = { "+", "-", "*", "/" };
        Fraction fPhanSo1 = new Fraction();
        Fraction fPhanSo2 = new Fraction();
        Fraction fKetQua = new Fraction();
        Fraction fTraLoi = new Fraction();
        Random random = new Random();

        public BTTL_Form1()
        {
            InitializeComponent();
        }

        private void TinhToan(string toanTu)
        {
            try
            {
                if (txtTu2.Text == "0" && toanTu == "/")
                {
                    throw new FractionException("Mẫu không thể bằng 0. Nhập lại!");
                }
                fPhanSo1.Numerator = Convert.ToInt16(txtTu1.Text);
                fPhanSo1.Denominator = Convert.ToInt16(txtMau1.Text);
                fPhanSo2.Numerator = Convert.ToInt16(txtTu2.Text);
                fPhanSo2.Denominator = Convert.ToInt16(txtMau2.Text);
                switch (toanTu)
                {
                    case "+": fKetQua = fPhanSo1 + fPhanSo2; break;
                    case "-": fKetQua = fPhanSo1 - fPhanSo2; break;
                    case "*": fKetQua = fPhanSo1 * fPhanSo2; break;
                    case "/": fKetQua = fPhanSo1 / fPhanSo2; break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng không hợp lệ. Nhập lại!");
            }
            catch (FractionException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            TinhToan(((Button)sender).Text);
            lbToanTu.Text = ((Button)sender).Text;
            lbBang.Text = "=";
            txtTu3.Text = fKetQua.Numerator.ToString();
            txtMau3.Text = fKetQua.Denominator.ToString();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            btnCong.Enabled = true;
            btnTru.Enabled = true;
            btnNhan.Enabled = true;
            btnChia.Enabled = true;
            btnXemDA.Enabled = false;
            pnlKetQua.Enabled = false;
            txtTu1.Text = "";
            txtMau1.Text = "";
            txtTu2.Text = "";
            txtMau2.Text = "";
            txtTu3.Text = "";
            txtMau3.Text = "";
            lbBang.Text = "...";
            lbToanTu.Text = "...";
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            btnCong.Enabled = false;
            btnTru.Enabled = false;
            btnNhan.Enabled = false;
            btnChia.Enabled = false;
            btnXemDA.Enabled = true;
            pnlKetQua.Enabled = true;
            txtTu3.Text = "";
            txtMau3.Text = "";
            int tu1 = random.Next(0, 11), tu2 = random.Next(0, 11);
            int mau1 = random.Next(1, 11), mau2 = random.Next(1, 11);
            int index = random.Next(0, operators.Length);
            while (tu2 == 0 && operators[index] == "/")
            {
                tu1 = random.Next(0, 11); tu2 = random.Next(0, 11);
                mau1 = random.Next(1, 11); mau2 = random.Next(1, 11);
                index = random.Next(0, operators.Length);
            }
            txtTu1.Text = tu1.ToString();
            txtMau1.Text = mau1.ToString();
            txtTu2.Text = tu2.ToString();
            txtMau2.Text = mau2.ToString();
            lbToanTu.Text = operators[index];
            lbBang.Text = "=";
        }

        private void btnXemDA_Click(object sender, EventArgs e)
        {
            TinhToan(lbToanTu.Text);
            string notification;
            try
            {
                fTraLoi.Numerator = Convert.ToInt16(txtTu3.Text);
                fTraLoi.Denominator = Convert.ToInt16(txtMau3.Text);
                if (fKetQua == fTraLoi)
                {
                    notification = "Bạn đã làm đúng. Ấn Random để tiếp tục!";
                }
                else
                {
                    notification = string.Format("Sai rồi. Đáp án đúng là {0} / {1}", fKetQua.Numerator, fKetQua.Denominator);
                }

                MessageBox.Show(notification);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng điền đáp án trước khi xem!");
            }
        }
    }
}
