using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_Overloading
{
    internal class Complex
    {
        public int? Real { get; set; }
        public int? Imag { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static Complex operator +(Complex left, Complex Right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (Right?.Imag ?? 0)
            };
        }
        public static Complex operator -(Complex left, Complex Right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };
        }
        public static Complex operator ++(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = C?.Imag ?? 0
            };
        }
        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = C?.Imag ?? 0
            };
        }
        public static bool operator >(Complex left, Complex Right)
        {
            if (left.Real == Right.Real)
                return left.Imag > Right.Imag;
            else
                return left.Real > Right.Real;
        }

        public static bool operator <(Complex left, Complex Right)
        {
            if (left.Real == Right.Real)
                return left.Imag < Right.Imag;
            else
                return left.Real < Right.Real;
        }
        public static explicit operator int(Complex C)
        {
            return C?.Real?? 0;
        }
        public static implicit operator string(Complex C)
        {
            return C?.ToString()?? string.Empty;
        }
    }
}


