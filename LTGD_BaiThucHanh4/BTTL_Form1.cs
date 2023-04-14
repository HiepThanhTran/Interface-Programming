using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh4
{
    public partial class BTTL_Form1 : Form
    {
        public BTTL_Form1()
        {
            InitializeComponent();
        }

        private void BTTL_Form1_Load(object sender, EventArgs e)
        {
            foreach (var color in typeof(Color).GetProperties())
            {
                if (color.PropertyType == typeof(Color))
                {
                    cbColor.Items.Add(color.Name);
                }
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtChuoi.Text);
            txtChuoi.Text = "";
            txtChuoi.Focus();
        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add(listBox1.SelectedItems[listBox1.SelectedItems.Count - 1 - i]);
                listBox1.Items.Remove(listBox1.SelectedItems[listBox1.SelectedItems.Count - 1 - i]);
            }
        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItems.Count > 0)
            {
                listBox1.Items.Add(listBox2.SelectedItems[0]);
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chắn muốn xóa các phần tử được chọn trên 2 listbox?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (listBox1.SelectedItems.Count > 0)
                {
                    for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        listBox1.Items.Remove(listBox1.SelectedItems[i]);
                    }
                }
                if (listBox2.SelectedItems.Count > 0)
                {
                    listBox2.Items.Remove(listBox2.SelectedItems[0]);
                }
            }
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chắn muốn xóa hết các phần tử trên 2 listbox?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.BackColor = Color.FromName(cbColor.SelectedItem.ToString());
        }
    }
}
