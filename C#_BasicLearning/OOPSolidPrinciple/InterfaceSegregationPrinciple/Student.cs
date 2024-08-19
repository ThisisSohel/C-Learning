using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class Student : IStudentRepository
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static List<Student> Students { get; set; }

        public void AddStudent(Student std)
        {
            Student student = new Student();
            student.Id = Id;
            student.Name = Name;
            Students.Add(student);
        }

        public void DeleteStudent(Student std, int id)
        {
            if(std.Id == id)
            {
                Students.Remove(std);

            }
        }

        public void EditStudent(Student std, int id)
        {
            if(std.Id == id)
            {
                Students[std.Id].Name = "Joe";
            }
        }

        public void ListStudent()
        {
            foreach(var st in Students)
            {
                Console.WriteLine("Id: {0} Name: {1}", st.Id, st.Name);
            }
        }
    }
}
