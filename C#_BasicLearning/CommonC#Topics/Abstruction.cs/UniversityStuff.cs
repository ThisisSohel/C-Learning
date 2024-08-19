using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruction.cs
{
    public class UniversityStuff : UniversityBase
    {
        public decimal Salary;
        public int HourlyPay;
        public override void EmplyeeSalary()
        {
            Console.WriteLine(" Employee Salary : " + (Salary * HourlyPay));
        }
        public override void CourseFee()
        {
            Console.WriteLine(" Employee Copurse Fee : " + (Salary * HourlyPay + 200));
        }
    }
}
