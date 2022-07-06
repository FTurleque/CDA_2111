using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExplorer.Class
{
    internal class TreeNodeMaker
    {
        TreeView treeView;

        public TreeNodeMaker(TreeView _treeView)
        {
            this.treeView = _treeView;
        }

        public void MakeNodes(string path)
        {
            treeView.Nodes.Add(AddNode(path));
        }

        private TreeNode AddNode(string path)
        {
            TreeNode nodes = new TreeNode(path);
            foreach (var item in Directory.GetFiles(path))
            {
                nodes.Nodes.Add(item);
            }
            foreach (var item in Directory.GetDirectories(path))
            {
                nodes.Nodes.Add(AddNode(item));
            }
            return nodes;
        }
    }
}
