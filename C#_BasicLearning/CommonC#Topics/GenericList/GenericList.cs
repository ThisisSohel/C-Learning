using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T> : List<T>
    {
        public GenericList(T data) 
        { 

        }

    }

    public class DataStore<T> where T : class, new()
    {

    }
}
