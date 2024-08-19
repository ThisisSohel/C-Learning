using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public interface IStudentRepository
    {
        void AddStudent(Student std);
        void EditStudent(Student std, int id);
        void DeleteStudent(Student std, int id);
        void ListStudent();
    }
}
