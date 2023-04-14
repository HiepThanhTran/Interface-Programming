using LTGD_BaiThucHanh3.exception;
using LTGD_BaiThucHanh3.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh3
{
    public partial class BTTL_Form2 : Form
    {
        Triangle triangle = new Triangle();

        public BTTL_Form2()
        {
            InitializeComponent();
        }

        private void Validator()
        {
            triangle.EdgeA = Convert.ToDouble(txtCanhA.Text);
            triangle.EdgeB = Convert.ToDouble(txtCanhB.Text);
            triangle.EdgeC = Convert.ToDouble(txtCanhC.Text);
            if (!triangle.IsTriangle())
            {
                throw new TriangleException("Đây không phải là 1 tam giác. Nhập lại!");
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                Validator();
                lbKetQua.Text = triangle.CheckType();
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá trị không hợp lệ. Nhập lại!");
            }
            catch (TriangleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            try
            {
                Validator();
                lbKetQua.Text = string.Format("Diện tích = {0:0.##}", triangle.GetArea());
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá trị không hợp lệ. Nhập lại!");
            }
            catch (TriangleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            try
            {
                Validator();
                lbKetQua.Text = string.Format("Chu vi = {0:0.##}", triangle.GetPerimeter());
            }
            catch (FormatException)
            {
                MessageBox.Show("Giá trị không hợp lệ. Nhập lại!");
            }
            catch (TriangleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
