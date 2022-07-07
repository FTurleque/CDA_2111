using System.IO;

namespace FilesExplorer
{
    public partial class FilesExplorer : Form
    {
        /*TreeNodeMaker nodes;*/

        public FilesExplorer()
        {
            InitializeComponent();
        }

        private void FilesExplorer_Load(object sender, EventArgs e)
        {
            //nodes = new TreeNodeMaker(treeView);
        }

        private void btnHardDiskPath_Click(object sender, EventArgs e)
        {
            /*string[] name = txtBoxPath.Text.Split('\\');
            TreeNode root = new TreeNode(name[^1]);
            TreeNode node = root;
            treeView.Nodes.Add(root);

            this.MakeNode(node, txtBoxPath.Text);*/

            DirectoryInfo dir = new DirectoryInfo(txtBoxPath.Text);
            TreeNode node = new TreeNode(txtBoxPath.Text);
            treeView.Nodes.Add(node);
            this.MakeNode(dir, node);
            /*foreach (string filePath in Directory.GetDirectories(txtBoxPath.Text)) //myList is your list of paths
            {
                node = root;
                foreach (string pathBits in filePath.Split('/'))
                {
                    node = AddNode(node, pathBits);
                }
            }*/
            /*var dir = Directory.GetDirectories(path);
            var fs = Directory.GetFileSystemEntries(path);*/
            //nodes.MakeNodes(txtBoxPath.Text);
            /*foreach (var item in Directory.EnumerateDirectories(path))
            {
                if(item is System.IO.Directory)
                {
                    string directory = (string)item;
                }
            }*/
            /*TreeMaker.MakeNode(txtBoxPath.Text);*/
            /*IEnumerable<string> paths = Directory.GetDirectories(txtBoxPath.Text);
            PopulateTreeView(treeView, paths, '\\');*/
        }

        private void MakeNode(DirectoryInfo _dir,TreeNode _parent)
        {
            /*foreach (string filePath in Directory.GetDirectories(root))
            {
                root = filePath;
                foreach (string pathBits in filePath.Split('/'))
                {
                    node = AddNode(node, pathBits);
                }
                MakeNode(node, root);
            }*/
            DirectoryInfo[] subDirs = _dir.GetDirectories();
            if(subDirs.Length > 0 && subDirs != null)
            {
                foreach (DirectoryInfo subDir in subDirs)
                {
                    TreeNode children = new TreeNode(subDir.Name, 0, 1);
                    _parent.Nodes.Add(children);
                    this.AddFiles(subDir, children);
                    MakeNode(subDir, children);
                }
            }
            AddFiles(_dir, _parent);
        }

        private void AddFiles(DirectoryInfo _dir,TreeNode _parent)
        {
            FileInfo[] subFiles = _dir.GetFiles();
            if(subFiles.Length > 0 && subFiles != null)
            {
                foreach (FileInfo subFile in subFiles)
                {
                    TreeNode nodeFile = new TreeNode(subFile.Name, 0, 1);
                    _parent.Nodes.Add(nodeFile);
                }
            }
        }

        /*private static void PopulateTreeView(TreeView treeView, IEnumerable<string> paths, char pathSeparator)
        {
            TreeNode lastNode = null;
            string subPathAgg;
            foreach (string path in paths)
            {
                subPathAgg = string.Empty;
                foreach (string subPath in path.Split(pathSeparator))
                {
                    subPathAgg += subPath + pathSeparator;
                    TreeNode[] nodes = treeView.Nodes.Find(subPathAgg, true);
                    if (nodes.Length == 0)
                        if (lastNode == null)
                            lastNode = treeView.Nodes.Add(subPathAgg, subPath);
                        else
                            lastNode = lastNode.Nodes.Add(subPathAgg, subPath);
                    else
                        lastNode = nodes[0];
                }
                PopulateTreeView(treeView, paths, pathSeparator);
            }
        }*/
    }
}