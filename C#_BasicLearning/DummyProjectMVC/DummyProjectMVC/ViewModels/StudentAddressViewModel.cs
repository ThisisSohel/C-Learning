using DummyProjectMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DummyProjectMVC.ViewModels
{
    public class StudentAddressViewModel
    {
        public Student Student { get; set; }
        public Address Address { get; set; }

        public string StudentStatus { get; set; }
    }
}