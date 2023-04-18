using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Loto
{
    public partial class PlayerInfor_Show : Form
    {
        
        public PlayerInfor_Show()
        {
            InitializeComponent();
        }

        private void btnAvt_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)| *jpg|PNG files(*.png)| *png";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    avata.ImageLocation = imageLocation;
                    Menu.playerInfo.Avt = imageLocation;
                }
            }
            catch(Exception) {
                MessageBox.Show("Lõi chọn ảnh","Lỗi!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                modalEffect_Timer.Stop();
            }
            else
            {
                Opacity += .02;
            }

            int y = Menu.parentY += 1;
            this.Location = new Point(Menu.parentX + 220, y);
            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }
        int i;
        private void PlayerInfor_Show_Load(object sender, EventArgs e)
        {
            i = Menu.parentY + 150;
            this.Location = new Point(Menu.parentX + 220, Menu.parentY + 150);
            txtMoney.Text = Menu.playerInfo.Money;
            avata.ImageLocation = Menu.playerInfo.Avt;
            txtNum.Text = Menu.playerInfo.Win;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
             txtName.Text = Menu.playerInfo.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            Menu.playerInfo.Name= txtName.Text;
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void lbMoney_Click(object sender, EventArgs e)
        {

        }

        private void lbWin_Click(object sender, EventArgs e)
        {

        }
    }
}
