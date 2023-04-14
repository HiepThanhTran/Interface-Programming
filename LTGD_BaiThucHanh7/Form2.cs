using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using LTGD_BaiThucHanh7.model;

namespace LTGD_BaiThucHanh7
{
    public partial class Form2 : Form
    {
        List<Employee> employees = new List<Employee>();

        public Form2()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(txtAge.Text.Trim());
                string address = txtAddress.Text.Trim();
                string name = txtName.Text.Trim();
                if (address != "" && name != "")
                {
                    employees.Add(new Employee(name, age, address));
                    ListViewItem listViewItem = new ListViewItem(name);
                    listViewItem.SubItems.Add(age.ToString());
                    listViewItem.SubItems.Add(address);
                    lvEmployee.Items.Add(listViewItem);
                    txtAge.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtName.Focus();
                }
            }
            catch(FormatException ex)
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
                FileStream stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                employees = formatter.Deserialize(stream) as List<Employee>;
            }
            foreach (Employee employee in employees)
            {
                ListViewItem listViewItem = new ListViewItem(employee.Name);
                listViewItem.SubItems.Add(employee.Age.ToString());
                listViewItem.SubItems.Add(employee.Address);
                lvEmployee.Items.Add(listViewItem);
            }
            tabControl1.SelectedIndex = 1;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Employee Files |*.empl";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, employees);
            }
        }
    }
}
