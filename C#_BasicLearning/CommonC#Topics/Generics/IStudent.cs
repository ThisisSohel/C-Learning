using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     interface IStudent <T>
    {
        T Add(T arg1, T arg2);
        T Subtract(T arg1, T arg2);
        T Multiplication(T arg1, T arg2);
        T Devide(T arg1, T arg2);
    }

    public class StudentCalculation<T> : IStudent<T>
    {
        public T Add(T arg1, T arg2)
        {
            return Add(arg1 , arg2);
        }

        public T Devide(T arg1, T arg2)
        {
            return Devide(arg1 + arg2);
        }

        public T Multiplication(T arg1, T arg2)
        {
            return Multiplication(arg1, arg2);
        }

        public T Subtract(T arg1, T arg2)
        {
            return Subtract(arg1, arg2);
        }
    }
}
