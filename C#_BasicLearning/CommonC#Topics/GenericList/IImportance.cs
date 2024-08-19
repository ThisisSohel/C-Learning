using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public interface IImportance<T>
    {
        T MostImportant(T a, T b);
    }
}
