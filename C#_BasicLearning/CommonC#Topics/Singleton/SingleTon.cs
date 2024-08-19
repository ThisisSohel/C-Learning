using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingleTon
    {
        public static SingleTon instance = null;
        private SingleTon(string a) { Console.WriteLine(a); } //Private Constructor.....

        public static SingleTon Instance()
        {
            if (instance == null)
            {
                instance = new SingleTon("a");
            }
            return instance;

        }
    }
}
