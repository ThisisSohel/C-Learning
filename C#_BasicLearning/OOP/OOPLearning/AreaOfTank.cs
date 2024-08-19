using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class AreaOfTank : Tank
    {
        public string Color { get; set; }

        public AreaOfTank(double r, double h, string c) 
        {
            Radious = r;
            Color = c;
            Height = h;
        }

        public double Area()
        {
            return 2 * 3.14 * Radious * Height;
        }

        public void DisplayColor()
        {
            Console.WriteLine("Color - " + Color);
        }
    }
}
