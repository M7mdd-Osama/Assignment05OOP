using Assignment.First_Project;
using Assignment.Second_Project;
using Assignment.Third_Project;

namespace Assignment
{
    internal class Program
    {
        public static int ReadCoordinate(string coordinateName)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
        public static Point3D ReadPoint(string pointName)
        {
            Console.WriteLine($"Enter coordinates :");
            int x = ReadCoordinate("X");
            int y = ReadCoordinate("Y");
            int z = ReadCoordinate("Z");
            return new Point3D(x, y, z);
        }
        static void Main()
        {

            #region First Project
            #region 2
            //Point3D P = new (10,10,10);
            //Console.WriteLine(P.ToString());
            #endregion

            #region 3
            //Point3D P1 = ReadPoint("P1");
            //Point3D P2 = ReadPoint("P2");

            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P2.ToString()); 
            #endregion

            #region 4
            //Point3D P1 = new Point3D(2,7,6);
            //Point3D P2 = new Point3D(2,7,6);
            //if (P1 == P2)
            //    Console.WriteLine("P1 == P2");
            //else
            //    Console.WriteLine("P1 != P2");

            //it does not Work 
            #endregion

            #region 5
            //Point3D[] points = {
            //new Point3D(3, 4, 5),
            //new Point3D(3, 2, 3),
            //new Point3D(5, 6, 7),
            //new Point3D(2, 3, 4)
            //};
            //Array.Sort(points, (a, b) =>
            //{
            //    int result = a.X.CompareTo(b.X);
            //    if (result == 0)
            //    {
            //        result = a.Y.CompareTo(b.Y);
            //    }
            //    return result;
            //});
            //Console.WriteLine("Sorted Points:");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //} 
            #endregion

            #region 6
            //Point3D p1 = new Point3D(3, 4, 5);
            //Console.WriteLine("Original Point: " + p1);

            //Point3D p2 = (Point3D)p1.Clone();
            //Console.WriteLine("Cloned Point: " + p2); 
            #endregion

            #endregion

            #region Second Project
            //Maths.X = 4;
            //Maths.Y = 2;
            //Console.WriteLine(Maths.Add());
            //Console.WriteLine(Maths.Subtract());
            //Console.WriteLine(Maths.Multiply());
            //Console.WriteLine(Maths.Divide()); 
            #endregion

            #region Third Project
            #region 3
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());
            #endregion

            #region 4
            //D3 = D1 + D2;
            //Console.WriteLine(D3.ToString());

            //D3 = D1 + 7800;
            //Console.WriteLine(D3.ToString());

            //D3 = 666 + D3;
            //Console.WriteLine(D3.ToString());

            //D3 = ++D1;
            //Console.WriteLine(D3.ToString());

            //D3 = --D2;
            //Console.WriteLine(D3.ToString());

            //D1 = D1 - D2;
            //Console.WriteLine(D1.ToString());

            //Console.WriteLine(D1 > D2);
            //Console.WriteLine(D1 <= D2);

            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj.ToString("HH:mm:ss"));
            #endregion 
            #endregion
        }
    }
}
