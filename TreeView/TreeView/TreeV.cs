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

namespace TreeView
{
    public partial class TreeV : Form
    {
        public TreeV()
        {
            InitializeComponent();

        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                TreeNode driveNode = new TreeNode { Text = folderBrowserDialog.SelectedPath.ToString() };
                FillTreeNode(driveNode, folderBrowserDialog.SelectedPath);
                treeView.Nodes.Add(driveNode);
            }
        }

        private void FillTreeNode(TreeNode driveNode, string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                TreeNode dirNode = new TreeNode();
                dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                driveNode.Nodes.Add(dirNode);
            }
        }
        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs = Directory.GetDirectories(e.Node.FullPath);
            if (dirs.Length != 0)
            {
                for (int i = 0; i < dirs.Length; i++)
                {
                    TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                    FillTreeNode(dirNode, dirs[i]);
                    e.Node.Nodes.Add(dirNode);
                }
            }
        }
    }
}
