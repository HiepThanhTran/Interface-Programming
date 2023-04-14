using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiTapNhomL2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTuyChon.SelectedIndex = 0;
        }

        private void cbTuyChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTuyChon.SelectedIndex == 2)
            {
                txtViTriChen.Visible = true;
                txtViTriChen.Focus();
            }
            else txtViTriChen.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng form?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string txt = txtNhapChuoi.Text;
            if (listBox1.FindStringExact(txt) != -1) return;
            try
            {
                switch (cbTuyChon.SelectedIndex)
                {
                    case 0: listBox1.Items.Insert(0, txt); break;
                    case 1: listBox1.Items.Add(txt); break;
                    case 2:
                        int index = Convert.ToInt16(txtViTriChen.Text);
                        if (index < 0) index = 0;
                        if (index >= listBox1.Items.Count) index = listBox1.Items.Count;
                        listBox1.Items.Insert(index, txt);
                        break;
                }
                txtNhapChuoi.Text = "";
                txtViTriChen.Text = "";
                txtNhapChuoi.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Chỉ được nhập số!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (rdAll.Checked)
            {
                listBox1.Items.Clear();
            }
            else if (rdList.Checked)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
        }
    }
}
