
//FullTimeEmployee FTE = new FullTimeEmployee();
//FTE.FirstName = "F1";
//FTE.LastName = "Fl";
//FTE.Email = "xyz@gmail.com";
//FTE.FullInfo();
//PartTimeEmployee PTE = new PartTimeEmployee();
//PTE.FirstName = "F1";
//PTE.LastName = "Fl";
//PTE.Email = "xyz@gmail.com";
//FTE.FullInfo();

//public class Employee
//{
//    public string FirstName;
//    public string LastName;
//    public string Email;

//    public void FullInfo()
//    {
//        Console.WriteLine(" FirstName: " + FirstName + "  LastName: " + LastName + "  Email: " + Email);
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




using Inheritance;
/*
Student a = new ExStudent();
a.Id = 1;
a.Name = "S1";
a.StuId = 10;
//a.PassingYear = 2012;
a.FullInfo();

var student = new Student();
student.Ref = "32";
Console.WriteLine(student.Ref);

var stuff = new Stuff();
stuff.Ref = "32";
Console.WriteLine(stuff.Ref);
*/

MilitaryFactory militaryFactory = new MilitaryFactory();
militaryFactory.Info();
var list = new List<Factory>();
list.Add(militaryFactory);

News news = new News();
news.FactoryInfo(list);



