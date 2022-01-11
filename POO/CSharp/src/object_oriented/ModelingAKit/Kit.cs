using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelingAKit
{
    abstract class Kit
    {
        private int _volume;

        public int Volume
        {
            get { return _volume; }
            private set { _volume = value; }
        }

        private bool _isOpen;

        public bool IsOpen
        {
            get { return _isOpen; }
            private set { _isOpen = value; }
        }

        public Kit(int volume)
        {
            Volume = volume;
        }

        public void Open()
        {

        }

        public void Closed()
        {

        }
    }
}
