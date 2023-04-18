using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTGD_GK2022_2023_MT_2
{
    public partial class FrmQuaySo : Form
    {
        private Random rand = new Random();
        private int count = 0;

        public FrmQuaySo()
        {
            InitializeComponent();
        }

        private void Init()
        {
            count = 0;
            listBox1.Items.Clear();
            label1.Text = "   TRÒ CHƠI QUAY SỐ   ";
            pctNumber1.SizeMode = pctNumber2.SizeMode = pctNumber3.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNumber1.Image = pctNumber2.Image = pctNumber3.Image = Image.FromFile(Application.StartupPath + @"\dice\dice6.png");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(label1.Text.Length - 1) + label1.Text.Substring(0, label1.Text.Length - 1);
        }

        private void BtnQuaySo_Click(object sender, EventArgs e)
        {
            int[] counts = new int[7];
            int[] number = new int[3];
            PictureBox[] pctSo = { pctNumber1, pctNumber2, pctNumber3 };
            for (int i = 0; i < pctSo.Length; i++)
            {
                number[i] = rand.Next(1, 7);
                counts[number[i]]++;
                pctSo[i].Image = Image.FromFile(Application.StartupPath + String.Format(@"\dice\dice{0}.png", number[i]));
            }

            count++;
            string result = String.Format("Lần {0}: ", count);
            for (int i = 1; i < counts.Length; i++)
            {
                if (counts[i] != 0)
                {
                    result += String.Format("Số {0}: {1} lần ", i, counts[i]);
                }
            }
            listBox1.Items.Add(result.Trim());
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
