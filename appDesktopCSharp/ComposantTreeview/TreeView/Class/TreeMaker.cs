using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView.Class
{
    public static class TreeMaker
    {
        private static IEnumerable<string> files = Enumerable.Empty<string>();
        private static IEnumerable<string> dirs = Enumerable.Empty<string>();

        public static void GetFiles(string path)
        {
            files.Append(path);
        }

        public static void GetDirectories(string path)
        {
            dirs.Append(path);
        }

        public static void MakeNode()
        {

        }

        public static void AddParentNode()
        {

        }

        public static void AddChild()
        {

        }
    }
}
