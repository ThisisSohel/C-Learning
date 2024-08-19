using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationProject
{
    public class Student : Person
    {
        List<Student> students = new List<Student>();
        public string Class { get; set; }

        public void Test(int id, string name, string className)
        {
            Class = className;
            InfoSet(id, name);
        }
        public void StudentInfo()
        {
            base.BasicInfoPrint();
            Console.WriteLine("Student Designation: " + Class);
        }
    }
}