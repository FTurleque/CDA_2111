using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    abstract class WritingTool : ITool
    {
        private string _color;
        private int _writingCapacity;
        private SchoolKit _schoolKitOfPen;

        public SchoolKit SchoolKitOfPen
        {
            get { return _schoolKitOfPen; }
            set { _schoolKitOfPen = value; }
        }

        public string Color
        {
            get { return _color; }
            protected set { _color = value; }
        }

        public int WritingCapacity
        {
            get { return _writingCapacity; }
            protected set { _writingCapacity = value; }
        }

        protected string Write()
        {
            if (this.WritingCapacity > 0)
            {
                return $"I write {Color} text.";
            }
            else
            {
                return "!!! Writing capacity exhausted !!!";
            }
            
        }

        public abstract void Use();
        
    }
}
