using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LTGD_BaiThucHanh7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arrDrive = Directory.GetLogicalDrives();
            foreach (string drive in arrDrive)
            {
                TreeNode node = new TreeNode(drive);
                treeView1.Nodes.Add(node);
                node.Nodes.Add("tmp");
            }
        }

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear();
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            try
            {
                string[] arrDir = Directory.GetDirectories(node.FullPath);
                foreach (string dir in arrDir)
                {
                    TreeNode newNode = node.Nodes.Add(Path.GetFileName(dir));
                    newNode.Nodes.Add("tmp");
                }
            }
            catch
            {

            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            fPnlPictures.Controls.Clear();
            string[] arrFile = Directory.GetFiles(e.Node.FullPath);
            foreach (string file in arrFile)
            {
                if (file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".png") ||
                    file.ToLower().EndsWith(".gif") || file.ToLower().EndsWith(".bmp") ||
                    file.ToLower().EndsWith(".jpeg") || file.ToLower().EndsWith(".ico"))
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(file),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Height = Width = 90,
                        Cursor = Cursors.Hand
                    };
                    pictureBox.Click += PictureBox_Click;
                    fPnlPictures.Controls.Add(pictureBox);
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            pctCenter.Image = ((PictureBox)sender).Image;
        }

        private void TreeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
            e.Node.SelectedImageIndex = 0;
        }
    }
}
