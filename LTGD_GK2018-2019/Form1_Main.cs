using System.Windows.Forms;

namespace LTGD_GK2018_2019
{
    public partial class Form1_Main : Form
    {
        public Form1_Main()
        {
            Form f = new Form1_Intro();
            f.ShowDialog();
            InitializeComponent();
        }

        private void Form1_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Đóng ứng dụng?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ImageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form f = new Form1_Image();
            f.MdiParent = this;
            f.Show();
        }

        private void ListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form f = new Form1_List();
            f.MdiParent = this;
            f.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
