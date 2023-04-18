using LTGD_GK2022_2023_MT.model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTGD_GK2022_2023_MT
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
        }

        #region CustomFunction

        private void Reset()
        {
            txtX.Text = txtY.Text = txtWidth.Text = txtHeight.Text = "";
            txtX.Focus();
        }

        private void AddItemToListView(MyShape shape)
        {
            ListViewItem listViewItem = new ListViewItem(shape.X.ToString());
            listViewItem.Tag = shape;
            listViewItem.SubItems.Add(shape.Y.ToString());
            listViewItem.SubItems.Add(shape.Width.ToString());
            listViewItem.SubItems.Add(shape.Height.ToString());
            lsvTTHinh.Items.Add(listViewItem);
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pnlVe.Width, pnlVe.Height);
            cbDoDay.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Close application?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void PnlVe_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void LsvTTHinh_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lsvTTHinh.Columns[e.ColumnIndex].Width;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Rectangle file (*.rect)|*.rect";
            od.Title = "Select Rectangle File";
            if (od.ShowDialog() == DialogResult.OK)
            {
                bmp = new Bitmap(od.FileName);
                pnlVe.Invalidate();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Rectangle file (*.rect)|*.rect";
            sd.Title = "Save Rectangle File";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sd.FileName);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtX.Text, out int x) && int.TryParse(txtY.Text, out int y) && int.TryParse(txtWidth.Text, out int width) && int.TryParse(txtHeight.Text, out int height))
            {
                int thickness = int.Parse(cbDoDay.SelectedItem.ToString());
                Color backcolor = lbMauNen.BackColor;
                Color bordercolor = lbMauDuongVien.BackColor;
                Rectangle rect = new Rectangle(x, y, width, height);
                MyShape shape = new MyShape(rect, thickness, backcolor, bordercolor);
                AddItemToListView(shape);
                Reset();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lsvTTHinh.SelectedItems.Count > 0)
            {
                lsvTTHinh.Items.Remove(lsvTTHinh.SelectedItems[0]);
            }
        }

        private void LabelColor_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                lb.BackColor = cd.Color;
            }
        }

        private void LsvTTHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvTTHinh.SelectedItems.Count > 0 && lsvTTHinh.SelectedItems[0].Tag is MyShape shape)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(pnlVe.BackColor);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawRectangle(new Pen(shape.BorderColor, shape.Thickness), new Rectangle(shape.X, shape.Y, shape.Width, shape.Height));
                g.FillEllipse(new SolidBrush(shape.BackColor), new Rectangle(shape.X, shape.Y, shape.Width, shape.Height));
                pnlVe.Invalidate();
                g.Dispose();
            }
        }
    }
}
