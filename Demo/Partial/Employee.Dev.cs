using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    public partial class Employee
    {
        public void Print()
        {
            Console.WriteLine("safsdg");
        }
        public partial void Test()
        {
            Console.WriteLine("wfsf");
        }
    }
}
