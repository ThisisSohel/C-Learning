using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.cs
{
    public abstract class Person
    {
        public abstract void Print();
    }
    public interface IPerson 
    {
        public string Name { get; set; }
        public void Print()
        {
            Console.WriteLine("Hello from interface");
        }

    }
}
