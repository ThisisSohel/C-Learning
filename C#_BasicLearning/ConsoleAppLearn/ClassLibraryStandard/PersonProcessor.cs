using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryStandard
{
    public class PersonProcessor
    {
        public static string JoinName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        public virtual void HelloMethod()
        {
            Console.WriteLine("Hello from person processor!");
        }
    }
}
