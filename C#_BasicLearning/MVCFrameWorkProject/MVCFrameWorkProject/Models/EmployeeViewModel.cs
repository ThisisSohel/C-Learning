using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFrameWorkProject.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Name can not be empty!")]
        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Age can not be empty")]
        public int EmployeeAge { get; set; }
    }
}