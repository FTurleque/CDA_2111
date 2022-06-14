using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxAndComboBox
{
    internal class ListManager
    {
        public BindingList<string> Source { get; set; }
        public BindingList<string> Target { get; set; }

        public ListManager() { }

        public void ReverseList()
        {
            BindingList<string> tmp = Source;
            Source = Target;
            Target = tmp;
        }

        public void ReverseMouveOne(int index)
        {
            ReverseList();
            MoveOne(index);
            ReverseList();
        }

        public void MoveOne(int index)
        {
            if(index < 0 || index >= Source.Count)
            {
                throw new ArgumentOutOfRangeException("Index hors limites.");
            }
            Target.Add(Source[index]);
            Source.RemoveAt(index);
        }

        public void MoveAll()
        {
            while(Source.Count > 0)
            {
                Target.Add(Source[0]);
                Source.RemoveAt(0);
            }
        }

        public void Move(int index, int indexToMove)
        {
            var tmp = Target[indexToMove];
            Target[indexToMove] = Target[index];
            Target[index] = tmp;
        }
    }
}
