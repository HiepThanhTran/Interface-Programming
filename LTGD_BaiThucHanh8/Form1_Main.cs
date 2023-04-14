using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh8
{
    public partial class Form1_Main : Form
    {
        public Form1_Main()
        {
            InitializeComponent();
        }

        private void BtnDrawByMouse_Click(object sender, EventArgs e)
        {
            Form1_DrawByMouse fSub = new Form1_DrawByMouse();
            fSub.MdiParent = this;
            fSub.Show();
        }

        private void BtnDrawText_Click(object sender, EventArgs e)
        {
            Form1_DrawText fSub = new Form1_DrawText();
            fSub.MdiParent = this;
            fSub.Show();
        }

        private void BtnDrawImage_Click(object sender, EventArgs e)
        {
            Form1_DrawImage fSub = new Form1_DrawImage();
            fSub.MdiParent = this;
            fSub.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
