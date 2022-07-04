using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TreeView.Class
{
    internal class FT_Directory : FT_Node
    {
        public List<FT_Node> Child
        {
            get => default;
            set { }
        }

        public FT_Directory(
            List<FT_Node> child,
            string name,
            string path,
            FT_Node parent,
            bool isAuthorized
            ) : base(name, path, parent, isAuthorized)
        {
            this.Child = child;
        }
    }
}
