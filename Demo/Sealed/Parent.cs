using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    public class Parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }


        public virtual void Print()
        {
            Console.WriteLine("Parent");
        }
    }
    class Child : Parent
    {
        public sealed override int Salary
        {
            get => base.Salary;
            set => base.Salary = value < 5000 ? 5000 : value;
        }
        public sealed override void Print()
        {
            Console.WriteLine("Child");
        }
    }
    sealed class GrandChild : Child
    {
        //public new void Print()
        //{
        //    Console.WriteLine("Child");
        //}
    }
}
