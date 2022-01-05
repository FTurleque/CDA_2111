using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Point3D : Point2D
    {
        private double _z;

        public double Z
        {
            get { return _z; }
            set { _z = value; }
        }
        public Point3D() : base()
        {
            Z = 0;
        }

        public Point3D(double x, double y, double z) : base(x,y)
        {
            Z = z;
        }
    }
}
