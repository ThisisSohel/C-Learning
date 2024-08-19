using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public class Person <TId, TName> where TId : class, INumber<TId>
    {
        public TId Id { get; set; }
        public TName Name { get; set; }


        public Person(TId id, TName name)
        {
            Id = id;
            Name = name;
        }

        public Person (TId id)
        {
            Id = id;
        }

    }
}
