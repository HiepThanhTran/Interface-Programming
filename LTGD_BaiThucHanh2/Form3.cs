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
    public partial class Form3 : Form
    {
        private int diem = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void bttnQuaySo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int a = random.Next(0, 10);
            int b = random.Next(0, 10);
            int c = random.Next(0, 10);
            lbSo1.Text = a.ToString();
            lbSo2.Text = b.ToString();
            lbSo3.Text = c.ToString();
            if (rd3_10.Checked)
            {
                if (a + b + c >= 3 && a + b + c <= 10) diem += 10;
                else diem -= 10;
            }
            else if (rd11_18.Checked)
            {
                if (a + b + c >= 11 && a + b + c <= 18) diem += 10;
                else diem -= 10;
            }
            lbDiem.Text = diem.ToString();
        }
    }
}
