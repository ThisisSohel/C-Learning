using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface.cs
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public abstract int GetMonthlySalary();
    }
}
