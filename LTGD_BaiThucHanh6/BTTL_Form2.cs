using LTGD_BaiThucHanh6.model;
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
    public partial class BTTL_Form2 : Form
    {
        private List<Student> Students = new List<Student>();

        public BTTL_Form2()
        {
            InitializeComponent();
        }

        private void AddItemToListView(Student student)
        {
            ListViewItem listViewItem = new ListViewItem(student.Id);
            listViewItem.Tag = student;
            listViewItem.SubItems.Add(student.FirstName);
            listViewItem.SubItems.Add(student.LastName);
            listViewItem.SubItems.Add(student.FirstName + " " + student.LastName);
            listView1.Items.Add(listViewItem);
        }

        private void AddItemsToListView()
        {
            foreach (Student student in Students)
            {
                AddItemToListView(student);
            }
        }

        private void InsertStudent()
        {
            listView1.Items.Clear();
            AddItemsToListView();
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string id = txtId.Text;
            if (firstName == "" || lastName == "" || id == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin sinh viên cần thêm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Student student = new Student(firstName, lastName, id);
            AddItemToListView(student);
            Students.Add(student);
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtId.Text = "";
            txtId.Focus();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            InsertStudent();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Student student = listView1.SelectedItems[0].Tag as Student;
                listView1.Items.Remove(listView1.SelectedItems[0]);
                Students.Remove(student);
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtId.Text = "";
                txtId.Focus();
            }
        }

        private void SearchStudent()
        {
            string keyWord = txtKeyWord.Text.ToLower();
            if (keyWord == "")
            {
                MessageBox.Show("Nhập mã số sinh viên hoặc tên cần tìm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listView1.Items.Clear();
            foreach (Student student in Students)
            {
                if (student.Id.ToLower().Contains(keyWord) || student.LastName.ToLower().Contains(keyWord))
                {
                    AddItemToListView(student);
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchStudent();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            Students.Sort((s1, s2) => s1.LastName.CompareTo(s2.LastName));
            listView1.Items.Clear();
            AddItemsToListView();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                TextBox txt = sender as TextBox;
                if (txt.Name == "txtKeyWord") SearchStudent();
                else InsertStudent();
            }
        }
    }
}
