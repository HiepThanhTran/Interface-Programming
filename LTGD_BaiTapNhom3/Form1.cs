using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiTapNhomL3
{
    public partial class Form1 : Form
    {
        private int rgba1 = 255, rgba2 = 255, rgba3 = 255;
        private int vh1 = -1, vh2 = -1, vh3 = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbColorChange.BackColor = Color.FromArgb(rgba1, rgba2, rgba3);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Jpeg |*.jpg|" + "Png |*.png|" + "Gif |*gif|" + "Bitmap |*bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pct.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            rgba1 = 255 - vScrollBar1.Value;
            rgba2 = 255 - vScrollBar2.Value;
            rgba3 = 255 - vScrollBar3.Value;
            lbRed.Text = rgba1.ToString();
            lbGreen.Text = rgba2.ToString();
            lbBlue.Text = rgba3.ToString();
            lbColorChange.BackColor = Color.FromArgb(rgba1, rgba2, rgba3);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (ckbRed.Checked)
            {
                if (vScrollBar1.Value <= 0 || vScrollBar1.Value >= 255)
                {
                    vh1 = -vh1;
                }
                vScrollBar1.Value += vh1;
            }
            if (ckbGreen.Checked)
            {
                if (vScrollBar2.Value <= 0 || vScrollBar2.Value >= 255)
                {
                    vh2 = -vh2;
                }
                vScrollBar2.Value += vh2;
            }
            if (ckbBlue.Checked)
            {
                if (vScrollBar3.Value <= 0 || vScrollBar3.Value >= 255)
                {
                    vh3 = -vh3;
                }
                vScrollBar3.Value += vh3;
            }
        }
    }
}
