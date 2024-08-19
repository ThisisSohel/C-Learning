using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    public class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Manager()
            : this(1, "s1")
        {
            Console.WriteLine("Default ctor!");
        }

        public Manager(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Manager(int id, string name, int age)
        {
            Id = id;
            Name = name;
            age = 20;
        }

        public void ManagerInfo()
        {
            Console.WriteLine(Id + " - " + Name);
        }
    }
}
