using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAKit
{
    abstract class Pencil : WritingTool
    {
        private bool _tipOfMineToCarve;

        public bool TipOfMineToCarve
        {
            get { return _tipOfMineToCarve; }
            set { _tipOfMineToCarve = value; }
        }

        public Pencil(string _color) : base(_color)
        {

        }

        public void Sharpen()
        {

        }

        public override void Write()
        {

        }
    }
}
