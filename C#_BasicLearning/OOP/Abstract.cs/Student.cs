using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.cs
{
    public class Student 
    {
       public string Name { get; set; }
        public string Address { get; set; }
        public List<Course> Courses { get; set; }

        public Student(string name, string address) 
        {
            Name = name;
            Address = address;
            Courses = new List<Course>();
        }

        public void EnrollCourse(Course course)
        {
            Courses.Add(course);
        }
    }
}
