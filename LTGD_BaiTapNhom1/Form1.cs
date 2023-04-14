using LTGD_BaiTapNhomL1.model;
using System;
using System.Windows.Forms;

namespace LTGD_BaiTapNhomL1
{
    public partial class Form1 : Form
    {
        private Triangle triangle = new Triangle();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                triangle.EdgeA = Convert.ToDouble(txtCanha.Text);
                triangle.EdgeB = Convert.ToDouble(txtCanhb.Text);
                triangle.EdgeC = Convert.ToDouble(txtCanhc.Text);
                if (!triangle.isTamGiac())
                {
                    throw new Exception("Ba cạnh không phải một tam giác");
                }
                lbKetQua.Text = String.Format("{0:0.##}", triangle.TinhDienTich());
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai định dạng. Nhập lại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                triangle.EdgeA = Convert.ToDouble(txtCanha.Text);
                triangle.EdgeB = Convert.ToDouble(txtCanhb.Text);
                triangle.EdgeC = Convert.ToDouble(txtCanhc.Text);
                if (!triangle.isTamGiac())
                {
                    throw new Exception("Ba cạnh không phải một tam giác");
                }
                lbKetQua.Text = String.Format("{0:0.##}", triangle.TinhChuVi());
            }
            catch (FormatException)
            {
                MessageBox.Show("Sai định dạng. Nhập lại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
