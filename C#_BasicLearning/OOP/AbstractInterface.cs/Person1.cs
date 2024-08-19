using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface.cs
{
    public class Person1 : PersonBase
    {
        public override int Id
        {
           
        }
        public override string Name 
        {
            get { return Name; }
            set {  Name = value; }
        }

        public override void Info()
        {
            Console.WriteLine($"Id = {Id} and Name = {Name}");
        }
    }
}
