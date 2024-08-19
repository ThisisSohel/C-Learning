using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction.cs
{
    public abstract class StudentBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string UniInfo()
        {
            return Id + " " + Name + " " + Address ;
        }

        public abstract decimal CourseFee();
    }
}
