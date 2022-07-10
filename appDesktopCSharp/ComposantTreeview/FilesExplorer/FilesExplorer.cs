using FilesExplorer.Class;

namespace FilesExplorer
{
    public partial class FilesExplorer : Form
    {
        public FilesExplorer()
        {
            InitializeComponent();
            treeView.ImageList = imageList;
        }

        private void btnPathSelected_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txtBoxPath.Text = dialog.SelectedPath;
            }
        }

        private void btnHardDiskPath_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            DirectoryInfo dir = new DirectoryInfo(txtBoxPath.Text);
            TreeNode node = new TreeNode(dir.Name);
            treeView.Nodes.Add(node);
            TreeNodeMaker.MakeNode(dir, node);
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(this.ExpandOrCollapse);
            thread.Start(sender);
        }

        private void ExpandOrCollapse(object? sender)
        {
            Button btn = (Button)sender;
            this.Invoke(new MethodInvoker(() =>
            {
                if (btn.Name == "btnExpand")
                {
                    treeView.ExpandAll();
                }
                else
                {
                    treeView.CollapseAll();
                }
            }));
        }

    }
}