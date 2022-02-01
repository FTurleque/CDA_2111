using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONF
{
    class Parcel
    {
        private uint _id;
        private List<Tree> _trees;
        private List<GeoCoordinate.NetStandard2.GeoCoordinate> _coordinates;

        public Parcel(uint _id, List<GeoCoordinate.NetStandard2.GeoCoordinate> coordinates)
        {
            this.ParcelId = _id;
            this.Coordinates = coordinates;
            this.Trees = new List<Tree> { };
        }

        public List<GeoCoordinate.NetStandard2.GeoCoordinate> Coordinates
        {
            get => this._coordinates;
            set 
            {
                if (value.Count != 4)
                {
                    throw new ApplicationException("We need 4 GPS coordonates");
                }

                _coordinates = value;
            }
        }

        public uint ParcelId
        {
            get => this._id;
            set => this._id = value;
        }

        public List<Tree> Trees
        {
            get => this._trees;
            set => this._trees = value;
        }

        public int GetNumberTrees()
        {
            return this.Trees.Count;
        }

        public void PlantATree(Tree tree)
        {
            this.Trees.Add(tree);
        }

        /// <summary>
        /// Return surface of parcel from coordinates
        /// </summary>
        /// <returns>Surface of parcel in square kilometer</returns>
        public double GetSurface()
        {
            return Coordinates[0].GetDistanceTo(Coordinates[1]) * Coordinates[1].GetDistanceTo(Coordinates[2]) / 1000000;
        }
    }
}
