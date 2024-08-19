using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringImplement
{
    public class Person
    {
        public static int s_Number {  get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Person: " + Name + " " + Age;
        }
    }
}
