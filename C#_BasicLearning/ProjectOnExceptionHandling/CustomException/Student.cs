using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class InvalidStudentNameException: Exception
    {
        public InvalidStudentNameException() { }

        public InvalidStudentNameException(string message) 
            : base(message)
        {

        }
    }
}
