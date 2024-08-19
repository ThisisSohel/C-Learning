using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Person<T>
    {
        public void Print (T data)
        {
            Console.WriteLine(data);
        }
        public void AddorUpdate(T data1, T data)
        {
            Console.WriteLine(data1 + " " + data);
        }
    }
}
