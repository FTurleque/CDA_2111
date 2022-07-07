using FilesExplorer.Class;

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
            string t = dir.FullName;
            TreeNode node = treeView.Nodes.Add(dir.Name);

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

        private void MakeNode(TreeNode node, string root)
        {
            foreach (string filePath in Directory.GetDirectories(root)) //myList is your list of paths
            {
                root = filePath;
                foreach (string pathBits in filePath.Split('/'))
                {
                    node = AddNode(node, pathBits);
                }
                MakeNode(node, root);
            }
        }

        private TreeNode AddNode(TreeNode node, string key)
        {
            string[] newName = key.Split('\\');
            if (node.Nodes.ContainsKey(key))
            {
                return node.Nodes[key];
            }
            else
            {
                return node.Nodes.Add(key, newName[^1]);
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