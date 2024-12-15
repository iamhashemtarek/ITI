using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    public class Point3D : IComparable<Point3D>, IDisposable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"(x: {X}, y: {Y}, z: {Z})";
        }

        public override bool Equals(object obj)
        {
            //Point3D p = (Point3D)obj;
            //return (X == p.X && Y == p.Y && Z == p.Z);
            try
            {
                if (obj is Point3D p)
                    return (X == p.X && Y == p.Y && Z == p.Z);

                throw new Exception("you passed invalid input");
            }
            catch (Exception ex)
            {
                {
                    Utility.LogError(ex);
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

        }

        public void Dispose()
        {
            Console.WriteLine("Releasing unmanaged resources.");
        }

        public int CompareTo(Point3D? other)
        {
            if (other == null)
                throw new Exception("The other to compare cannot be null.");


            if (X == other.X)
                return Y.CompareTo(other.Y);

            return X.CompareTo(other.X);
        }
    }
}
