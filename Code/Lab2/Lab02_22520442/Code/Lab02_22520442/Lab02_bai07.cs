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
                TreeNode root = new TreeNode() { Text=path};
                treeView1.Nodes.Add(root);
                loadDrive(root);
            }
            
        }
        string path = @"D:\";
        void loadDrive(TreeNode root)
        {
            if(root == null)
                return;
            try
            {


                var folderList = new DirectoryInfo(root.Text).GetDirectories();
                if (folderList.Count() == 0) return;
                foreach (DirectoryInfo item in folderList)
                {
                    if (Directory.Exists(item.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = item.FullName };
                        root.Nodes.Add(node);
                        loadDrive(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }
        
    }
}
