using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.cs
{
    public interface IShape
    {
        public double CalculateArea();
    }
    public interface VShape
    {
        public double CalculateVArea();
    }

    public class Circle : IShape, VShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double CalculateVArea()
        {
            return Radius * Math.Pow(Radius, (int)Math.Ceiling(Radius / 2));
        }
    }
}
