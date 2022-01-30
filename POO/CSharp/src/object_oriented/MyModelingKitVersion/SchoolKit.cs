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
        private string _color;

        public SchoolKit(int maxToolsNumber, string color) : base(maxToolsNumber)
        {
            this.Color = color;
            this._tools = new List<WritingTool>();
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public List<WritingTool> Tools
        {
            get { return _tools; }
        }

        public void AddTool(WritingTool tool)
        {
            if (this.IsOpen)
            {
                if (tool.SchoolKitOfPen == null || Tools.Contains(tool))
                {
                    if (!this.Tools.Contains(tool))
                    {
                        if (this.Tools.Count < this.MaxToolsNumber)
                        {
                            tool.SchoolKitOfPen = this;
                            Tools.Add(tool);
                        }
                        else Console.WriteLine("There is no more room in the school kit.");
                    }
                    else Console.WriteLine("The tool is already in the school kit.");
                }
                else Console.WriteLine($"The tool is in the {tool.SchoolKitOfPen.Color} school kit.");
                
            }
            else Console.WriteLine("The school kit is closed, open it.");
        }

        public void RemoveTool(WritingTool tool)
        {
            if (this.IsOpen)
            {
                if (Tools.Contains(tool) && tool.SchoolKitOfPen != null)
                {
                    tool.SchoolKitOfPen = null;
                    Tools.Remove(tool);
                }
                else Console.WriteLine("The kit does not contain this tool.");
            }
            else Console.WriteLine("The school kit is closed, open it !");
        }

    }
}
