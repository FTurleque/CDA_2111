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

        private void btnHardDiskPath_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(txtBoxPath.Text);
            TreeNode node = new TreeNode(dir.Name);
            treeView.Nodes.Add(node);
            TreeNodeMaker.MakeNode(dir, node);
        }
    }
}