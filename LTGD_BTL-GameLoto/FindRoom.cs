using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Game_Loto
{
    public partial class FindRoom : Form
    {
        
        public static string IP = "";
        public FindRoom()
        {
            InitializeComponent();
            
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

            int y = Menu.parentY += 3;
            this.Location = new Point(Menu.parentX + 220, y);
            if (y >= i)
            {
                modalEffect_Timer.Stop();
            }
        }
        int i;
        private void FindRoom_Load(object sender, EventArgs e)
        {
            i = Menu.parentY + 150;
            this.Location = new Point(Menu.parentX + 220, Menu.parentY + 150);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (ValidateIP(txtId.Text))
            {
                this.Close();
                Player player = new Player();
                IP = txtId.Text;
                player.Show();
            }
            else
            {
                MessageBox.Show("Định dạng IP không hợp lệ!", "Thông báo");

            }
        
        }
        public bool ValidateIP(string ip)
        {
            if (String.IsNullOrWhiteSpace(ip))
            {
                return false;
            }

            string[] splitValues = ip.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }
       
        
    }
}
