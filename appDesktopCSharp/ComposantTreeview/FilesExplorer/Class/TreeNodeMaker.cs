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
            List<string> directories = new List<string>();
            TreeNode nodes = new TreeNode(path);
            /*foreach (var fs in Directory.GetFiles(path))
            {
                nodes.Nodes.Add(fs);
            }*/
            foreach (string item in Directory.GetDirectories(path))
            {
                //directories.Add(item);
                nodes.Nodes.Add(AddNode(item));
            }
            /*foreach (string item in directories)
            {
                foreach (var fs in Directory.GetFiles(item))
                {
                    nodes.Nodes.Add(fs);
                }
            }*/
            return nodes;
        }

    }
}
