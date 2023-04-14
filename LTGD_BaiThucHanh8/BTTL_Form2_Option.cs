using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh8
{
    public partial class BTTL_Form2_Option : Form
    {
        private List<RadioButton> radioButtons;

        public BTTL_Form2_Option()
        {
            InitializeComponent();
        }

        private void BTTL_Form2_Option_Load(object sender, EventArgs e)
        {
            radioButtons = groupBox1.Controls.OfType<RadioButton>().ToList();
            lbColor.BackColor = BTTL_Form2.shapeColor;
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Text == BTTL_Form2.shapeType)
                {
                    radioButton.Checked = true;
                    break;
                }
            }
        }

        private void LbColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog
            {
                AllowFullOpen = true,
                FullOpen = true
            };
            if (dlg.ShowDialog() == DialogResult.OK) lbColor.BackColor = dlg.Color;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            BTTL_Form2.shapeColor = lbColor.BackColor;
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    BTTL_Form2.shapeType = radioButton.Text;
                    break;
                }
            }
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
