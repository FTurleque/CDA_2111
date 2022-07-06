using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView.Class
{
    public class TreeMaker
    {
        private static IEnumerable<string> files = Enumerable.Empty<string>();
        private static IEnumerable<string> dirs = Enumerable.Empty<string>();

        TreeView tree;

        /*public static void GetFiles(string path)
        {
            files.Append(path);
        }

        public static void GetDirectories(string path)
        {
            
            var tmp = Directory.EnumerateDirectories(path);
        }*/

        public void MakeNode(string path)
        {
            // Repartition selon fichier ou dossier
            foreach (var item in Directory.EnumerateDirectories(path))
            {
                if (item is Directory)
                {
                    dirs.Append(item);
                }
                if (item is File)
                {
                    files.Append(item);
                }
            }
        }

        public static void AddParentNode()
        {

        }

        public static void AddChild()
        {

        }
    }
}
