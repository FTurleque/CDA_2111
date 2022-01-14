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
        private double _length;
        private string _color;
        //private bool _isNotEmpty = false;

        public Kit(string color, double length, int volume)
        {
            _color = color;
            _length = length;
            _volume = volume;
        }


        public string Color
        {
            get { return _color; }
            init { _color = value; }
        }


        public double Length
        {
            get { return _length; }
            init { _length = value; }
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


        public bool Open()
        {
            return _isOpen;
        }

        public bool Close()
        {
            return _isOpen;
        }
    }
}
