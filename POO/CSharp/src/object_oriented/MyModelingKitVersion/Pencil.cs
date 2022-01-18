using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    abstract class Pencil : WritingTool
    {
        private bool _pointOfMineToBeCut;

        public bool PointOfMineToBeCut
        {
            get { return _pointOfMineToBeCut; }
            set { _pointOfMineToBeCut = value; }
        }

        public void Trim()
        {
            if(WritingCapacity > 3)
            {
                WritingCapacity -= 3;
                PointOfMineToBeCut = true;
            }
            else
            {
                WritingCapacity = -1;
            }
        }

        public override void Use()
        {
            int rndMinePlusTaillee = new Random().Next(0, 3);

            if (!this.PointOfMineToBeCut)
            {
                this.Trim();
            }
            base.Write();

            if (rndMinePlusTaillee == 0)
            {
                this.PointOfMineToBeCut = false;
            }
        }
    }
}
