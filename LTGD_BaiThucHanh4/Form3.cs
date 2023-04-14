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
    public partial class Form3 : Form
    {
        private readonly Dice diceGuess = new Dice();
        private readonly Dice diceRandom = new Dice();
        private readonly Random random = new Random();
        private string result;
        private int total = 0;
        private int lose = 0;
        private int win = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc đóng chứ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            diceGuess.Number = Convert.ToInt16(((Button)sender).Text);
            pctGuess.Image = diceGuess.Image;
        }

        private void Play()
        {
            if (pctGuess.Image == null)
            {
                MessageBox.Show("Vui lòng chọn số cần đoán trước khi quay số!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button1.Focus();
                return;
            }
            diceRandom.Number = random.Next(1, 7);
            pctRandom.Image = diceRandom.Image;
            total++;
            if (diceGuess.Number == diceRandom.Number)
            {
                result = "Thắng";
                win++;
            }
            else
            {
                result = "Thua";
                lose++;
            }
            lbTotal.Text = string.Format("Lần đoán: {0}", total);
            lbWin.Text = string.Format("Lần thắng: {0} ({1:0.##}%)", win, (double)win / total * 100);
            lbLose.Text = string.Format("Lần thua: {0} ({1:0.##}%)", lose, (double)lose / total * 100);
            listBox1.Items.Add(string.Format("{0}. {1} (Đoán {2} ra {3})", total, result, diceGuess.Number, diceRandom.Number));
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void Init()
        {
            listBox1.Items.Clear();
            total = win = lose = 0;
            pctRandom.Image = null;
            lbWin.Text = lbLose.Text = lbTotal.Text = "";
            pctGuess.Image = Image.FromFile(Application.StartupPath + @"\Dice\dice1.png");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter: Play(); break;
                case Keys.Escape: Init(); break;
            }
            return true;
        }
    }
}
