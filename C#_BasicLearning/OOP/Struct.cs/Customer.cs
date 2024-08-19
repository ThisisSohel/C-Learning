using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.cs
{
    public struct Customer
    {
        private int _id;
        private string _name;

        public int Id 
        { get { return _id; } 
          set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Customer(int Id, string Name) 
        { 
            _id = Id;
            _name = Name;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} Name = {1}", Id, Name);
        }
    }
}
