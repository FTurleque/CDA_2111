using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    abstract class Pencil : WritingTool
    {
        private bool _pointOfMineAlreadyCut;

        public bool PointOfMineAlreadyCut
        {
            get { return _pointOfMineAlreadyCut; }
            set { _pointOfMineAlreadyCut = value; }
        }

        public void Trim()
        {
            if(WritingCapacity > 3)
            {
                WritingCapacity -= 3;
                PointOfMineAlreadyCut = true;
            }
            else
            {
                WritingCapacity = -1;
            }
        }

        public override void Use()
        {
            int rndPointOfMineToBeCut = new Random().Next(0, 3);

            if (!this.PointOfMineAlreadyCut)
            {
                this.Trim();
            }
            Console.WriteLine(base.Write());

            if (rndPointOfMineToBeCut == 0)
            {
                this.PointOfMineAlreadyCut = false;
            }
        }
    }
}
