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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);
                txtKq.Text = String.Format("{0:0.##}", a + b);
            }
            catch (FormatException)
            {
                txtKq.Text = "Bạn phải nhập 2 số";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);
                txtKq.Text = String.Format("{0:0.##}", a - b);
            }
            catch (FormatException)
            {
                txtKq.Text = "Bạn phải nhập 2 số";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);
                txtKq.Text = String.Format("{0:0.##}", a * b);
            }
            catch (FormatException)
            {
                txtKq.Text = "Bạn phải nhập 2 số";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtSo1.Text);
                int b = int.Parse(txtSo2.Text);
                if (b == 0) throw new DivideByZeroException();
                txtKq.Text = String.Format("{0:0.##}", (double)a / b);
            }
            catch (FormatException)
            {
                txtKq.Text = "Bạn phải nhập 2 số";
            }
            catch (DivideByZeroException)
            {
                txtKq.Text = "Không thể chia cho 0";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
