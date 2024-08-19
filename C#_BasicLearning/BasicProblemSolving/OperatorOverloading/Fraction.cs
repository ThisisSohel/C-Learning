using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Fraction
    {
        private readonly int Num;
        private readonly int Den;

        public Fraction(int num, int den)
        {
            if(den == 0)
            {
                Console.WriteLine("Denominator can not be 0");
            }
            Num = num;
            Den = den;
        }

        public static Fraction operator + (Fraction a)
        {
            return a;
        }

        public static Fraction operator -(Fraction a)
        {
            return new Fraction (-a.Num, a.Den);
        }

    }
}
