using LTGD_BaiThucHanh7.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace LTGD_BaiThucHanh7
{
    public partial class Form2 : Form
    {
        List<Employee> employees = new List<Employee>();

        public Form2()
        {
            InitializeComponent();
        }

        private void ShowList()
        {
            foreach (Employee employee in employees)
            {
                ListViewItem listViewItem = new ListViewItem(employee.Name);
                listViewItem.SubItems.Add(employee.Age.ToString());
                listViewItem.SubItems.Add(employee.Address);
                lvEmployee.Items.Add(listViewItem);
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtAge.Text == "") return;
            try
            {
                int age = Convert.ToInt32(txtAge.Text.Trim());
                string address = txtAddress.Text.Trim();
                string name = txtName.Text.Trim();
                employees.Add(new Employee(name, age, address));
                txtAge.Text = txtName.Text = txtAddress.Text = "";
                txtName.Focus();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvEmployee.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Employee Files |*.empl";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = null;
                try
                {
                    stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter formatter = new BinaryFormatter();
                    employees = formatter.Deserialize(stream) as List<Employee>;
                }
                catch
                {

                }
                finally
                {
                    stream.Close();
                }
            }
            ShowList();
            tabControl1.SelectedIndex = 1;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Employee Files |*.empl";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = null;
                try
                {
                    stream = new FileStream(sd.FileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, employees);
                }
                catch
                {

                }
                finally
                {
                    stream.Close();
                }
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                ShowList();
                txtAge.Text = txtName.Text = txtAddress.Text = "";
            }
        }
    }
}
