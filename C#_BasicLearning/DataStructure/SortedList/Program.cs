//Person person1 = new Person()
//{
//    Id = 1,
//    Name = "P1",
//    Salary = 2000
//};
//Person person2 = new Person()
//{
//    Id = 2,
//    Name = "P2",
//    Salary = 2000
//};
//Person person3 = new Person()
//{
//    Id = 3,
//    Name = "P3",
//    Salary = 1000
//};


//SortedList<int, Person> personInfo = new SortedList<int, Person>();
//personInfo.Add(person1.Id, person1);
//personInfo.Add(person2.Id, person2);
//personInfo.Add(person3.Id, person3);

//foreach (KeyValuePair<int, Person> p in personInfo)
//{
//    Console.WriteLine("PersonId: {0}", p.Key);
//    Person person = p.Value;
//    Console.WriteLine("PersonName: {0} and PersonSalary: {1}" , person.Name, person.Salary);
//} 

//class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//}


SortedList<int, string> kv = new SortedList<int, string>();

kv.Add(15, "d");
kv.Add(0, "a");
kv.Add(4, "c");
kv.Add(3, "b");

if (kv.ContainsKey(1))
{
    Console.WriteLine(kv[1]);
}
else
{
    Console.WriteLine("Not found");
    kv.Add(1, "a");
}

kv.RemoveAt(110);

for (int i = 0; i<kv.Count; i++)
{
    Console.WriteLine("Key = {0} and Value = {1}", kv.Keys[i], kv.ElementAt(i).Value);
}


foreach(var kv2 in kv)
{
    Console.WriteLine(kv2.Key + " " + kv2.Value);
}