using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface.cs
{
    public  class PartTimeEmployee : BaseEmployee
    {

        public int AnnaulSalary { get; set; }
        public int TotalHoursWorked { get; set; }
        public int HourlyPay {  get; set; }
        public override int GetMonthlySalary()
        {
            return HourlyPay * TotalHoursWorked;
        }
    }
}
