using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ExStudent : Student
    {
        public int PassingYear { get; set; }

        public new void FullInfo()
        {
            base.FullInfo();
            Console.WriteLine($"Passing Year = {PassingYear}");
        }
    }
}
