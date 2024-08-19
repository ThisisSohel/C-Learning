using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Person
    {
        public int StuId { get; set; }

        public override void FullInfo()
        {
            base.FullInfo();
            Console.WriteLine($"StudentId = {StuId}");
        }

        public string Ref
        {
            get { return RefId; }
            set { RefId = "student-" + value; }
        }

    }
}
