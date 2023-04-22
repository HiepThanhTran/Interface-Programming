using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1_Option : Form
    {
        private Form1 f;

        public Form1_Option()
        {
            InitializeComponent();
        }

        public Form1_Option(Form1 f) : this()
        {
            this.f = f;
        }

        private void LbColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog
            {
                AllowFullOpen = true,
                FullOpen = true
            };
            if (dlg.ShowDialog() == DialogResult.OK) lbColor.BackColor = dlg.Color;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Form1.Brush = new SolidBrush(lbColor.BackColor);
            if (rbRectangle.Checked) Form1.Shape = rbRectangle.Text;
            if (rbEllipse.Checked) Form1.Shape = rbEllipse.Text;
            if (rbTriangle.Checked) Form1.Shape = rbTriangle.Text;
            Form1.IsDraw = true;
            f.Invalidate();
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
