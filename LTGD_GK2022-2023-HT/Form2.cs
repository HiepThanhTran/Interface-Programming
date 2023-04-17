using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LTGD_GK2022_2023
{
    public partial class Form2 : Form
    {
        private float[] percentages;
        private Brush[] brushes;
        private float[] datas;
        private float ratio = 2.2f;
        private int padding = 10;
        private int thickness = 2;
        private int chartWidth = 70;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {
            // Khởi tạo các dữ liệu cần thiết
            //Color[] colors = new Color[] { Color.Red, Color.DarkGreen, Color.Blue, Color.Yellow, Color.Cyan };
            //datas = new float[] { 500000000, 755000000, 110000000, 630000000, 75000000 };
            //float totalDatas = datas.Sum(); brushes = new Brush[datas.Length];
            //percentages = new float[datas.Length];
            //for (int i = 0; i < percentages.Length; i++) percentages[i] = datas[i] / totalDatas;
            //for (int i = 0; i < colors.Length; i++) brushes[i] = new SolidBrush(colors[i]);
            //List<Label> labels = new List<Label>();

            // Gán màu cho từng label tương ứng với từng cột trên biểu đồ
            //for (int i = 1; i <= datas.Length; i++)
            //{
            //    string labelName = "lbMau" + i;
            //    Control[] controls = pnlChuThich.Controls.Find(labelName, true);
            //    if (controls.Length > 0 && controls[0] is Label label) labels.Add(label);
            //}
            //for (int i = 0; i < labels.Count; i++) labels[i].BackColor = colors[i];



            // Khởi tạo các dữ liệu cần thiết
            Color[] colors = new Color[] { Color.Red, Color.DarkGreen, Color.Blue, Color.Yellow, Color.Cyan };
            datas = new float[] { 500000000, 755000000, 110000000, 630000000, 75000000 };
            brushes = new Brush[colors.Length];
            float totalDatas = datas.Sum();
            percentages = datas.Select(data => data / totalDatas).ToArray();
            for (int i = 0; i < colors.Length; i++) brushes[i] = new SolidBrush(colors[i]);

            // Gán màu cho từng label tương ứng với từng cột trên biểu đồ
            List<Label> labels = Enumerable.Range(1, datas.Length)
                .Select(i => pnlChuThich.Controls.Find("lbMau" + i, true).FirstOrDefault())
                .OfType<Label>()
                .ToList();
            for (int i = 0; i < labels.Count; i++) labels[i].BackColor = colors[i];
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            float x = padding;
            for (int i = 0; i < datas.Length; i++)
            {
                float chartHeight = percentages[i] * pnlBieuDo.Height * ratio;
                float y = pnlBieuDo.Height - chartHeight - thickness;
                e.Graphics.FillRectangle(brushes[i], x, y, chartWidth, chartHeight);
                x += chartWidth + (pnlBieuDo.Width - chartWidth * datas.Length - padding * 2) / (datas.Length - 1);
            }
        }
    }
}
