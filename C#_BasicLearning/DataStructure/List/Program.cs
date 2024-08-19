
//using System;

//List<Person> people = new List<Person>()
//{
//    new Person() {Id = 12, Name = "p1", Age = 13},
//    new Person() {Id = 13, Name = "p2", Age = 14},
//    new Person() {Id = 15, Name = "p3", Age = 16}
//};

////int index = people.IndexOf(people[0]);

//Person p = people[0];
//if(people.Exists(cust => cust.Name.StartsWith("P")))
//{

//}

//if (people.Contains(p))
//{
//    Console.WriteLine("Id = {0} Name = {1} Age = {2}", p.Id, p.Name, p.Age);
//}
//else
//{
//    Console.WriteLine("User Not Found");
//}

////Person tergetPerson = new() { Id = 13, Name = "p2", Age = 14 };
////int index1 = people.IndexOf(tergetPerson);

////if(index1 != -1)
////{
////    Console.WriteLine("User Found");
////}
////else
////{
////    Console.WriteLine("Not Found!");
////}
//for (int i = 0; i < people.Count; i++)
//{
//    Person ple = people[i];
//    Console.WriteLine(ple.Id + " " + ple.Name + " " + ple.Age);
//}

//foreach(var person in people)
//{
//    Console.WriteLine("Id: {0}, Name: {1}, Age: {2}", person.Id, person.Name, person.Age);
//}

//List<int> list = new List<int>()
//{
//    1, 4, 6, 8, 4, 8, 10, 8
//};

//int index = list.IndexOf(4);
//int indexLast = list.LastIndexOf(8);

//Console.WriteLine("Last index: " + indexLast);
//if (index != -1)
//{
//    list.RemoveAt(index);
//}
//else
//{
//    Console.WriteLine("Index element not found!");
//}

//for (int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}

//class Person
//{
//    public int Id { get; set; } 
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

Person person1 = new Person()
{
    Id = 1,
    Salary = 200
};

Person person2 = new Person()
{
    Id = 2,
    Salary = 200
};
Person person3 = new Person()
{
    Id = 3,
    Salary = 100
};

List<Person> personList = new List<Person>();
personList.Add(person1);
personList.Add(person2);
personList.Add(person3);

//personList.Remove(person1);
//personList.RemoveAt(0);
//personList.RemoveRange(0, 1);

var result = from p in personList 
             where p.Salary == 200
             select p;

foreach (var p1 in result)
{
    Console.WriteLine("Id = {0} Salary = {1}", p1.Id, p1.Salary);
}


Person individualPerson = personList[2];


if (personList.IndexOf(person1) == -1)
{
    Console.WriteLine("Person not Found!");
}
else
{
    Console.WriteLine("Id = {0} Salary = {1}", individualPerson.Id, individualPerson.Salary);
}
Console.WriteLine("Id = {0} Salary = {1}", individualPerson.Id, individualPerson.Salary);

Person fLast = personList.FindLast(cust => cust.Salary ==200)!;
Console.WriteLine("Id = {0} Salary = {1}", fLast.Id, fLast.Salary);

List<Person> findAll = personList.FindAll(cust => cust.Salary == 200); 

foreach(var p1  in findAll)
{
    Console.WriteLine("Id = {0} Salary = {1}", p1.Id, p1.Salary);
}




List<int> list = new List<int>();
list.Add(0);
list.Add(1);
list.Add(2);

int[] arr = new int[6] { 10, 20, 30, 40, 50, 11};

list.AddRange(arr);
list.Insert(0, 10000);

int index = list.IndexOf(10, 1, 2);
if (index == -1)
{
    Console.WriteLine("Indexed Value not Found!");
}
else
{
    Console.WriteLine(list[index] + " " + index);
}
if (list.Contains(32373))
{
    Console.WriteLine(list[32373]);
}
else
{
    Console.WriteLine("Value not found");
}


foreach (var i in list)
{
    Console.WriteLine(i);
}

class Person
{
    public int Id { get; set; }
    public int Salary { get; set; }
}