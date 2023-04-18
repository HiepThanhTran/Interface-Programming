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
    public partial class Player : Form
    {
        Random rnd = new Random();
        List<int> result = new List<int>();
        List<int> server = new List<int>();
        Server socket;
        public Player()
        {
            InitializeComponent();
        }
        public void CreatePaper()
        {
            asset.Text = Menu.playerInfo.Money;
            for (int i = 0; i < 8; i++)
            {

                List<int> matrix = RandomNumbers(i * 10 + 1, i * 10 + 9);
                foreach (int num in matrix)
                {
                    flowLayoutPanel1.Controls.Add(btn(num));
                }
            }
            for (int i = 72; i < 81; i++)
            {
                flowLayoutPanel1.Controls.Add(btn(rnd.Next(80, 91)));

            }
            int[] nums = new int[9];
            for (int i = 0; i < 9; i++)
            {
                nums[0] = i;

                for (int j = 1; j < nums.Length; j++)
                {
                    nums[j] = nums[j - 1] + 9;
                }
                List<int> ramdonBlank = RandomArray(nums, 4);
                int randomIndex = rnd.Next(nums.Length);
                foreach (int num in ramdonBlank)
                {
                    int randomNum = num;
                    flowLayoutPanel1.Controls[randomNum].Text = "";
                    flowLayoutPanel1.Controls[randomNum].BackColor = Color.FromArgb(000,255,255);
                }
            }
            result.Clear();
            server.Clear();
        }
        public static List<int> RandomNumbers(int min, int max)
        {
            List<int> numbers = new List<int>();
            Random rnd = new Random();

            while (numbers.Count < (max - min + 1))
            {
                int num = rnd.Next(min, max + 1);
                if (!numbers.Contains(num))
                {
                    numbers.Add(num);
                }
            }

            return numbers;
        }

        public static List<int> RandomArray(int[] arr, int count)
        {
            List<int> result = new List<int>();

            int[] copyArr = (int[])arr.Clone();

            Random rand = new Random();

            for (int i = 0; i < count; i++)
            {
                int index = rand.Next(i, copyArr.Length);

                result.Add(copyArr[index]);

                copyArr[index] = copyArr[i];
            }

            return result;
        }
        Button btn(int i)
        {
            Button b = new Button();
            b.Name = i.ToString();
            b.Width = 65;
            b.Height = 67;
            b.Text = i.ToString();
            b.Click += b_Click;
            return b;
        }
        void b_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.BackColor == Color.FromArgb(255, 38, 38))
            {
                b.BackColor = Color.FromArgb(255, 255, 255);

                result.Remove(GetButtonIndex(b, flowLayoutPanel1));

            }
            else
            {
                if (b.BackColor != Color.FromArgb(0, 255, 255))
                {
                    result.Add(GetButtonIndex(b, flowLayoutPanel1));

                    b.BackColor = Color.FromArgb(255, 38, 38);
                }

            }

        }
        static bool check_Win(List<int> dynamicArray)
        {
            
            for (int i = 0; i < dynamicArray.Count - 1; i++)
            {
                
                for (int j = i + 1; j < dynamicArray.Count; j++)
                {
                    if ((dynamicArray[j] - dynamicArray[i]) % 9 == 0)
                    {
                        int count = 2;
                        for (int k = j + 1; k < dynamicArray.Count; k++)
                        {
                            int diff = Math.Abs(dynamicArray[k] - dynamicArray[j]);

                            while (diff % 9 == 0 && count < 5)
                            {
                                count++;
                                k++;
                                if (k >= dynamicArray.Count)
                                {
                                    break;
                                }
                                diff = dynamicArray[k] - dynamicArray[k - 1];
                            }

                            if (count == 5)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        private int GetButtonIndex(Button button, FlowLayoutPanel panel)
        {
            return panel.Controls.IndexOf(button);
        }
        private void winBtn_Click(object sender, EventArgs e)
        {
          
            int money = int.Parse(asset.Text);
            result.Sort();
            if (check_Win(result))
            {
                MessageBox.Show("Chúc mừng bạn đã thắng");
                money += 5000;
                asset.Text = money.ToString();
                Menu.win += 1;
                Menu.playerInfo.Win = Menu.win.ToString();
                Menu.playerInfo.Money = asset.Text;
                server.Clear();
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel2.Controls.Clear();
                CreatePaper();
              
                try
                {
                    socket.Send($"{Menu.playerInfo.Name} đã thắng");
                }
                catch(Exception ex)
                {

                }
            }
            else
            {
                if (money<= 0)
                {
                    if (MessageBox.Show("Bạn đã cháy túi >.<!", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    { }
                }
                else
                {
                    MessageBox.Show("Bạn đã thua!");
                    
                    money -= 5000;
                    asset.Text = money.ToString();
                    Menu.playerInfo.Money = asset.Text;
                    server.Clear();
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel2.Controls.Clear();
                    CreatePaper();


                }

            }
            Menu.playerInfo.Money = asset.Text;
        }

        private void Player_Load(object sender, EventArgs e)
        {
            ConectServer();
            CreatePaper();

        }
        private void ConectServer()
        { 
            Server socket = new Server();
            socket.IP = FindRoom.IP;
            ID_player.Text = socket.IP;
            if (!socket.ConnectServer())
            {
                MessageBox.Show("Phòng không tồn tại", "Thông báo");
                this.Close();
            }
            else
            {           
                Thread listenThread = new Thread(() =>
                {
                    while (true)
                    {
                        
                        try
                        {
                            int data = (int)socket.Receive();
                            //MessageBox.Show(data.ToString());
                            server.Add(data);

                        }
                        catch
                        {
                            

                        }
                       
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();      
                
                socket.Send($"{Menu.playerInfo.Name} mới tham gia");
                MessageBox.Show("Kết nối thành công!", "Thông báo");
               

            }
            //if (socket.IP != socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211))
            //{
            //    string[] addresses = { socket.IP, socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211) };

            //    foreach (string address in addresses)
            //    {
            //        PingReply reply = new Ping().Send(address);
            //        if (reply.Status == IPStatus.Success)
            //        {
            //            MessageBox.Show("Ping thành công");
            //            if (!socket.ConnectServer())
            //            {
            //                this.Close();
            //            }
            //            else
            //            {
            //                socket.ConnectServer();
            //                socket.Send("Có người chơi thamn gia");
            //                MessageBox.Show("Kết nối thành công!");
            //            }
            //        }
            //        else
            //        {
            //            this.Close();
            //        }
            //    }

            //}
            //else
            //{
            //    socket.ConnectServer();           
            //    socket.Send("Có người chơi tham gia");
            //    MessageBox.Show("Kết nối thành công!");
            //}


        }
        private void createPagebtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            CreatePaper();
        }

        void Listen()
        {
               
        }

        private void lbMoney_Click(object sender, EventArgs e)
        {

        }

        private void lbId_Click(object sender, EventArgs e)
        {

        }
      

        private void btnServer_Click(object sender, EventArgs e)
        {
            foreach (int r in server)
            {
                flowLayoutPanel2.Controls.Add(btn(r));
                flowLayoutPanel2.Enabled= false;
            }
        }
    }
}
