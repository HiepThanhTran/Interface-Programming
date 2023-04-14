using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh6
{
    public partial class Form2 : Form
    {
        private Random rand = new Random();
        private int[] array;

        public Form2()
        {
            InitializeComponent();
        }

        private void BtnCreateArr_Click(object sender, EventArgs e)
        {
            lbArrDescending.Text = "";
            lbArrAscending.Text = "";
            lbArrReverse.Text = "";
            lbArrEvenOdd.Text = "";
            try
            {
                int amount = Convert.ToInt16(txtAmount.Text);
                array = new int[amount];
                for (int i = 0; i < amount; i++)
                    array[i] = rand.Next(10, 100);
                lbArrInitial.Text = string.Join(", ", array.ToArray());
            }
            catch (FormatException)
            {
                MessageBox.Show("Hãy nhập số lượng phần tử trước khi thực hiện các thao tác!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            if (lbArrInitial.Text != "")
            {
                // Đảo mảng ban đầu
                Array.Reverse(array);
                lbArrReverse.Text = string.Join(", ", array.ToArray());

                // Sắp xếp tăng mảng ban đầu
                Array.Sort(array);
                lbArrAscending.Text = string.Join(", ", array.ToArray());

                // Sắp xếp giảm mảng ban đầu
                Array.Reverse(array);
                lbArrDescending.Text = string.Join(", ", array.ToArray());

                // Sắp xếp chẵn tăng, lẻ giảm
                //var sortedNumbers = array.OrderBy(n => n % 2).ThenBy(n => n % 2 == 0 ? n : -n);
                //lbArrEvenOdd.Text = string.Join(", ", sortedNumbers.ToArray());

                int[] arrChanLe = new int[array.Length];
                Array.Copy(array, arrChanLe, array.Length);
                int i = 0, j = array.Length - 1;
                while (i < j)
                {
                    if (arrChanLe[i] % 2 == 0) i++;
                    if (arrChanLe[j] % 2 != 0) j--;
                    if (i < j)
                    {
                        if (arrChanLe[i] % 2 != 0 && arrChanLe[j] % 2 == 0)
                        {
                            Swap(ref arrChanLe[i], ref arrChanLe[j]);
                            i++; j--;
                        }
                    }
                }
                int mid = arrChanLe[i] % 2 != 0 ? i - 1 : i;
                // Sắp xếp chẵn tăng
                for (int index = 0; index <= mid; index++)
                {
                    for (int jndex = index + 1; jndex <= mid; jndex++)
                    {
                        if (arrChanLe[index] > arrChanLe[jndex])
                        {
                            Swap(ref arrChanLe[index], ref arrChanLe[jndex]);
                        }
                    }
                }
                // Sắp xếp lẻ giảm
                for (int index = mid + 1; index < arrChanLe.Length; index++)
                {
                    for (int jndex = index + 1; jndex < arrChanLe.Length; jndex++)
                    {
                        if (arrChanLe[index] < arrChanLe[jndex])
                        {
                            Swap(ref arrChanLe[index], ref arrChanLe[jndex]);
                        }
                    }
                }
                lbArrEvenOdd.Text = string.Join(", ", arrChanLe.ToArray());
            }
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
