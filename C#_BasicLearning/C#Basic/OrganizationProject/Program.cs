using OrganizationProject;

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
                Console.Clear();
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
                Console.Clear();
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
                Console.WriteLine("Enter the Teacher ID to delete:");
                int teacherIdToDelete = Convert.ToInt32(Console.ReadLine());

                Teacher teacherToDelete = teachers.Find(t => t.TeacherId == teacherIdToDelete);

                if (teacherToDelete != null)
                {
                    teachers.Remove(teacherToDelete);
                }
                else
                {
                    Console.WriteLine("Teacher with the given ID not found.");
                }

                break;
            }
        case 6:
            {
                Console.WriteLine("Enter the Student ID to delete:");
                int studentIdToDelete = Convert.ToInt32(Console.ReadLine());

                Student studentToDelete = students.Find(s => s.StudentId == studentIdToDelete);

                if (studentToDelete != null)
                {
                    students.Remove(studentToDelete);
                }
                else
                {
                    Console.WriteLine("Student with the given ID not found.");
                }
                break;
            }
        case 7:
            exit = true;
            break;
    }

    
}
