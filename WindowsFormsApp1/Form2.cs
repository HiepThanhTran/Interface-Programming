using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnTinh_Click(object sender, System.EventArgs e)
        {
            try
            {
                int soLuongBongDen = int.Parse(txtSoDen.Text);
                int soLuongMayLanh = int.Parse(txtSoDen.Text);
                int soLuongMayTinh = int.Parse(txtSoDen.Text);
                ThietBi bongDen = new ThietBi(soLuongBongDen);
                ThietBi mayLanh = new ThietBi(soLuongMayLanh);
                ThietBi mayTinh = new ThietBi(soLuongMayTinh);
                txtDien.Text = (bongDen.DienNangTieuThu(5) + mayLanh.DienNangTieuThu(15) + mayTinh.DienNangTieuThu(8)).ToString();
                txtTien.Text = (bongDen.TinhTien(5) + mayLanh.TinhTien(15) + mayTinh.TinhTien(8)).ToString();
            }
            catch
            {

            }
        }

        private void BtnThoat_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
