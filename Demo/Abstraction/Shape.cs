using System;

namespace Demo.Abstraction
{
    internal abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        public Shape(decimal dim01, decimal dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }

        public abstract decimal CalcArea();
        public abstract decimal Perimeter { get; } // ReadOnly
    }

    abstract class RectBase : Shape
    {
        public RectBase(decimal dim01, decimal dim02) : base(dim01, dim02)
        {
        }

        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }

    class Rectangle : RectBase
    {
        public Rectangle(decimal dim01, decimal dim02) : base(dim01, dim02)
        {
        }

        public override decimal Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }
    }

    class Square : RectBase
    {
        public Square(decimal dim) : base(dim, dim)
        {
        }

        public override decimal Perimeter => Dim01 * 4;
    }

    class Circle : Shape
    {
        public Circle(decimal radius) : base(radius, radius)
        {
        }

        public override decimal Perimeter => 2 * 3.14M * Dim01;

        public override decimal CalcArea()
        {
            return 3.14M * Dim01 * Dim01;
        }
    }
}
