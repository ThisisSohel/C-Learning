using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface.cs
{
    public class FullTimeEmployee : BaseEmployee
    {
        public int AnnaulSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return AnnaulSalary / 12;
        }
    }
}
