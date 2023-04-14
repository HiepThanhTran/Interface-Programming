using System;
using System.Windows.Forms;

namespace LTGD_GK2018_2019
{
    public partial class Form1_List : Form
    {
        public Form1_List()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            string nameBook = txtNameBook.Text;
            string nameAuthor = txtNameAuthor.Text;
            if (nameBook == "" || nameAuthor == "") return;
            ListViewItem listViewItem = new ListViewItem(nameBook);
            listViewItem.SubItems.Add(nameAuthor);
            listView1.Items.Add(listViewItem);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
    }
}
