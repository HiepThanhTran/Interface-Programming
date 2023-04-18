using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Loto
{
    
    public partial class Host : Form
    {
        Random rand = new Random();
        List<int> result = new List<int>();
        Server server;
        bool close = false; 
        public Host()
        {
            InitializeComponent();
        }
        int RandomNumber()
        {
            int randNum = rand.Next(1, CONSTANT.MAX_RANDOM + 1);
            if (result.Count == 0)
            {
                result.Add(randNum);
                return randNum;
            }
            else
            {
                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i] == randNum)
                    {
                        randNum = rand.Next(1, CONSTANT.MAX_RANDOM + 1);
                        i = -1;
                    }
                }
                result.Add(randNum);
                return randNum;
            }

        }
        void Appear()
        {
            Button btn = new Button();
            btn.Text = RandomNumber().ToString();
            server.Send(int.Parse(btn.Text));
            btn.Location = new Point(0, 0);
            btn.Size = new Size(50, 50);
            pnRandom.Controls.Add(btn);
            pnRandom.Controls.SetChildIndex(btn, pnRandom.Controls.Count - 1);

        }
        //private void menuBtn_Click(object sender, EventArgs e)
        //{
        //    this.Close();
            
        //}

        private void Random_Click(object sender, EventArgs e)
        {
            try
            {
                Appear();
            }
            catch (Exception ex) {
                MessageBox.Show("Chưa có người tham gia","Thông báo");
            }

        }

        void Quit()
        {
            Application.Exit();
        }
        void NewGame()
        {
            result.Clear();
        }
        private void Host_Load(object sender, EventArgs e)
        {
            try
            {
                server = new Server();
                ID.Text = server.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
                server.IP = ID.Text;
                if (!server.ConnectServer())
                {
                    server.CreateServer();
                    MessageBox.Show("Tạo phòng thành công","Thông báo");
              
                    Thread listenThread = new Thread(() =>
                    {
                        while (true)
                        {
                            
                            try
                            {
                                string data = (string)server.Receive();
                                MessageBox.Show(data);

                            }
                            catch
                            {

                            }
                        }
                    });
                    listenThread.IsBackground = true;
                    listenThread.Start();

                }
                else
                {
                    MessageBox.Show("Phòng đã tồn tại !", "Thông báo");
                    close = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kiếm tra kết nối!","Lỗi kết nối mạng");
            }
            
          
        }
       

      
    }
}