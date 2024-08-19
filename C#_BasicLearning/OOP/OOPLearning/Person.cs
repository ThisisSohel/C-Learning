using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private protected string Email { get; set; }

        public void InfoDetails()
        {
            Console.WriteLine($"Id {Id} Name {Name} and email is {Email}");
        }

    }
}
