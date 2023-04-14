using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh4
{
    public partial class Form1 : Form
    {
        int dx = 5;
        int dy = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (pctBall.Left <= 0 || pctBall.Right >= ClientRectangle.Width) dx = -dx;
            if (pctBall.Top <= 0 || pctBall.Bottom >= ClientRectangle.Height) dy = -dy;
            pctBall.Left += dx;
            pctBall.Top += dy;
        }
    }
}
