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

namespace Lab02_22520442
{
    public partial class Lab02_bai07 : Form
    {
        public Lab02_bai07()
        {
            InitializeComponent();
            if (Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path, Tag = path };
                treeView1.Nodes.Add(root);
                loadDrive(root);
            }
            treeView1.AfterSelect += treeView1_AfterSelect;
        }

        string path = @"D:\";

        void loadDrive(TreeNode root)
        {
            if (root == null)
                return;
            try
            {
                var directoryInfo = new DirectoryInfo(root.Tag.ToString()); 

                // Load files
                var fileList = directoryInfo.GetFiles();
                foreach (var file in fileList)
                {
                    TreeNode node = new TreeNode() { Text = file.Name, Tag = file.FullName }; 
                    root.Nodes.Add(node);
                }

                // Load directories
                var folderList = directoryInfo.GetDirectories();
                foreach (var directory in folderList)
                {
                    TreeNode node = new TreeNode() { Text = directory.Name, Tag = directory.FullName };
                    root.Nodes.Add(node);
                    loadDrive(node);
                }
            }
            catch
            {
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayFile(string filepath)
        {
            try
            {
                Image img = Image.FromFile(filepath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = img;
            }
        
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị hình ảnh: " + ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null && File.Exists(e.Node.Tag.ToString()))
            {
                DisplayFile(e.Node.Tag.ToString());
            }
        }
    }
}


