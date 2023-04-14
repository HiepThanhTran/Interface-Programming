using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh4
{
    public partial class Form4_Login : Form
    {
        private readonly string correctPassword = "admin";

        public Form4_Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!txtPassword.Text.Equals(correctPassword))
            {
                MessageBox.Show("Sai mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            Form4_Main.userName = txtUserName.Text;
            Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
