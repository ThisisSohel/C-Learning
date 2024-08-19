using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            Console.WriteLine("Online Course " + " " + Title + " " + std.FName + " " + std.LName);
        }
    }
}
