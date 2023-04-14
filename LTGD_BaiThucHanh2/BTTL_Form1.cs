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
    public partial class BTTL_Form1 : Form
    {
        public BTTL_Form1()
        {
            InitializeComponent();
        }

        private void btnASCII_Click(object sender, EventArgs e)
        {
            try
            {
                int ascii = int.Parse(txtASCII.Text);
                lbASCII.Text = ((char)ascii).ToString();
                label6.Text = "";
            }
            catch (FormatException)
            {
                label6.Text = "Sai định dạng mã ASCII!";
            }
        }

        private void btnKyTu_Click(object sender, EventArgs e)
        {
            try
            {
                char kyTu = char.Parse(txtKyTu.Text);
                lbKyTu.Text = ((int)kyTu).ToString();
                label7.Text = "";
            }
            catch (FormatException)
            {
                label7.Text = "Chỉ được nhập số!";
            }
        }
    }
}
