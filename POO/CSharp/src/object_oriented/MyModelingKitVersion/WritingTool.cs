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

        public void Write(string txt)
        {
            string[] word = txt.Split(" ");
            
            for (int i = 0; i < word.Length; i++)
            {
                if (_pencil_lead_length == 0)
                {
                    Trim();
                }
                else if (PencilHeigth != 0)
                {
                    Write(tmp[i]);
                }
                else
                {
                    Console.WriteLine("Vous ne pouvez plus écrire, changer de crayon.");
                }

            }
            PencilLeadLength--;
            _decrease_of_the_mine++;

        }

        public void Use(string txt)
        {
            Write(txt);
        }
        
    }
}
