using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Employee : Person
    {
        public Employee() 
        {
            Name = "Hello";
            Console.WriteLine(Name);
        }

    }
}
