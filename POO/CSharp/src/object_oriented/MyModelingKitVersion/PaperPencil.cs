using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    class PaperPencil : Pencil
    {
        public PaperPencil()
        {
            this.WritingCapacity = 100;
            this.Color = "Grey";
            this.PointOfMineAlreadyCut = true;
        }

    }
}
