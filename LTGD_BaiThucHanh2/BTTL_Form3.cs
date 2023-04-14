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
    public partial class BTTL_Form3 : Form
    {
        private int diem = 0;

        public BTTL_Form3()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(0, 9);
            int b = random.Next(0, 9);
            int c = random.Next(0, 9);
            lbSo1.Text = a.ToString();
            lbSo2.Text = b.ToString();
            lbSo3.Text = c.ToString();
            if (a == b && b == c) diem += 100;
            else diem -= 10;
            lbDiem.Text = diem.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
