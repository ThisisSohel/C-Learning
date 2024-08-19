using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class ButterList<T>
    {
        private List<T> list = new List<T>();

        public void AddToList(T item)
        {
            list.Add(item);
            Console.WriteLine($"{item} is added to the list");
        }


    }
}
