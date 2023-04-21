using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LTGD
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> years;
        private float[][] percentages;
        private float[][] datas;

        private int graphWidth = 70;

        public Form1()
        {
            InitializeComponent();
        }

        #region

        private void Init(string path)
        {
            if (File.Exists(path))
            {
                string allText = File.ReadAllText(path);
                string[] strings = allText.Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries);
                datas = new float[strings.Length][];
                for (int i = 0; i < strings.Length; i++)
                {
                    string[] partsText = strings[i].Split(new string[] { ":", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                    years.Add(partsText[0], i);
                    datas[i] = new float[partsText.Length - 1];
                    for (int j = 1; j < partsText.Length; j++) datas[i][j - 1] = float.Parse(partsText[j]);
                }
                percentages = new float[datas.Length][];
                for (int i = 0; i < datas.Length; i++)
                {
                    float totalData = datas[i].Sum();
                    percentages[i] = datas[i].Select(data => data / totalData).ToArray();
                }
                foreach (KeyValuePair<string, int> item in years) cbYear.Items.Add(item.Key);
            }
        }

        private void DrawGraph(Graphics g, Control c, string key)
        {
            Pen pen = new Pen(Color.Red, 3);
            Brush br = new SolidBrush(Color.Blue);
            Font font = new Font("Arial", 12, FontStyle.Bold);
            g.DrawLine(pen, 15, 0, 15, c.Height - 15); // Vẽ trục Oy
            g.DrawString("Tỷ đồng", font, br, 15, 0); // Vẽ tên trục y
            g.DrawLine(pen, 0, c.Height - 30, c.Width, c.Height - 30); // Vẽ trục Ox
            g.DrawString("Tháng", font, br, c.Width - 60, c.Height - 50); // Vẽ tên trục x
            // Vẽ đồ thị
            float dxColumn = 70;
            Brush brData = new SolidBrush(Color.Blue);
            Font fontData = new Font("Arial", 10, FontStyle.Bold);
            float gap = (c.Width - graphWidth * datas[years[key]].Length - 70) / (datas[years[key]].Length - 1) - 30;
            for (int i = 0; i < datas[years[key]].Length; i++)
            {
                float graphHeight = percentages[years[key]][i] * c.Height * 3;
                float dyColumn = c.Height - graphHeight - 30;
                float dxText = dxColumn + graphWidth / 2 - 10;
                g.FillRectangle(Brushes.Blue, dxColumn, dyColumn, graphWidth, graphHeight);
                g.DrawString(datas[years[key]][i].ToString(), fontData, brData, dxText, dyColumn - 20);
                g.DrawString((i + 1).ToString(), fontData, brData, dxText, c.Height - 15);
                dxColumn += graphWidth + gap;
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            years = new Dictionary<string, int>();
            Init(Application.StartupPath + @"\dulieu.txt");
            cbYear.SelectedIndex = 0;
            lbTitle.Text = "Đồ thị doanh thu năm 2022 - Họ tên SV";
        }

        private void PnlGraph_Resize(object sender, EventArgs e)
        {
            pnlGraph.CreateGraphics().Clear(pnlGraph.BackColor);
            DrawGraph(pnlGraph.CreateGraphics(), pnlGraph, cbYear.SelectedItem.ToString());
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            pnlGraph.CreateGraphics().Clear(pnlGraph.BackColor);
            DrawGraph(pnlGraph.CreateGraphics(), pnlGraph, cbYear.SelectedItem.ToString());
        }
    }
}
