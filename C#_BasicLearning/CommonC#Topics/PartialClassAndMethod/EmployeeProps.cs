using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassAndMethod
{
    public class EmployeeProps
    {
        public partial class Employee 
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

    }
}
