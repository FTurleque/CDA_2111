﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModelingKitVersion
{
    class ColoredPencil : Pencil
    {
        public ColoredPencil()
        {
            this.Color = "bleu";
            this.WritingCapacity = 100;
            this.PointOfMineToBeCut = true;
        }

        public ColoredPencil(string color)
        {
            this.Color = color;
            this.WritingCapacity = 100;
            this.PointOfMineToBeCut = true;
        }
    }
}