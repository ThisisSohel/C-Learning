using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private StudentRepository _stuRepo = new StudentRepository();

        public void Save()
        {
            _stuRepo.AddStudent(this);
        }

        public void Delete(int? id, Student std)
        {
            _stuRepo.DeleteStudent(std);
        } 


    }
}
