using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LTGD_GK2022_2023
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> danhSachKhoa;
        private float[] heSoGK;
        private int[] mucDiemDat;
        private bool flagExit;

        public Form1()
        {
            InitializeComponent();
        }

        #region CustomFuntion

        private string CheckKetQua(float diemTongQuat, float diemQuaMon)
        {
            if (diemTongQuat >= diemQuaMon) return "Đạt";
            return "Không đạt";
        }

        private string QuyDoiDiemChu(float diemSo)
        {
            if (diemSo >= 8 && diemSo <= 10) return "A";
            if (diemSo >= 6.5f && diemSo <= 7.9f) return "B";
            if (diemSo >= 5 && diemSo <= 6.4f) return "C";
            return "D";
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            danhSachKhoa = new Dictionary<string, int>
            {
                { "2020", 0 },
                { "2021", 1 },
                { "2022", 2 }
            };
            lbHoTen.Text = lbDiemTongQuat.Text = lbKetQua.Text = lbDiemChu.Text = "";
            heSoGK = new float[] { 0.2f, 0.4f, 0.3f };
            mucDiemDat = new int[] { 4, 4, 5 };
            flagExit = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flagExit && MessageBox.Show("Đóng chương trình?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                flagExit = true;
                Application.Exit();
            }
        }

        private void BtnTinhDiem_Click(object sender, EventArgs e)
        {
            float heSoGK = float.Parse(txtHeSoGK.Text) / 100; // Hệ số giữa kỳ
            float heSoCK = float.Parse(txtHeSoCK.Text) / 100; // Hệ số cuối kỳ
            float diemGK = float.Parse(txtDiemGK.Text); // Điểm giữa kỳ
            float diemCK = float.Parse(txtDiemCK.Text); // Điểm cuối kỳ
            float diemTongQuat = heSoGK * diemGK + heSoCK * diemCK;
            lbHoTen.Text = txtHoTen.Text;
            lbDiemTongQuat.Text = diemTongQuat.ToString();
            lbKetQua.Text = CheckKetQua(diemTongQuat, int.Parse(lbDiemQuaMon.Text));
            lbDiemChu.Text = QuyDoiDiemChu(diemTongQuat);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                btnTinhDiem.Enabled = true;
                txtHeSoGK.Text = (heSoGK[danhSachKhoa[txtKhoa.Text]] * 100).ToString();
                txtHeSoCK.Text = (100 - heSoGK[danhSachKhoa[txtKhoa.Text]] * 100).ToString();
                lbDiemQuaMon.Text = mucDiemDat[danhSachKhoa[txtKhoa.Text]].ToString();
            }
            else
            {
                btnTinhDiem.Enabled = false;
                txtHeSoGK.Text = txtHeSoCK.Text = lbDiemQuaMon.Text = "";
            }
        }

        private void TxtHoTen_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtHoTen.Text))
            {
                e.Cancel = true;
                errorHoTen.SetError(txtHoTen, "Vui lòng nhập họ tên!");
            }
            else
            {
                e.Cancel = false;
                errorHoTen.SetError(txtHoTen, null);
            }
        }

        private void TxtKhoa_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtKhoa.Text) || !int.TryParse(txtKhoa.Text, out int khoa) || !danhSachKhoa.ContainsKey(khoa.ToString()))
            {
                e.Cancel = true;
                errorHoTen.SetError(txtKhoa, "Chỉ nhập các giá trị " + String.Join(", ", danhSachKhoa.Keys.ToArray()));
            }
            else
            {
                e.Cancel = false;
                errorHoTen.SetError(txtKhoa, null);
            }
        }

        private void TxtDiem_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (String.IsNullOrEmpty(txt.Text) || !int.TryParse(txt.Text, out int diem) || !(diem >= 0 && diem <= 10))
            {
                e.Cancel = true;
                errorHoTen.SetError(txt, "Vui lòng điểm số!");
            }
            else
            {
                e.Cancel = false;
                errorHoTen.SetError(txt, null);
            }
        }
    }
}
