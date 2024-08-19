using RoutingPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingPractice.Controllers
{
    [RoutePrefix("students")] //using prefix routing to prevent the writing of "students" repeatedly!
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "Rakib"
            },
            new Student()
            {
                Id = 2,
                Name = "Sakib"
            },
            new Student()
            {
                Id = 3,
                Name = "Rahim"
            }
        };

        [HttpGet]
        [Route]
        public ActionResult GetAllStudents()
        {
            return View(students);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult StudentGetById(int id)
        {
            Student studentDetails = students.FirstOrDefault(x => x.Id == id);
            return View(studentDetails);
        }

        [HttpGet]
        [Route("{id}/courses")]  //Attribute routing....
        public ActionResult GetStudentCourse(int id)
        {
            List<string> courseList = new List<string>();

            if (id == 1)
                courseList = new List<string>() { "CSE110", "CSE121", "CSE210" };
            else if (id == 2)
                courseList = new List<string>() { "CSE110", "CSE310", "CSE213" };
            else
                courseList = new List<string>() { "CSE210", "CSE310", "CSE210" };

            ViewBag.courseList = courseList;
            return View();
        }

        [Route("Option/{name = S1}")]
        public ActionResult AttributeOptionalParam(string name)
        {
            ViewBag.Message = "Optional Name!";
            return View();
        }

        [Route("~/teach/teachers")]
        public ActionResult GetTeacher()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher() { Id = 1, Name = "Tamim" },
                new Teacher() { Id = 2, Name = "Ahsan" },
                new Teacher() { Id = 3, Name = "Muhit" }
            };

            return View(teachers);
        }
    }
}