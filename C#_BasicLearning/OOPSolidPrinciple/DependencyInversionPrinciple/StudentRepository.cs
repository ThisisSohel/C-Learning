using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class StudentRepository
    {
        public void AddStudent(Student std)
        {

        }

        public void DeleteStudent(Student std)
        {

        }

        public void EditStudent(Student std)
        {

        }

        public IList<Student> GetAllStudents()
        {
            return new List<Student>();
        }
    }
}
