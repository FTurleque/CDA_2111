using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAKit
{
    abstract class Pencil : WritingTool
    {
        private bool _tipOfLeadToCarve;
        

        public bool TipOfMineToCarve
        {
            get { return _tipOfLeadToCarve; }
            private set { _tipOfLeadToCarve = value; }
        }

        public Pencil(string _color, int _writingCapacity) : base(_color, _writingCapacity)
        {

        }
        private void Write()
        {

        }

        public void Sharpen()
        {
            
        }

    }
}
