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
    public partial class Form4_Main : Form
    {
        public static string userName = "";
        private readonly int fadeValue = 10;

        public Form4_Main()
        {
            Form4_Login f = new Form4_Login();
            f.ShowDialog();
            InitializeComponent();
        }

        private void Form4_Main_Load(object sender, EventArgs e)
        {
            lbUserName.Text = userName;
        }

        private void Form4_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            timerFadeOut.Start();
            if (Opacity <= 0)
            {
                e.Cancel = false;
            }
        }

        private void TimerFadeOut_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.01 * fadeValue;
            if (Opacity <= 0)
            {
                timerFadeOut.Stop();
                Close();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            ListViewItem item = new ListViewItem(txtName.Text);
            item.SubItems.Add(dtpBirthDay.Value.ToString("dd/MM/yyyy"));
            foreach (RadioButton rd in pnlGender.Controls)
            {
                if (rd.Checked)
                {
                    item.SubItems.Add(rd.Text);
                    switch (rd.Text)
                    {
                        case "Nữ": item.ImageIndex = 0; break;
                        case "Nam": item.ImageIndex = 1; break;
                    }
                    break;
                }
            }
            lsvEmployee.Items.Add(item);
            txtName.Focus();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn nhân viên cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lsvEmployee.Focus();
                return;
            }
            foreach (ListViewItem item in lsvEmployee.SelectedItems)
                lsvEmployee.Items.Remove(item);
        }
    }
}
