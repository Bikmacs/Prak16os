using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak15
{
    internal class Plus
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public Plus(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Plus operator +(Plus c1, Plus c2)
        {
            return new Plus(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static Plus operator -(Plus c1, Plus c2)
        {
            return new Plus(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public static Plus operator *(Plus c1, Plus c2)
        {
            double realPart = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double imaginaryPart = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new Plus(realPart, imaginaryPart);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}

