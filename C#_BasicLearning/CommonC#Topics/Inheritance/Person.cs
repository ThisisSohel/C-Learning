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

        protected string RefId;

        public virtual void FullInfo()
        {
            Console.WriteLine($"Id = {Id}");
            Console.WriteLine($"Name = {Name}");
        }
    }
}
