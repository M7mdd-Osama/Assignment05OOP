using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.First_Project
{
    public class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D() : this(0, 0, 0) { }
        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public int CompareTo(Point3D other)
        {
            if (other == null) return 1;

            int result = X.CompareTo(other.X);
            if (result == 0)
            {
                result = Y.CompareTo(other.Y);
            }
            return result;
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
