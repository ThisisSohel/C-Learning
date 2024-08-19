using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace OrganizationProject
{
    public class OrgStruct
    {

        public struct Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public void InfoSet(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public void BasicInfoPrint()
            {
                Console.WriteLine($" Id = {Id}");
                Console.WriteLine($" Name = {Name}");
            }
        }

        public struct Student
        {
            public string Class { get; set; }
            public Person person { get; set; }

            public void Test(int id, string name, string className)
            {
                Class = className;
                person.InfoSet(id, name);
            }

            public void StudentInfo()
            {
                person.BasicInfoPrint();
                Console.WriteLine("Student Designation: " + Class);
            }
        }

        public struct Teacher
        {
            public string Designation { get; set; }
            public Person person { get; set; }

            public void Test(int id, string name, string designation)
            {
                person.InfoSet(id, name);
                Designation = designation;
            }

            public void TeacherInfo()
            {
                person.BasicInfoPrint();
                Console.WriteLine($"Designation = {Designation}");
            }
        }

        class Program
        {
            static void Main()
            {
                bool exit = false;
                List<Teacher> teachers = new List<Teacher>();
                List<Student> students = new List<Student>();

                while (!exit)
                {
                    Console.WriteLine("Teacher Add: 1");
                    Console.WriteLine("Student Add: 2");
                    Console.WriteLine("Teacher List: 3");
                    Console.WriteLine("Student List: 4");
                    Console.WriteLine("Teacher Delete: 5");
                    Console.WriteLine("Student Delete: 6");
                    Console.WriteLine("Enter '7' to Exit the program");

                    int read = Convert.ToInt32(Console.ReadLine());

                    switch (read)
                    {
                        case 1:
                            {
                                Console.WriteLine("                              User Registration");
                                Console.WriteLine("                              .................");
                                Teacher teacher = new Teacher();
                                Console.WriteLine("Enter the Teacher Id: ");
                                int teacherId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the Teacher Name: ");
                                var teacherName = Console.ReadLine();
                                Console.WriteLine("Enter the Designation: ");
                                var teacherDeg = Console.ReadLine();
                                teacher.Test(teacherId, teacherName, teacherDeg);

                                teachers.Add(teacher);
                                Console.WriteLine("Data from List");
                                Console.WriteLine("");
                                foreach (var th in teachers)
                                {
                                    th.TeacherInfo();
                                    Console.WriteLine("");
                                }
                                break;
                            }
                        case 2:
                            {
                                Student student = new Student();
                                Console.WriteLine("Enter the student Id: ");
                                var studentId = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the student Name: ");
                                var studentName = Console.ReadLine();
                                Console.WriteLine("Enter the student Class: ");
                                var studentClass = Console.ReadLine();
                                student.Test(studentId, studentName, studentClass);
                                students.Add(student);

                                Console.WriteLine("Data from List");
                                Console.WriteLine("");
                                foreach (var th in students)
                                {
                                    th.StudentInfo();
                                }
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Data from List");
                                Console.WriteLine("");
                                foreach (var th in teachers)
                                {
                                    th.TeacherInfo();
                                    Console.WriteLine("");
                                }
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Data from List");
                                Console.WriteLine("");
                                foreach (var th in students)
                                {
                                    th.StudentInfo();
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                }

                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Delete All Teacher");
                                Console.WriteLine("");

                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Data from List");
                                Console.WriteLine("");
                                foreach (var th in students)
                                {
                                    th.StudentInfo();
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                }

                                break;
                            }
                        case 7:
                            exit = true;
                            break;
                    }
                }
            }
        }
    }
}
