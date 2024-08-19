using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFrameWorkProject.Models
{
    public class Employee
    {
        public virtual int EmployeeId { get; set; }
        public virtual string EmployeeName { get; set; }
        public virtual int EmployeeAge { get; set; }
    }
}