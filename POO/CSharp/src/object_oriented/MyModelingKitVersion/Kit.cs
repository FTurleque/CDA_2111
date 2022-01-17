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
        private int _volume;
        private string _color;
        
        public Kit(string color, int volume)
        {
            _color = color;
            _volume = volume;
            IsOpen = false;
        }


        public string Color
        {
            get { return _color; }
            init { _color = value; }
        }


        public int Volume
        {
            get { return _volume; }
            init { _volume = value; }
        }

        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }


        public void Open()
        {
            if (IsOpen == false)
            {
                IsOpen = true;
            }
        }

        public void Close()
        {
            if (IsOpen == true)
            {
                IsOpen = false;
            }
        }
    }
}
