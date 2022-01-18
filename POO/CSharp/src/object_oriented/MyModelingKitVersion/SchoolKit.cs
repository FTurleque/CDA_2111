using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    class SchoolKit : Kit
    {
        private List<WritingTool> _tools;

        public List<WritingTool> Tools
        {
            get { return _tools; }
        }

        public SchoolKit(int maxToolsNumber) : base(maxToolsNumber)
        {
            this._tools = new List<WritingTool>();
        }

        public void AddTool(WritingTool tool)
        {
            if (this.IsOpen)
            {
                if (!this.Tools.Contains(tool))
                {
                    if (this.Tools.Count < this.MaxToolsNumber)
                    {
                        this.Tools.Add(tool);
                    }
                    else
                    {
                        Console.WriteLine("Plus de place dans la trousse.");
                    }
                }
                else
                {
                    Console.WriteLine("L'outil est déjà dans la trousse.");
                }
            }
            else
            {
                Console.WriteLine("La trousse est fermé, ouvrez la.");
            }
            
        }

        public void RemoveTool(WritingTool tool)
        {
            if (this.IsOpen)
            {
                if (this.Tools.Contains(tool))
                {
                    this.Tools.Remove(tool);
                }
                else
                {
                    Console.WriteLine("La trousse ne contient pas cet outil.");
                }
            }
            else
            {
                Console.WriteLine("La trousse est fermée. On ne peut rien en sortir.");
            }
        }
    }
}
