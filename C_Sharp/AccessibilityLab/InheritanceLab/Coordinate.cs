using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class Coordinate
    {
        double _x;
        double _y;

        public static readonly Coordinate Origin = new Coordinate(0, 0);


        public Coordinate(double x, double y)
        {
            this._x = x;
            this._y = y;
        }

        public double X => _x;
        public double Y => _y;

        public double DistanceTo(Coordinate other)
        {
            //c^2 = a^2 + b^2

            double xDist = this._x - other._x;
            double yDist = this._y - other._y;

            double xDistSquared = xDist * xDist;
            double yDistSquared = yDist * yDist;

            double distSquared = xDistSquared + yDistSquared;
            double distance = Math.Sqrt(distSquared);
            return distance;
        }

        public double DistanceFromOrigin()
        {
            return DistanceTo(Origin);
        }

        public static double DistanceBetween(Coordinate first, Coordinate second)
        {
            //c^2 = a^2 + b^2

            double xDist = first._x - second._x;
            double yDist = first._y - second._y;

            double xDistSquared = xDist * xDist;
            double yDistSquared = yDist * yDist;

            double distSquared = xDistSquared + yDistSquared;
            double distance = Math.Sqrt(distSquared);
            return distance;
        }

    }
}
