using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethod
{
    public class Person
    {
        public int Id { get; set; }
        public decimal Salary { get; set; }

        public Person(int id, decimal salary)
        {
            Id = id;
            Salary = salary;
        }

        public void ObjPass(Person obj1, Person obj2)
        {
            Console.WriteLine($"Id= {obj1.Id} and Name = {obj1.Salary}");
            Console.WriteLine($"Id= {obj2.Id} and Name = {obj2.Salary}");
        }
    }
}
