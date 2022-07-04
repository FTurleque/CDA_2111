using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TreeView.Class
{
    internal abstract class FT_Node
    {
        public string Name  { get; set; }

        public string Path { get; set; }

        public FT_Node Parent { get; set; }

        public bool IsAuthorized { get; set; }

        public FT_Node(
            string name, 
            string path, 
            FT_Node parent, 
            bool isAuthorized
            )
        {
            this.Name = name;
            this.Path = path;
            this.Parent = parent;
            this.IsAuthorized = isAuthorized;
        }

        public void GetFiles(string path)
        {
            var f = Directory.GetFiles(path);
        }
    }
}
