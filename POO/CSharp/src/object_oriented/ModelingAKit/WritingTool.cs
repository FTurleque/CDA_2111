using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAKit
{
    abstract class WritingTool : ITool
    {
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        private int _writingCapacity;

        public int WritingCapacity
        {
            get { return _writingCapacity; }
        }

        public virtual void Write()
        {

        }
    }
}
