using LTGD_BaiThucHanh8.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh8
{
    public partial class BTTL_Form2 : Form
    {
        public static Shape shape;

        private List<Shape> shapeList;
        private Bitmap originalBitmap;
        private Point oldPoint;

        public BTTL_Form2()
        {
            InitializeComponent();
        }

        private void BTTL_Form2_Load(object sender, EventArgs e)
        {
            originalBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            shape = ShapeFactory.CreateShape(ShapeType.Rectangle, Color.FromKnownColor(KnownColor.HotTrack));
            shapeList = new List<Shape>();
        }

        private void BTTL_Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(originalBitmap);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            // Vẽ lại các hình đã lưu lên bitmap (do đã bị xóa trong lúc vẽ khung)
            foreach (Shape shape in shapeList) shape.Fill(g);
            e.Graphics.DrawImage(originalBitmap, 0, 0);
            g.Dispose();
        }

        private void BTTL_Form2_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void BTTL_Form2_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint = e.Location;
        }

        private void BTTL_Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Tính toán kích thước mới đồng thời cập nhật lại vị trí top-left (nếu có) của hình chữ nhật mới
                int width = Math.Abs(e.Location.X - oldPoint.X);
                int height = Math.Abs(e.Location.Y - oldPoint.Y);
                int topLeftX = oldPoint.X;
                int topLeftY = oldPoint.Y;
                if (e.Location.X < oldPoint.X) topLeftX = e.Location.X; // Trường hợp kéo sang trái
                if (e.Location.Y < oldPoint.Y) topLeftY = e.Location.Y; // Trường hợp kéo lên trên

                // Lấy graphics của originalBitmap
                Graphics g = Graphics.FromImage(originalBitmap);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(BackColor);

                // Cập nhật khung hình chữ nhật mới cho đối tượng shape
                shape.Height = height;
                shape.Width = width;
                shape.X = topLeftX;
                shape.Y = topLeftY;
                shape.Draw(g);

                Invalidate();
                g.Dispose();
            }
        }

        private void BTTL_Form2_MouseUp(object sender, MouseEventArgs e)
        {
            shapeList.Add(shape);
            shape = ShapeFactory.CreateShape(shape.Type, shape.Color);
            Invalidate();
        }

        private void BtnOption_Click(object sender, EventArgs e)
        {
            BTTL_Form2_Option options = new BTTL_Form2_Option();
            options.ShowDialog();
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(originalBitmap);
            g.Clear(BackColor);
            shapeList.Clear();
            Invalidate();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Png File (*.png)|*.png" +
                "| Jpg File (*.jpg)|*.jpg" +
                "| Jpeg File(*.jpeg)|*.jpeg" +
                "| Bitmap File (*.bmp)|*.bmp" +
                "| Gif File (*.gif)|*.gif";
            if (sd.ShowDialog() == DialogResult.OK) originalBitmap.Save(sd.FileName);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
