using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh6
{
    public partial class BTTL_Form1 : Form
    {
        private Random rand = new Random();
        private int[] array;
        private bool flag = false;

        public BTTL_Form1()
        {
            InitializeComponent();
        }

        private void ListView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

        private void CreateArray()
        {
            try
            {
                int amount = Convert.ToInt16(txtAmount.Text);
                array = new int[amount];
                for (int i = 0; i < amount; i++)
                    array[i] = rand.Next(10, 100);
                lbArrInitial.Text = string.Join(", ", array.ToArray());
                flag = false;
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập số lượng phần tử trước khi thống kê!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Statistics()
        {
            if (lbArrInitial.Text != "" && !flag)
            {
                var arrEven = from element in array
                              where element % 2 == 0
                              select element;
                var arrOdd = from element in array
                             where element % 2 != 0
                             select element;
                int sumEven = 0, sumOdd = 0;
                double average = 0;
                foreach (var element in arrEven) sumEven += element;
                foreach (var element in arrOdd) sumOdd += element;
                foreach (var element in array) average += element; average /= array.Length;
                var arrPrime = from element in array
                               where IsPrime(element)
                               select element;

                ListViewItem listViewItem = new ListViewItem(string.Join(", ", array.ToArray()));
                listViewItem.SubItems.Add(sumEven.ToString());
                listViewItem.SubItems.Add(sumOdd.ToString());
                listViewItem.SubItems.Add(average.ToString());
                listViewItem.SubItems.Add(string.Join(", ", arrPrime.ToArray()));
                listView1.Items.Add(listViewItem);
                flag = true;
            }
        }

        private void BtnCreateArr_Click(object sender, EventArgs e)
        {
            CreateArray();
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            Statistics();
        }

        private void TxtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CreateArray();
                Statistics();
                e.SuppressKeyPress = true;
            }
        }
    }
}
