using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public void Save()
        {
            Console.WriteLine("Save student");
        }

        public void Delete()
        {
            Console.WriteLine("Save student");
        }

        public void ListStudent()
        {
            Console.WriteLine("Student List");
        }

        public IList<Course> Subscribe(Course cs)
        {
            Console.WriteLine("Start Subscribe");

            //business logics
            if(cs != null)
            {

            }
            return new List<Course>();

        }
    }
}
