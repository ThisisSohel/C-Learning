
List<Student> list = new List<Student>()
{
   new Student() { Id = 01, Name = "kk", age = 12},
   new Student() { Id = 02, Name = "k1", age = 11},
   new Student() { Id = 04, Name = "k5", age = 6},
};

var student = from s in list
              where s.age > 6
              select new
              {
                  Id = s.Id,
                  Name = s.Name,
                  Age = s.age,
              };
foreach (var st in student)
{
    Console.WriteLine(st.Id + " "+ st.Name + " " + st.Age); 
}
List<Person> per = new List<Person>()
{
    new Person() {Id = 1, Name = "xy", age = 12},
    new Person() {Id = 2, Name = "cc", age = 6},
    new Person() {Id = 3, Name = "dd", age = 3},
};

var per1 = from p in per
           where p.age > 3
           select new
           {
               Id = p.Id,
               Name = p.Name,
               age = p.age
           };

foreach(var per2 in per1)
{
    Console.WriteLine(per2.Id + " " + per2.Name);
}

//var std = new[]
//{
//    new {Id = 1, Name = "sd", Age = 12},
//            new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
//}

var sdt = new
{
    Id = 1, Name = "ss", Age = new
    {
        Early = 20,
        Late = 50,
    },
};
Console.WriteLine(sdt.Id + " " + sdt.Name);


class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int age { get; set; }
}

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int age { get; set; }
}