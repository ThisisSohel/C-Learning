using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Offline Student");
        }
    }
}
