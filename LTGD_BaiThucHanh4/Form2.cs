using LTGD_BaiThucHanh4.model;
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
    public partial class Form2 : Form
    {
        private Dice dice1 = new Dice(Application.StartupPath + @"\Dice\dice6.png");
        private Dice dice2 = new Dice(Application.StartupPath + @"\Dice\dice6.png");
        private Dice dice3 = new Dice(Application.StartupPath + @"\Dice\dice6.png");
        private Random random = new Random();
        private int count = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pctDice1.Image = dice1.Image;
            pctDice2.Image = dice2.Image;
            pctDice3.Image = dice3.Image;
        }

        private void ScrollTimer_Tick(object sender, EventArgs e)
        {
            //if (lbTitle.Left > ClientRectangle.Width) lbTitle.Left = -lbTitle.Width;
            //lbTitle.Left += 1;
            lbTitle.Text = lbTitle.Text.Substring(1) + lbTitle.Text.Substring(0, 1);
        }

        private void DiceTimer_Tick(object sender, EventArgs e)
        {
            dice1.Number = random.Next(1, 7);
            dice2.Number = random.Next(1, 7);
            dice3.Number = random.Next(1, 7);
            pctDice1.Image = dice1.Image;
            pctDice2.Image = dice2.Image;
            pctDice3.Image = dice3.Image;
            count++;
            if (count == 10)
            {
                count = 0;
                diceTimer.Stop();
                lbPoint.Text = (dice1.Number + dice2.Number + dice3.Number).ToString();
            }
        }

        private void BtnSpin_Click(object sender, EventArgs e)
        {
            diceTimer.Start();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc đóng chứ?", "Xác nhận", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
