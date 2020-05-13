using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
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

            listView.FullRowSelect = true;
            listView.ContextMenuStrip = contextMenuStrip;
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

                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.Nodes.Add(dirNode);
                }

            }
            catch (Exception e) { }
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
                string[] dirs = Directory.GetDirectories(e.Node.FullPath);
                DirectoryInfo directory = new DirectoryInfo(e.Node.FullPath);

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void FillListView(string[] files, int index)
        {
            foreach (string file in files)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                lvi.ImageIndex = index;
                if (File.Exists(file))
                {
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, File.Open(file, FileMode.Open).Length + " b"));
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, File.GetCreationTime(file).ToShortDateString()));
                }
                else
                {
                    lvi.SubItems.Add(" ");
                    lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, Directory.GetCreationTime(file).ToShortDateString()));
                }
                listView.Items.Add(lvi);
            }
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            listView.Items.Clear();
            if (treeView.SelectedNode == null)
                return;
            toolStripStatusLabel1.Text = treeView.SelectedNode.FullPath;
            RefreshListView(toolStripStatusLabel1.Text);
        }

        private void RefreshListView(string path)
        {
            try
            {
                // listView.Clear();
                string[] folder = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                FillListView(folder, 0);
                FillListView(files, 1);
            }
            catch (Exception ex) { }
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string tmp = toolStripStatusLabel1.Text;
            toolStripStatusLabel1.Text += "\\" + listView.SelectedItems[0].Text;
            if (!String.IsNullOrEmpty(Path.GetExtension(toolStripStatusLabel1.Text)))
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
            this.listView.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer(int column)
            {
                col = column;
            }
            public int Compare(object x, object y)
            {
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(Path.GetExtension(toolStripStatusLabel1.Text + "\\" + listView.SelectedItems[0].Text)))
                    File.Delete(toolStripStatusLabel1.Text + "\\" + listView.SelectedItems[0].Text);
                else
                    Directory.Delete(toolStripStatusLabel1.Text + "\\" + listView.SelectedItems[0].Text);
                listView.SelectedItems[0].Remove();
            }
            catch (Exception ex) { }
        }
        private void TreeV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                deleteToolStripMenuItem_Click(null, null);
            else if (e.KeyCode == Keys.Back)
                backToolStripMenuItem_Click(null, null);
        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = toolStripStatusLabel1.Text.Substring(0, toolStripStatusLabel1.Text.LastIndexOf("\\"));
            listView.Clear();
            RefreshListView(toolStripStatusLabel1.Text);
        }
    }

}
