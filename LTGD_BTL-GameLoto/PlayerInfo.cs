namespace Game_Loto
{
    public class PlayerInfo
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string money = "25000";
        public string Money
        {
            get { return money; }
            set { money = value; }
        }


        private string avt;
        public string Avt
        {
            get { return avt; }
            set { avt = value; }
        }
        private string win;
        public string Win
        {
            get { return win; }
            set { win = value; }
        }


        public PlayerInfo(string name, string money, string avata, string win)
        {
            this.Name = name;
            this.Money = money;
            this.avt = avata;
            this.win = win;

        }
    }
}
