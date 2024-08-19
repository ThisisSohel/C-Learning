using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortedList;

namespace OutSideClass
{
    internal class ExPerson : Person
    {
        public void Method()
        {
            Id = 1;
            Console.WriteLine(Id);
        }
    }
}
