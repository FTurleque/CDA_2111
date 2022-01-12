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
            /*protected set { _writingCapacity = value; }*/
        }

        private int _lengthOfMineTip;

        public int LengthOfMineTip
        {
            get { return _lengthOfMineTip; }
            init { _writingCapacity = 10; }
        }

        public WritingTool(string _color, int _writingCapacity)
        {
            Color = _color;
            WritingCapacity = _writingCapacity;
        }

        public void Use()
        {
            Write();
        }

        private void Write()
        {
            /*if (_lengthOfMineTip == 0)
            {
                Pencil.Sharpen();
                WritingCapacity--;
            }
            _lengthOfMineTip--;*/
        }

        /*public abstract void Write();*/
    }
}
