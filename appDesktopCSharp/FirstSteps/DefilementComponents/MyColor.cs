using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefilementComponents
{
    internal class MyColor
    {
        public Color NewColor { get; set; }

        public MyColor()
        {
            NewColor = Color.FromArgb(0, 0, 0);
        }

        public void ChangeColor(int red, int green, int blue)
        {
            if((red < 0 && green < 0 && blue < 0) || 
                (red > 255 && green > 255 && blue > 255))
            {
                throw new IndexOutOfRangeException("Une valeur ne peut pas ^tre négatif ou supperieur à 255.");
            }
            else
            {
                NewColor = Color.FromArgb(red, green, blue);
            }
        }
    }
}
