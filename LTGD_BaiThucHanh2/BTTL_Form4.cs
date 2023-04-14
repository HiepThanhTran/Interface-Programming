using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh2
{
    public partial class BTTL_Form4 : Form
    {
        Regex rgxBieuThuc = new Regex(@"(?<soHang1>\d+) (?<toanTu>\+|-|\*|/) (?<soHang2>\d+) ");
        Regex rgxToanTu = new Regex(@"\+|-|\*|/");

        public BTTL_Form4()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lbBieuThuc.Text = "";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            if (lbBieuThuc.Text.Length > 0)
            {
                lbBieuThuc.Text = lbBieuThuc.Text.Remove(lbBieuThuc.Text.Length - 1);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (rgxToanTu.Match(btn.Text).Success && lbBieuThuc.Text == "") return;
            if (!rgxToanTu.Match(btn.Text).Success || !rgxToanTu.Match(lbBieuThuc.Text).Success)
            {
                lbBieuThuc.Text += btn.Text + " ";
                return;
            }
            char toanTuCu = Convert.ToChar(rgxToanTu.Match(lbBieuThuc.Text).ToString());
            char toanTuMoi = Convert.ToChar(btn.Text);
            lbBieuThuc.Text = lbBieuThuc.Text.Replace(toanTuCu, toanTuMoi);
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            Match bieuThuc = rgxBieuThuc.Match(lbBieuThuc.Text);
            if (!bieuThuc.Success)
            {
                MessageBox.Show("Biểu thức sai định dạng. Nhập lại!");
                return;
            }
            int soHang1 = Convert.ToInt16(bieuThuc.Groups["soHang1"].ToString());
            int soHang2 = Convert.ToInt16(bieuThuc.Groups["soHang2"].ToString());
            string toanTu = bieuThuc.Groups["toanTu"].ToString();
            double res = 0;
            switch (toanTu)
            {
                case "+": res = soHang1 + soHang2; break;
                case "-": res = soHang1 - soHang2; break;
                case "*": res = soHang1 * soHang2; break;
                case "/": res = (double)soHang1 / soHang2; break;
            }
            lbBieuThuc.Text = String.Format("{0} {1} {2} = {3:0.##}", soHang1, toanTu, soHang2, res);
        }
    }
}
