using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public class DataStore<T>
    {
        public T Data { get; set; }
        public DataStore(T data) 
        {
            Data = data;
        }

        public void Display(T data)
        {
            Console.WriteLine("The generic data is: " + data);
        }

        public T ReturnDisplay(T data)
        {
            return data;
        }
    }

    public class MultiDataStore<T, Y>
    {
        public T Value { get; set; }
        public Y Value1 { get; set; }
    }
}
