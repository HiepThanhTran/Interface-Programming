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
    public partial class Menu : Form
    {
        public static int parentX, parentY;
        public static PlayerInfo playerInfo = new PlayerInfo("Người chơi","25000", "D:\\Documents\\Workspace\\C#\\BTl\\Game_Loto\\Game_Loto\\Resources\\avt.png", "0");
        public static int win;

        public Menu()
        {
            InitializeComponent();
               
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Host_Click(object sender, EventArgs e)
        {
            Host host = new Host();
            host.ShowDialog();
          

        }

        private void PlayerInfo_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using PlayerInfor_Show modal = new();

            modalBackground.StartPosition = FormStartPosition.Manual;
            modalBackground.FormBorderStyle = FormBorderStyle.None;
            modalBackground.Opacity = .50d;
            modalBackground.BackColor = Color.Black;
            modalBackground.Size = this.Size;
            modalBackground.Location = this.Location;
            modalBackground.ShowInTaskbar = false;
            modalBackground.Show();
            modal.Owner = modalBackground;

            parentX = this.Location.X;
            parentY = this.Location.Y;

            modal.ShowDialog();
            modalBackground.Dispose();
        }

        private void Player_Click(object sender, EventArgs e)
        {
            Form modalBackground = new Form();
            using FindRoom modal = new();

            modalBackground.StartPosition = FormStartPosition.Manual;
            modalBackground.FormBorderStyle = FormBorderStyle.None;
            modalBackground.Opacity = .50d;
            modalBackground.BackColor = Color.Black;
            modalBackground.Size = this.Size;
            modalBackground.Location = this.Location;
            modalBackground.ShowInTaskbar = false;
            modalBackground.Show();
            modal.Owner = modalBackground;

            parentX = this.Location.X;
            parentY = this.Location.Y;

            modal.ShowDialog();
            modalBackground.Dispose();
        }
    }
}