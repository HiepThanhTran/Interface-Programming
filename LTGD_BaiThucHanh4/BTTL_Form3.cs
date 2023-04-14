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
    public partial class BTTL_Form3 : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        private OpenFileDialog openFileDialog;
        private readonly int fadeValue = 10;
        private ColorDialog colorDialog;
        private FontDialog fontDialog;
        private bool flag = false;

        public BTTL_Form3()
        {
            InitializeComponent();
        }

        private void FormLoad()
        {
            textBox1.Text = "Chương trình demo sử dụng các hộp thoại thông dụng của Windows";
            textBox1.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);
            textBox1.ForeColor = Color.Blue;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            timerFadeIn.Start();
            FormLoad();
        }

        private void TimerFadeIn_Tick(object sender, EventArgs e)
        {
            Opacity += 0.01 * fadeValue;
            if (Opacity >= 1)
            {
                timerFadeIn.Stop();
                Enabled = true;
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == false && MessageBox.Show("Chắc chắn đóng form?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            flag = true;
            if (Opacity > 0)
            {
                e.Cancel = true;
                timerFadeOut.Start();
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

        private void BtnOneFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                Filter = "Text File (*.txt) |*.txt"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void BtnMultiFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Text File (*.txt) |*.txt"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                int totalFile = openFileDialog.FileNames.Length;
                textBox1.Text = string.Format("Có {0} file:\r\n", totalFile);
                for (int i = 0; i < totalFile; i++)
                {
                    textBox1.Text += openFileDialog.FileNames[i] + "\r\n";
                }
            }
        }

        private void BtnBrowserFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Choose a folder",
                ShowNewFolderButton = true
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void BtnBackColor_Click(object sender, EventArgs e)
        {
            colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog.Color;
            }
        }

        private void BtnForeColor_Click(object sender, EventArgs e)
        {
            colorDialog = new ColorDialog
            {
                FullOpen = true
            };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog.Color;
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            fontDialog = new FontDialog
            {
                ShowEffects = true,
                ShowApply = true,
                ShowColor = true
            };
            fontDialog.Apply += FontDialog_Apply;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
                textBox1.ForeColor = fontDialog.Color;
            }
        }

        private void FontDialog_Apply(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog.Font;
            textBox1.ForeColor = fontDialog.Color;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
