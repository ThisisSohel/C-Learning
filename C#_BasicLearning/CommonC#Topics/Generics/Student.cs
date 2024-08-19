using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Student<T>
    {
        public int Id { get; set; }
        public T Success { get; set; }

        public  void PrintStudentInfo<T>(Student<T> student)
        {
            Console.WriteLine("Id = {0} and Success: {1}", student.Id, student.Success);

        }
        
    }
}
