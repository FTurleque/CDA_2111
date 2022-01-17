using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    abstract class Pencil : WritingTool
    {
        private int _pencil_lead_length;
        private int _pencil_heigth;
        private int _decrease_of_the_mine = 0;
        private int _trim_number = 0;
        

        public Pencil(string color, int pencil_lead_length, int pencil_heigth) : base(color)
        {
            _pencil_lead_length = pencil_lead_length;
            _pencil_heigth = pencil_heigth;
        }

        public int TrimNumber
        {
            get { return _trim_number; }
        }

        public int PencilHeigth
        {
            get { return _pencil_heigth; }
            set { _pencil_heigth = value; }
        }


        public int PencilLeadLength
        {
            get { return _pencil_lead_length; }
            set { _pencil_lead_length = value; }
        }

        public void Trim()
        {
            PencilHeigth--;
            _trim_number++;
            PencilLeadLength = _decrease_of_the_mine;
            _decrease_of_the_mine = 0;
        }

    }
}
