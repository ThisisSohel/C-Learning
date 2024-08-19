using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.cs
{
    interface IPoint
    {
        int X { get; set; }

        int Y { get; set; }

        double Distance { get; }
    }

    class Point : IPoint
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public double Distance =>
           Math.Sqrt(X * X + Y * Y);
    }
}
