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
    public partial class BTTL_Form2 : Form
    {
        private FontStyle newFontStyle = FontStyle.Regular;
        private string newFontName;
        private float newFontSize;

        public BTTL_Form2()
        {
            InitializeComponent();
        }

        private void BTTL_Form2_Load(object sender, EventArgs e)
        {
            FontFamily[] fonts = FontFamily.Families;
            foreach (FontFamily font in fonts)
            {
                listBox1.Items.Add(font.Name);
            }
        }

        private void HScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            lbReviewColor.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            richTextBox1.SelectionColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "") return;
            Font currentFont = richTextBox1.SelectionFont;
            newFontName = (listBox1.SelectedItem != null) ? listBox1.SelectedItem.ToString() : currentFont.Name;
            newFontSize = float.Parse(comboBox1.Text);
            if (!currentFont.Bold)
            {
                newFontStyle |= FontStyle.Bold;
            }
            else
            {
                newFontStyle &= ~FontStyle.Bold;
            }
            richTextBox1.SelectionFont = new Font(newFontName, newFontSize, newFontStyle);
        }

        private void BtnItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "") return;
            Font currentFont = richTextBox1.SelectionFont;
            newFontName = (listBox1.SelectedItem != null) ? listBox1.SelectedItem.ToString() : currentFont.Name;
            newFontSize = float.Parse(comboBox1.Text);
            if (!currentFont.Italic)
            {
                newFontStyle |= FontStyle.Italic;
            }
            else
            {
                newFontStyle &= ~FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(newFontName, newFontSize, newFontStyle);
        }

        private void BtnUnder_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText == "") return;
            Font currentFont = richTextBox1.SelectionFont;
            newFontSize = float.Parse(comboBox1.Text);
            if (!currentFont.Underline)
            {
                newFontStyle |= FontStyle.Underline;
            }
            else
            {
                newFontStyle &= ~FontStyle.Underline;
            }
            newFontName = (listBox1.SelectedItem != null) ? listBox1.SelectedItem.ToString() : currentFont.Name;
            richTextBox1.SelectionFont = new Font(newFontName, newFontSize, newFontStyle);
        }
    }
}
