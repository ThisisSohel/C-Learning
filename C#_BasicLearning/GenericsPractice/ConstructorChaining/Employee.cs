using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    public class Employee : Manager
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public Employee()
            : base(110, "EmpName") { }

        public Employee(int empId, string name, int age)
        {
            EmpId = empId;
            EmpName = name;
            Age = age; 
        }

        public void EmpInfo(int age)
        {
            Age = age;
        }
    }
}
