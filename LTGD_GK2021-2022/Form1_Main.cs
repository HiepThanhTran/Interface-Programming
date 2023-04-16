using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LTGD_GK2021_2022
{
    public partial class Form1_Main : Form
    {
        private List<string> paths;
        private Rectangle rect;
        private int stepX = 10;
        private int stepY = 7;

        public Form1_Main()
        {
            Form f = new Form1_Intro();
            f.ShowDialog();
            InitializeComponent();
        }

        private void AddItemsToListBox(List<string> paths)
        {
            foreach (string file in paths)
            {
                listBox1.Items.Add(Path.GetFileName(file));
            }
        }

        private void DrawImage()
        {
            if (listBox1.SelectedIndex != -1)
            {
                Image img = Image.FromFile(paths[listBox1.SelectedIndex]);
                Graphics g = label1.CreateGraphics();
                g.Clear(label1.BackColor);
                g.DrawImage(img, rect);
                img.Dispose();
            }
        }

        private void Form1_Main_Load(object sender, System.EventArgs e)
        {
            paths = Directory.GetFiles(Application.StartupPath + @"\Hinh").ToList();
            AddItemsToListBox(paths);
            rect = new Rectangle(80, 100, 100, 100);
        }

        private void Form1_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Exit?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void InsertImageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "All Files |*.png;*.jpg;*.jpeg;*.bmp;*.gif" +
                "| PNG|*.png" +
                "| JPG |*.jpg" +
                "| JPEG |*.jpeg" +
                "| Bitmap |*.bmp" +
                "| GIF |*.gif";
            od.Multiselect = true;
            if (od.ShowDialog() == DialogResult.OK)
            {
                List<string> filesSelected = od.FileNames.ToList();
                AddItemsToListBox(filesSelected);
                foreach (string file in filesSelected)
                {
                    string sourceFile = file;
                    string destFile = Application.StartupPath + @"\Hinh\" + Path.GetFileName(file);
                    File.Copy(sourceFile, destFile, true);
                }
            }
        }

        private void DeleteImageToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(string.Format("Delete file {0}?", listBox1.SelectedItem), "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                File.Delete(paths[listBox1.SelectedIndex]);
                paths.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void ListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DrawImage();
        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                if (rect.X <= 0 || rect.Right >= label1.Width) stepX = -stepX;
                if (rect.Y <= 0 || rect.Bottom >= label1.Height) stepY = -stepY;
                rect.X += stepX;
                rect.Y += stepY;
                DrawImage();
            }
        }

        private void Form1_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S) timer1.Enabled = !timer1.Enabled;
        }
    }
}
