using LTGD_BaiThucHanh8.model;
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
            lbColor.BackColor = BTTL_Form2.shape.Color;
            rbRectangle.Tag = ShapeType.Rectangle;
            rbEllipse.Tag = ShapeType.Ellipse;
            rbTriangle.Tag = ShapeType.Triangle;
            (radioButtons.FirstOrDefault(rb => (ShapeType)rb.Tag == BTTL_Form2.shape.Type)).Checked = true;
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
            ShapeType shapeType = (ShapeType)(radioButtons.FirstOrDefault(rb => rb.Checked)).Tag;
            BTTL_Form2.shape = ShapeFactory.CreateShape(shapeType);
            BTTL_Form2.shape.Color = lbColor.BackColor;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
