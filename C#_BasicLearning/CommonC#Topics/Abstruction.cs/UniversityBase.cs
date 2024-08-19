using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Abstruction.cs
{
    public abstract class UniversityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        
        public void BasicInfoOfEmpployee(int id, string name, string address)
        {
            Console.WriteLine(Id + " " + Name + " " + Address);
        }
        public abstract void CourseFee();
        public abstract void EmplyeeSalary();
    }
}
