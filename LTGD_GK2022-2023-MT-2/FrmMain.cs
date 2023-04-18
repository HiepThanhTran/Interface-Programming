using System;
using System.Windows.Forms;

namespace LTGD_GK2022_2023_MT_2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Đóng chương trình?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dlg == DialogResult.No) e.Cancel = true;
        }

        private void BtnGame_Click(object sender, EventArgs e)
        {
            FrmQuaySo f = new FrmQuaySo { MdiParent = this };
            f.Show();
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            FrmVe f = new FrmVe { MdiParent = this };
            f.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
