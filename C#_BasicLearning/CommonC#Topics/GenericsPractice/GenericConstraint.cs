using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public class GenericConstraint <T> where T : class //Only reference type can be passed as an argument.
    {
        public T Value { get; set; }
    }

    public class DataTypeClass <T> where T : struct
    {
        public T Value { get; set; }
    }

    public class CollectionClass<T> where T : IEnumerable
    {
        public T Data { get; set; }
    }


    public class X<T> where T : IEnumerable
    {
        public T Value { get; set; }
    }
    
}
