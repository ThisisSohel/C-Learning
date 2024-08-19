using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFrameWorkProject.Models
{
    public class EmployeeMapping: ClassMap<Employee>
    {
        public EmployeeMapping()
        {
            Table("EmployeeStatus");
            Id(x => x.EmployeeId).GeneratedBy.Identity();
            Map(x => x.EmployeeName);
            Map(x => x.EmployeeAge);
        }
    }
}