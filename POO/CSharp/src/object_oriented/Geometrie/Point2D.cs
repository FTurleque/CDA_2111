using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Point2D
    {
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// <summary>
        /// Default constructor 
        /// </summary>
        public Point2D()
        {
            X = 0;
            Y = 0;
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return ($"({X}, {Y})");
        }

        public void DeplacerVersPosition(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void DeplacerDe(int nombreADeplacerX = 0, int nombreADeplacerY = 0)
        {
            X = X + nombreADeplacerX;
            Y = Y + nombreADeplacerY;
        }

    }
}
