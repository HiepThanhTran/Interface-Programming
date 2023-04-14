using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            lbTitle.Text = "     CHƯƠNG TRÌNH MINH HOẠ XỬ LÝ CHUỖI     ";
            lbStr1.Text = "     Khoa khoa CNTT, trường đại     học mở    TP Hồ Chí Minh      ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void TimerTitle_Tick(object sender, EventArgs e)
        {
            lbTitle.Text = lbTitle.Text.Substring(1) + lbTitle.Text.Substring(0, 1);
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt16(txtPosition1.Text);
            if (txtStr2.Text == "" || pos < 0 || pos > lbStr1.Text.Length) return;
            lbStr1.Text = lbStr1.Text.Insert(pos, txtStr2.Text);
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            string str1 = lbStr1.Text.ToLower();
            string str2 = txtStr2.Text.ToLower();
            string str3 = txtStr3.Text.ToLower();
            if (str2 == "" || str3 == "") return;
            int index = str1.IndexOf(str2);
            while (index >= 0)
            {
                str1 = str1.Remove(index, str2.Length);
                str1 = str1.Insert(index, str3);
                lbStr1.Text = lbStr1.Text.Remove(index, str2.Length);
                lbStr1.Text = lbStr1.Text.Insert(index, str3);
                index = lbStr1.Text.IndexOf(str2);
            }
        }

        private void BtnReverse_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] strs = lbStr1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(strs);
            lbStr1.Text = string.Join(" ", strs);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            string str1 = lbStr1.Text.ToLower();
            string str2 = txtStr2.Text.ToLower();
            if (str2 == "") return;
            int index = str1.IndexOf(str2);
            while (index >= 0)
            {
                str1 = str1.Remove(index, str2.Length);
                lbStr1.Text = lbStr1.Text.Remove(index, str2.Length);
                index = lbStr1.Text.IndexOf(str2);
            }
        }

        private void BtnStand_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] words = lbStr1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            lbStr1.Text = string.Join(" ", words);
        }

        private void BtnSubString_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt16(txtPosition2.Text);
            int length = Convert.ToInt16(txtLength.Text);
            if(pos < 0 || pos > lbStr1.Text.Length ||
                length < 0 || length > lbStr1.Text.Length - 1 - pos) return;
            MessageBox.Show(string.Format("Chuỗi con lấy được là: {0}", lbStr1.Text.Substring(pos, length)),
                "CHUỖI CON", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
