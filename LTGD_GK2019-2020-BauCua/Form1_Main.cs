using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LTGD_GK2019_2020_Crown_Anchor
{
    public partial class Form1_Main : Form
    {
        private Random rand = new Random();
        private string[] danhSachBauCua;
        private int tienConLai = 1000;

        public Form1_Main()
        {
            Form f = new Form1_Intro();
            f.ShowDialog();
            InitializeComponent();
        }

        private void Form1_Main_Load(object sender, EventArgs e)
        {
            danhSachBauCua = Directory.GetFiles(Application.StartupPath + @"\Hinh");
            lbTienConLai.Text = tienConLai.ToString();
        }

        private void Form1_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnQuay_Click(object sender, System.EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) return;
            try
            {
                int tienCuoc = int.Parse(txtTienCuoc.Text);
                if (tienCuoc % 100 != 0 || tienCuoc > tienConLai) throw new FormatException();
                int indexImg1 = rand.Next(0, danhSachBauCua.Length);
                int indexImg2 = rand.Next(0, danhSachBauCua.Length);
                int indexImg3 = rand.Next(0, danhSachBauCua.Length);
                pct1.Image = Image.FromFile(danhSachBauCua[indexImg1]);
                pct2.Image = Image.FromFile(danhSachBauCua[indexImg2]);
                pct3.Image = Image.FromFile(danhSachBauCua[indexImg3]);

                int chon = comboBox1.SelectedIndex, count = 0;
                if (chon == indexImg1) count++;
                if (chon == indexImg2) count++;
                if (chon == indexImg3) count++;
                tienConLai = (count == 0) ? tienConLai - tienCuoc : tienConLai + tienCuoc * count;

                lbTienConLai.Text = tienConLai.ToString();
                if (tienConLai <= 0) btnQuay.Enabled = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Tiền cược phải là bội của 100 và không được lớn hơn tiền còn lại", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
