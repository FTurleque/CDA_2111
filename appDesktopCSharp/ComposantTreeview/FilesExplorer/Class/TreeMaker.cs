using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExplorer.Class
{
    public static class TreeMaker
    {
        /*private static IEnumerable<string> files = Enumerable.Empty<string>();
        private static IEnumerable<string> dirs = Enumerable.Empty<string>();*/

        /*private TreeView tree;

        public TreeMaker(TreeView _tree)
        {
            this.tree = _tree;
        }*/


        public static void MakeNode(string path)
        {
            // Repartition selon fichier ou dossier
            foreach (var res in Directory.EnumerateDirectories(path))
            {
                
            }
        }
    }
}
