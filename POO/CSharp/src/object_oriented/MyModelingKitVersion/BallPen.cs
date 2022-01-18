using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    class BallPen : WritingTool
    {
        public BallPen()
        {
            this.Color = "rouge";
            this.WritingCapacity = 100;
        }

        public BallPen(string color)
        {
            this.Color = color;
            this.WritingCapacity = 100;
        }
        public override void Use()
        {
            this.Write();
            this.WritingCapacity--;
        }
    }
}
