using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.cs
{
    public class Course
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; }

        public Course(string courseName, string description, Teacher teacher)
        {
            CourseName = courseName;
            Description = description;
            Teacher = teacher;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
