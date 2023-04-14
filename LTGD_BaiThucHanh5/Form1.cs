using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh5
{
    public partial class Form1 : Form
    {
        private readonly Random rand = new Random();
        private readonly int imgWidth = 90;
        private int count = 0;
        private string[] arrImgs;
        private Point oldPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelText.Text = "Dùng chuột hoặc các phím mũi tên di chuyển hình vào panel màu hồng";
            arrImgs = Directory.GetFiles(Application.StartupPath + @"\Images");
            AddNewPictureBox();
        }

        private void AddNewPictureBox()
        {
            count++;
            PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile(arrImgs[rand.Next(arrImgs.Length)]),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Name = "pictureBox" + count.ToString(),
                Location = new Point(0, 0)
            };
            pictureBox.Width = pictureBox.Height = imgWidth;
            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseUp += PictureBox_MouseUp;
            Controls.Add(pictureBox);
            Controls.SetChildIndex(flowPnlBound, Controls.Count - 1);
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint = e.Location;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.Left += (e.X - oldPoint.X);
                pictureBox.Top += (e.Y - oldPoint.Y);
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (flowPnlBound.Bounds.Contains(pictureBox.Bounds))
            {
                flowPnlBound.Controls.Add(pictureBox);
                AddNewPictureBox();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            PictureBox pictureBox = Controls.Find("pictureBox" + count.ToString(), false)[0] as PictureBox;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (pictureBox.Left > 0) pictureBox.Left -= 10;
                    break;
                case Keys.Right:
                    if (pictureBox.Right < ClientRectangle.Width) pictureBox.Left += 10;
                    break;
                case Keys.Up:
                    if (pictureBox.Top > 0) pictureBox.Top -= 10;
                    break;
                case Keys.Down:
                    if (pictureBox.Bottom < ClientRectangle.Height - labelText.Height - 15) pictureBox.Top += 10;
                    break;
            }
            if (flowPnlBound.Bounds.Contains(pictureBox.Bounds))
            {
                flowPnlBound.Controls.Add(pictureBox);
                AddNewPictureBox();
            }
        }

        private void FlowPnlBound_MouseDown(object sender, MouseEventArgs e)
        {
            oldPoint = e.Location;
        }

        private void FlowPnlBound_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FlowLayoutPanel flowLayoutPanel = sender as FlowLayoutPanel;
                flowLayoutPanel.Left += (e.X - oldPoint.X);
                flowLayoutPanel.Top += (e.Y - oldPoint.Y);
            }
        }
    }
}
