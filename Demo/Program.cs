using Demo.Abstraction;
using Demo.Casting_Operator_Overloading;
using Demo.Operator_Overloading;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// +
            ///int Result = 10 + 20;
            ///string Name = "Mohamed" + "Osama";
            #region Operator Overloading
            Complex C1 = new Complex()
            {
                Real = 4,
                Imag = 2,
            };
            Console.WriteLine(C1);
            Complex C2 = new Complex()
            {
                Real = 44,
                Imag = 2,
            };
            //Console.WriteLine(C2);
            //Console.WriteLine("=====================");

            #region Binary
            //Complex C3 = C1 + C2;
            //Console.WriteLine(C3);

            //C3 += C1;
            //Console.WriteLine(C3); 
            #endregion

            #region Unary
            //C2 = ++C1;
            //Console.WriteLine(C2);
            //C2 = C1++;
            //Console.WriteLine(C2);
            //C2 = --C1;
            //Console.WriteLine(C2);
            #endregion

            #region Relational
            //if (C1 > C2)
            //    Console.WriteLine("C1 > C2");
            //else
            //    Console.WriteLine("C1 < C2");
            #endregion

            #endregion
            #region Casting Operators Overloading

            //object obj = 3;
            //int Y = (int)obj;

            //Complex C3 = new Complex() { Real = 5, Imag = 3 };
            //int Y = (int)C3;
            //Console.WriteLine(Y);

            //string X = C3;
            //Console.WriteLine(X);

            //User user = new User();

            //UserViewModel userViewModelodel = (UserViewModel)user;

            #endregion
            #region Abstraction
            //Circle circle = new Circle(4);
            //decimal circleArea = circle.CalcArea();
            //Console.WriteLine(circleArea); 
            #endregion


        }
    }
}