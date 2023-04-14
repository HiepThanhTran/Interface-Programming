using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_GK2019_2020
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        private int soTienConLai;
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soTienConLai = Convert.ToInt32(lbTienConLai.Text);
            lbSo1.Text = lbSo2.Text = lbSo3.Text = "6";
            cbTienCuoc1.SelectedIndex = 0;
            cbTienCuoc2.SelectedIndex = 0;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            pctSo1.Image = pctSo2.Image = pctSo3.Image = Image.FromFile(Application.StartupPath + @"\Dice\dice6.png");
            pctSo1.SizeMode = pctSo2.SizeMode = pctSo3.SizeMode = PictureBoxSizeMode.Zoom;
            pctSo1.Visible = pctSo2.Visible = pctSo3.Visible = chkGiaoDienHinh.Checked;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Đóng ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnQuaySo_Click(object sender, EventArgs e)
        {
            int soTienCuoc1 = Convert.ToInt32(cbTienCuoc1.SelectedItem.ToString());
            int soTienCuoc2 = Convert.ToInt32(cbTienCuoc2.SelectedItem.ToString());
            if (soTienCuoc1 + soTienCuoc2 > soTienConLai)
            {
                MessageBox.Show("Tổng tiền cược không được lớn hơn tổng tiền còn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int so1 = rand.Next(1, 7);
            int so2 = rand.Next(1, 7);
            int so3 = rand.Next(1, 7);
            lbSo1.Text = so1.ToString();
            lbSo2.Text = so2.ToString();
            lbSo3.Text = so3.ToString();
            pctSo1.Image = Image.FromFile(Application.StartupPath + @"\Dice\dice" + so1 + ".png");
            pctSo2.Image = Image.FromFile(Application.StartupPath + @"\Dice\dice" + so2 + ".png");
            pctSo3.Image = Image.FromFile(Application.StartupPath + @"\Dice\dice" + so3 + ".png");

            int tong = so1 + so2 + so3;
            if ((rdChan.Checked && tong % 2 == 0) || (rdLe.Checked && tong % 2 == 1)) soTienConLai += soTienCuoc1;
            else soTienConLai -= soTienCuoc1;

            if ((rd310.Checked && tong >= 3 && tong <= 10) || (rd1118.Checked && tong >= 11 && tong <= 18)) soTienConLai += soTienCuoc2;
            else soTienConLai -= soTienCuoc2;

            lbTienConLai.Text = soTienConLai.ToString();
        }
    }
}
