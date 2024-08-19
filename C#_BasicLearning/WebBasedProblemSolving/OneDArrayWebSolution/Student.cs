using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDArrayWebSolution
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static Student[] students = new Student[1];
        public static int arrayPosition = 0;
        public void AddStudent(Student stu)
        {
            if(arrayPosition == 0)
            {
                students[arrayPosition] = stu;
                arrayPosition++;
            }
            else if (Array.Exists(students, s => s.Id == stu.Id))
            {
                Console.WriteLine($"Student with Id {stu.Id} is already exist in the array");
            }
            else
            {
                Array.Resize(ref students, students.Length + 1);
                students[arrayPosition] = stu;
                arrayPosition++;
            }   
        }

        public void StudentList()
        {
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Id: {students[i].Id} Name: {students[i].Name}");
            }
        }

        public void StudentFind(int id)
        {
            var individualStudent = FindStudentById(id);
            if(individualStudent != null)
            {
                Console.WriteLine($"Id: {individualStudent.Id} Name: {individualStudent.Name}");

            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        public void AllStudentSearch(string name)
        {
            var findSearch = from student in students
                             where student.Name == name 
                             select student;

            Console.WriteLine("All the student from your search list: ");
            foreach (var student in findSearch)
            {
                Console.WriteLine($"Id: {student.Id} Name: {student.Name}");
            }

        }


        public void StudentUpdate(int id, string name)
        {
            if(Array.Exists(students, s => s.Id == id))
            {
                int indexToUpdate = Array.IndexOf(students, id);
                Console.WriteLine("Enter the new name of the student to update name");
                students[indexToUpdate].Name = name;
            }
            else
            {
                Console.WriteLine("Student not found!");
            }



        }
        public Student FindStudentById(int id)
        {
            return Array.Find(students, s => s.Id == id);   
        }


    }
}
