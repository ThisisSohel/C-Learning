using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Shape
    {
        public virtual double Area()
        {
            Console.WriteLine("Shape");
            return 0;
        }
    }
}
