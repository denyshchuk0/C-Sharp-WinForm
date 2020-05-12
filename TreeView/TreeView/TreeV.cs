using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            listView.Columns.Add("Name");
            listView.Columns[0].Width = 100;
            listView.Columns.Add("Size");
            listView.Columns[1].Width = 100;
            listView.Columns.Add("CreationTime");
            listView.Columns[2].Width = 100;
            listView.SmallImageList = smallIcon;
            listView.LargeImageList = largeIcon;
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
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                if ((directory.Attributes & FileAttributes.System) == 0)
                {
                    //значит это не скрытая папка
                    string[] dirs = Directory.GetDirectories(path);
                    foreach (string dir in dirs)
                    {
                        TreeNode dirNode = new TreeNode();
                        dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                        driveNode.Nodes.Add(dirNode);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
               if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
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
            catch (Exception ex) { }
        }

        private void treeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                e.Node.Nodes.Clear();
                string[] dirs = Directory.GetDirectories(e.Node.FullPath);
                DirectoryInfo directory = new DirectoryInfo(e.Node.FullPath);
                if ((directory.Attributes & FileAttributes.Hidden) == 0)
                {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
        private void FillListView(string[] files, int index)
        {
            int i = 0;
            foreach (string file in files)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                lvi.ImageIndex = index;
                //if (fi == null)
                //{
                //    lvi.SubItems.Add(fo[i].Name);
                //}
                //else { 
                //lvi.SubItems.Add(fi[i].Length.ToString());
                //    }
                listView.Items.Add(lvi);
                i++;
            }
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            listView.Items.Clear();
            toolStripStatusLabel1.Text = treeView.SelectedNode.FullPath;
            RefreshListView(toolStripStatusLabel1.Text);
        }

        private void RefreshListView(string path)
        {
            //DirectoryInfo dir = new DirectoryInfo(path);
          
            string[] folder = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            //FileInfo[] fi = dir.GetFiles("*.*");
            //DirectoryInfo[] fo = dir.GetDirectories();

            FillListView(folder, 0);
            FillListView(files, 1);
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string tmp = toolStripStatusLabel1.Text;
            toolStripStatusLabel1.Text += "\\" + listView.SelectedItems[0].Text;
            if (toolStripStatusLabel1.Text.Contains(".") == true)
            {
                Process.Start(toolStripStatusLabel1.Text);
                toolStripStatusLabel1.Text = tmp;
            }
            else
            {
                listView.Items.Clear();
                RefreshListView(toolStripStatusLabel1.Text);
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.FullRowSelect = true;
            listView.View = View.Details;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.View = View.LargeIcon;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.View = View.List;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            listView.View = View.SmallIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            listView.View = View.Tile;
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView.Sort();
        }
    }
}
