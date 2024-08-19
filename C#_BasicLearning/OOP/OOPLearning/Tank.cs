using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Tank
    {
        private double _radious {  get; set; }
        private double _height { get; set; }

        //public Tank(double r, double h)
        //{
        //    Radious = r;
        //    Height = h;
        //}
        public double Radious
        {
            get { return _radious; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("0 or negative radious is not accepted");
                }
                else
                {
                    _radious = value;
                }
            }
        }

        public double Height
        {
            get { return _height; }
            set 
            {   
                if (value <= 0)
                {
                    Console.WriteLine("0 or negative height is not accepted");
                } 
                else
                {
                    _height = value;
                }
            }
        }

        public void DisplayDimension()
        {
            Console.WriteLine($"The redious of tank is {Radious} and the height of the tank is {Height}");
        }
    }
}
