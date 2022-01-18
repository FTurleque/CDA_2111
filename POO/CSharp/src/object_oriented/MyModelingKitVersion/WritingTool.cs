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
        private int _writingCapacity;
        
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

        protected void Write()
        {
            if (schoolKit.IsOpen)
            {
                if (this.WritingCapacity > 0)
                {
                    Console.WriteLine($"J'écris du texte de couleur {Color}");
                }
                else
                {
                    Console.WriteLine("!!! Capacité d'écriture épuisée !!!");
                }
            }
            else
            {
                Console.WriteLine("La trousse n'est pas ouverte, vous ne pouvez pas écrire.");
            }
            
        }

        public abstract void Use();
        
    }
}
