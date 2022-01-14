using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    abstract class WritingTool
    {
        private string _color;
        private const int _char_number_to_decrease = 15;
        
        public WritingTool(string color)
        {
            _color = color;
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int CharNumber
        {
            get { return _char_number_to_decrease; }
        }

        public abstract void Write(char letter);

        public abstract void Use(string txt);
        
    }
}
