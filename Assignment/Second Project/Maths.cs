using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Second_Project
{
    internal static class Maths
    {
        public static int X { get; set; }
        public static int Y { get; set; }
        public static int Add()
        {
            return X + Y;
        }
        public static int Subtract()
        {
            return X - Y;
        }
        public static int Multiply()
        {
            return X * Y;
        }
        public static int Divide()
        {
            return X / Y;
        }
    }
}
