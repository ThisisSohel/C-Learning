using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class MathOperations<T> where T : INumber<T>
    {
        public T Add(T a, T b)
        {
            return a + b;
        }
    }
}
