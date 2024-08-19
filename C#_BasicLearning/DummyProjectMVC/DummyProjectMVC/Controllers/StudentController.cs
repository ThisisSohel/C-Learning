using DummyProjectMVC.Models;
using DummyProjectMVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DummyProjectMVC.Controllers
{
    public class StudentController : Controller
    {

        static List<Student> students = new List<Student>
        {
            new Student(){StudentId = 1, StudentName = "Sohel", Age = 24},
            new Student(){StudentId = 2, StudentName = "Sohan", Age = 25},
            new Student(){StudentId = 3, StudentName = "Sakib", Age = 23},
            new Student(){StudentId = 4, StudentName = "Sakib Hasan", Age = 24}
        };

        static List<Address> addresses = new List<Address>
        {
            new Address() {AddressID = 100, City = "Dhaka"},
            new Address() {AddressID = 101, City = "Khulna"},
            new Address() {AddressID = 102, City = "Rajshahi"},
        };

        public ViewResult Details()
        {
            Student student = new Student()
            {
                StudentId = 111,
                StudentName = "Joe",
                Age = 24
            };

            Address address = new Address()
            {
                AddressID = 100,
                City = "Dhaka"
            };

            StudentAddressViewModel studentAddressViewModel = new StudentAddressViewModel()
            {
                Student = student,
                Address = address,
                StudentStatus = "Running"
            };
            return View(studentAddressViewModel);
        }
        public ActionResult Index()
        {
            return View(students);
        }

        [Route("Student/{id}")]
        public ActionResult StudentInfo(int studentId)
        {
            ViewBag.StudentId = studentId;
            return View();
        }
    }
}