using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    class Segment2D
    {
        private Point2D _p1;
        private Point2D _p2;

        public Segment2D()
        {
            P1 = new Point2D(0, 0);
            P2 = new Point2D(1, 1);
        }

        public Segment2D(Point2D p1, Point2D p2) 
        {
            P1 = p1;
            P2 = p2;
        }

        public Point2D P1
        {
            get { return _p1; }
            set { _p1 = value; }
        }

        public Point2D P2
        {
            get { return _p2; }
            set { _p2 = value; }
        }

        public Segment2D(int p1X, int p1Y, int p2X, int p2Y)
        {
            P1 = new Point2D(p1X, p1Y);
            P2 = new Point2D(p2X, p2Y);
        }

        public void DeplacerVersPosition(int x, int y)
        {
            int deplacementX = CalculDuDeplacement(P1.X, x);
            int deplacementY = CalculDuDeplacement(P1.Y, y);

            P1.DeplacerVersPosition(x, y);

            P2.DeplacerDe(deplacementX, deplacementY);
        }

        private int CalculDuDeplacement(int origine, int destination)
        {
            return destination - origine;
        }

        public void DeplacerDe(int nombreADeplacerX, int nombreADeplacerY)
        {
            P1.DeplacerDe(nombreADeplacerX, nombreADeplacerY);
            P2.DeplacerDe(nombreADeplacerX, nombreADeplacerY);
        }


        public override string ToString()
        {
            return ($"[P1{P1} ; P2{P2}]");
        }

    }
}
