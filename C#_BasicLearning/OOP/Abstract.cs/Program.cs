

using Abstract.cs;

class Program
{
    public static void Main(string[] args)
    {
        

        //Student student = new Student();

        //student.Print();
        ////student.IPerson();
        //Demo1 demo1 = new Demo1();
        //Console.WriteLine("X = " + demo1.X);
        //Console.WriteLine("Y = " + demo1.Y);

        Teacher teacher = new Teacher("Rakib", "xyz@gmail.com");
        Course course = new Course("Introduction of Programming Language", "Learn Basic Programming", teacher);
        Student student = new Student("Sohel", "Mirpur-10");

        student.EnrollCourse(course);
        course.AddStudent(student);
        teacher.AssignCourse(course);

        Console.WriteLine($"Student {student.Name} enrolled in {student.Courses[0].CourseName}");
        Console.WriteLine($"Course {course.CourseName} is taught by {course.Teacher.Name}");
        Console.WriteLine($"Teacher {teacher.Name} teaches {teacher.Courses[0].CourseName}");

    }
}

