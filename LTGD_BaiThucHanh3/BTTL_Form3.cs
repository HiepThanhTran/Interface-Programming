using LTGD_BaiThucHanh3.model;
using System;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh3
{
    public partial class BTTL_Form3 : Form
    {
        Circle circle = new Circle();
        MPoint point = new MPoint();
        public BTTL_Form3()
        {
            InitializeComponent();
        }

        private void BtnXemKQ_Click(object sender, EventArgs e)
        {
            try
            {
                double cDx = Convert.ToDouble(txtCenterX.Text);
                double cDy = Convert.ToDouble(txtCenterY.Text);
                double cRadius = Convert.ToDouble(txtRadius.Text);
                double oDx = Convert.ToDouble(txtOtherX.Text);
                double oDy = Convert.ToDouble(txtOtherY.Text);
                circle.Center = new MPoint(cDx, cDy);
                circle.Radius = cRadius;
                point.Dx = oDx;
                point.Dy = oDy;
                lbArea.Text = string.Format("Diện tích: {0:0.##}", circle.GetArea());
                lbPerimeter.Text = string.Format("Chu vi: {0:0.##}", circle.GetPerimeter());
                lbResult.Text = circle.Check(point) ? "Nằm trên hình tròn" : "Không nằm trên hình tròn";
            }
            catch(FormatException)
            {
                MessageBox.Show("Vui lòng nhập các thông tin trước khi xem!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
