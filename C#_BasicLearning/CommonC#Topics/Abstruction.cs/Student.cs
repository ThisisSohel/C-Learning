using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction.cs
{
    public class Student : StudentBase
    {
        public decimal CFee { get; set; }

        public override decimal CourseFee()
        {
            return CFee + 10; 
        }
    }
}
