using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    class NibPen : WritingTool
    {
        /*public NibPen()
        {
            this.Color = "Green";
            this.WritingCapacity = 100;
        }*/

        public NibPen(string color)
        {
            this.Color = color;
            this.WritingCapacity = 100;
        }

        public void ChangeCartridge(string color)
        {
            this.Color = color;
            this.WritingCapacity = 100;
        }

        public override void Use()
        {
            this.WritingCapacity -= 2;
            Console.WriteLine(this.Write());
        }
    }
}
