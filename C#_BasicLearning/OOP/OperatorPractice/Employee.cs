using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorPractice
{

    public interface ICalculate<T>
    {
        T CalMethod (T a , T b );
    }

    public class CalculatorClass : ICalculate<int>, ICalculate<string>
    {
        public int CalMethod (int a , int b)
        {
            return a ;
        }

        public string CalMethod(string a, string b)
        {
            return b ;
        }
    }
    public class Employee<T>
    {
        public T Data { get; set; }
    }

    public class Employee1<K, D>
    {
        public K Key { get; set; }
        public D Value { get; set; }
    }
}
