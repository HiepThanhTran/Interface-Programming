using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh8
{
    public partial class BTTL_Form1 : Form
    {
        Pen pen = new Pen(Color.Black, 4);
        int chartPadding = 10; // Khoảng trắng thụt vào ở 2 bên
        int columnWidth = 70; // Chiều dài từng cột của biểu đồ
        float ratio = 3.2f; // Tỉ lệ

        public BTTL_Form1()
        {
            InitializeComponent();
        }

        private void DrawChart(Control c)
        {
            Brush[] brushes = new Brush[]
            {
                Brushes.Red,
                Brushes.DarkGreen,
                Brushes.Blue,
                Brushes.Yellow,
                Brushes.Cyan
            };
            try
            {
                // Tạo bitmap để vẽ biểu đồ
                Bitmap bmp = new Bitmap(c.Width, c.Height);
                Graphics gbmp = Graphics.FromImage(bmp);
                gbmp.DrawLine(pen, 0, c.Height, c.Width, c.Height);

                // Lấy dữ liệu từ các textbox và tính toán phần trăm
                float[] datas = new float[5];
                datas[0] = float.Parse(txtMonday.Text);
                datas[1] = float.Parse(txtTuesday.Text);
                datas[2] = float.Parse(txtWednesday.Text);
                datas[3] = float.Parse(txtThursday.Text);
                datas[4] = float.Parse(txtFriday.Text);
                float totalData = datas.Sum();
                float[] percentages = new float[datas.Length];
                for (int i = 0; i < percentages.Length; i++)
                {
                    percentages[i] = datas[i] / totalData * 100;
                }

                // Vẽ biểu đồ lên bitmap
                float dx = chartPadding;
                for (int i = 0; i < percentages.Length; i++)
                {
                    float chartHeight = percentages[i] / 100 * c.Height * ratio;
                    float dy = c.Height - chartHeight - (pen.Width - 2);
                    gbmp.FillRectangle(brushes[i], dx, dy, columnWidth, chartHeight);
                    dx += (c.Width - chartPadding * 2 - columnWidth * 5) / 4 + columnWidth;
                }

                // Gắn bitmap vào pictureBox
                c.BackgroundImage = bmp;
                gbmp.Dispose();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            DrawChart(pctChart);
        }
    }
}
