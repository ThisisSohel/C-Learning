using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassAndMethod
{
    public class EmployeeMethods
    {
        public partial class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public partial class Employee
        {
            public Employee(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public void DisplayEmpInfo()
            {
                Console.WriteLine(Id + " " + Name);
            }
        }
    }
}
