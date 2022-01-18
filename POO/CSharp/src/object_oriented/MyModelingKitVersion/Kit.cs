using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    abstract class Kit
    {
        private bool _isOpen;
        private int _maxToolsNumber;
        
        public Kit(int maxToolsNumber)
        {
            this.MaxToolsNumber = maxToolsNumber;
            this.IsOpen = false;
        }

        public int MaxToolsNumber
        {
            get { return _maxToolsNumber; }
            init { _maxToolsNumber = value; }
        }

        public bool IsOpen
        {
            get { return _isOpen; }
            private set { _isOpen = value; }
        }


        public void Open()
        {
            if (!this.IsOpen)
            {
                IsOpen = true;
            }
        }

        public void Close()
        {
            if (this.IsOpen)
            {
                IsOpen = false;
            }
        }
    }
}
