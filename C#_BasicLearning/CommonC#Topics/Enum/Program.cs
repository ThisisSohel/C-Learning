
using System.Text;

//Console.WriteLine(weakdays.friday);

//int day = (int) weakdays.friday;
//Console.WriteLine(day);
//var wd = (weakdays)5;
//Console.WriteLine(wd);


//StringBuilder sb = new StringBuilder("Hello World!"); 

//for (int i = 0; i< sb.Length; i++)
//{
//    Console.WriteLine(sb[i]);
//}

//sb.AppendLine("gjhgdsjhf gertr twerwerwe");
//sb.Append("sdhg sdghg");
//sb.Insert(2, "Dhaka");
//sb.Replace("gertr", "Hi");
//sb.Remove(2, 3);

//Console.WriteLine(sb);

//var student = new 
//{ 
//    Id = 1, 
//    Name = "Ali", 
//    Age = 23 
//};
//Console.WriteLine(student.Id);
//Console.WriteLine(student.Name);
//Console.WriteLine(student.Age);


//IList<Student> studentList = new List<Student>() {
//            new Student() { Id = 1, Name = "John", Age = 18 },
//            new Student() { Id = 2, Name = "Steve",  Age = 21 },
//            new Student() { Id = 3, Name = "Bill",  Age = 18 },
//            new Student() { Id = 4, Name = "Ram" , Age = 20  },
//            new Student() { Id = 5, Name = "Ron" , Age = 21 }
//        };

//Student student1 = new Student()
//{
//    Id = 1,
//    Name = "Rakib",
//    Age = 23,
//};
//Student student2 = new Student()
//{
//    Id = 2,
//    Name = "Rakib",
//    Age = 24,
//};
//Student student3 = new Student()
//{
//    Id = 2,
//    Name = "Rakib",
//    Age = 26,
//};

//List<Student> secondStList = new List<Student>();
//secondStList.Add(student1);
//secondStList.Add(student2);
//secondStList.Add(student3);

//if (secondStList.Contains(student3))
//{
//    studentList.Remove(student1);
//}
//else
//{
//    Console.WriteLine("Student is not Found!");
//}
//for (int i = 0; i < secondStList.Count; i++)
//{
//    Console.WriteLine("Id = {0} Name = {1} Age = {2}", secondStList[i].Id, secondStList[i].Name, secondStList[i].Age);
//}


//var studentFindList = from s in studentList
//               where s.Age > 18
//               select new { Id = s.Id, Name = s.Name, Age = s.Age };


//foreach(var st  in studentFindList)
//{
//    Console.WriteLine(st.Id + " " + st.Name);
//}

//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Age { get; set; }
//}


//Nullable<int> age = null;

//Console.WriteLine(age);

//int? i = null;

//NullClass  nullClass = new NullClass();
//nullClass.Id = 1;

//if(nullClass.Id == null)
//{
//    Console.WriteLine("id is null !");
//}
//else
//{
//    Console.WriteLine("Has a value");
//}

//class NullClass
//{
//    public Nullable<int> Id { get; set; }   
//}

var person = new[]
{
    new { Id = 1, Name = "SS"},
    new { Id = 2, Name = "tt"}
};
Console.WriteLine(person[0].Name + " " + person[0].Id);
var student = new
{
    Id = 1,
    Name = "Rakib",
    address = new
    {
        Id = 2, House = 22
    }
};
Console.WriteLine(student.Id);
Console.WriteLine(student.address.House);

Console.WriteLine(days.Friday);
int dayNum = (int)days.Friday;
Console.WriteLine(dayNum);
var wd = (days)5;

Console.WriteLine(wd);

Console.WriteLine(months.May);

int n = (int)months.May;
Console.WriteLine(n);

enum months
{
    January, 
    February,
    March,
    April,
    May,
    June,
    July
}
enum days
{
    Saturday,
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
}

