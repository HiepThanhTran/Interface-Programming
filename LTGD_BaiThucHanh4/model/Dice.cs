using System.Drawing;
using System.Windows.Forms;


namespace LTGD_BaiThucHanh4.model
{
    internal class Dice
    {
        private static string path = Application.StartupPath;
        private Image image;
        private int number;

        public Dice() { }

        public Dice(string path) { image = Image.FromFile(path); }

        public Image Image { get { return image; } set { image = value; } }
        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                image = Image.FromFile(path + string.Format(@"\Dice\dice{0}.png", number));
            }
        }
    }
}
