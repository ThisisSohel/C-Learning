
//public class ParentClass
//{
//    public ParentClass()
//    {
//        Console.WriteLine("Parent Class");
//    }
//    public ParentClass(string Message)
//    {
//        Console.WriteLine($"{Message}");
//    }
//}
//public class ChildClass : ParentClass
//{
//    public ChildClass() : base("Derived class controlling the base class")
//    {
//        Console.WriteLine("Child Class ");
//    }
//}
//public class Employee
//{
//    public string FirstName;
//    public string LastName;
//    public string Email;

//    public void PrintFullName()
//    {
//        Console.WriteLine(FirstName + " " + LastName);
//    }
//}

//public class FullTimeEmployee : Employee
//{
//    public float YearlySalary;
//}
//public class PartTimeEmployee : Employee
//{
//    public float HourlyRate;

//}

//public class A
//{
//    private int _value = 10;
//    internal int _count = 10;
//    public class B : A
//    {
//        public int GetValue()
//        {
//            return _value;
//        }
//    }
//}

using Inheritance;

public class Program
{
    public static void Main()
    {
        //FullTimeEmployee FTE = new FullTimeEmployee();
        //FTE.FirstName = "Rakib";
        //FTE.LastName = "Hasan";
        //FTE.Email = "xyz@gmail.com";
        //FTE.YearlySalary = 5000000;
        //FTE.PrintFullName();
        //PartTimeEmployee PTE = new PartTimeEmployee();
        //PTE.FirstName = "Part";
        //PTE.LastName = "Time";
        //PTE.PrintFullName();

        //ChildClass childClass = new ChildClass();

        //Student stu = new Student(1, "s1", "xyz@gmail.com");
        //stu.InfoDetails();

        AreaOfTank areaOfTank = new AreaOfTank(1, 2, "Red");
        areaOfTank.DisplayDimension();
        Tank tank = new Tank();
        //tank.Radious = 2;
        //tank.Height = 2;    
        tank.DisplayDimension();

    }
}


