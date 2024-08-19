using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface.cs
{
    public abstract class PersonBase
    {
        int id;
        protected string name;

        public  int Id
        {
            get => id;
        }

        public string Name
        {
            get => name;
        }

        public void Info1()
        {
            Console.WriteLine();
        }
        //public abstract string Name { get; }
        public abstract void Info();
    }
}
