using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int Experience { get; set; }


        public void EmployeeList (List<Employee> list)
        {
            foreach (Employee e in list)
            {
                if (e.Experience >= 5)
                {
                    Console.WriteLine(e.Name + "Promoted!");
                }
            }
        }

    }
}
