using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TreeView.Class
{
    internal class FT_File : FT_Node
    {
        public string Extention { get; set; }

        public FT_File(
            string extention, 
            string name,
            string path,
            FT_Node parent,
            bool isAuthorized
            ) : base(name, path, parent, isAuthorized)
        {
            
            this.Extention = extention;
        }
    }
}
