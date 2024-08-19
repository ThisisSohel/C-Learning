namespace ObjectArray
{
    internal class Program
    {
        static int arrayPosition = 0;
        static void Main(string[] args)
        {
            //Person[] persons = new Person[5];
            Person[] persons = new Person[10];
            List<Person> list = new List<Person>();

            var per1 = new Person();
            per1.CreatePerson(1, "p1", 21, persons);
            var per2 = new Person();
            per2.CreatePerson(2, "p2", 22, persons);
            var per3 = new Person();
            per3.CreatePerson(3, "p3", 23, persons);

            var listPer1 = new Person();
            listPer1.CreatePersonListWithList(1, "p1", 21, list);
            var listPer2 = new Person();
            listPer2.CreatePersonListWithList(2, "p2", 22, list);
            var listPer3 = new Person();
            listPer3.CreatePersonListWithList(3, "p3", 21, list);

            per1.CreatePersonList(persons);
            per1.DeletePersonArrayList(persons);
            per1.CreatePersonList(persons);

            listPer1.CreatePersonLoad(list);
            listPer1.DeletePersonListOfList(list);
            listPer1.CreatePersonLoad(list);

            per1.DeletePersonArrayListById(persons, 1);

            //var p1 = CreatePerson(1, "p1", 21, persons);
            //Console.WriteLine($" Id = {p1.Id} Name = {p1.Name} Age = {p1.Age}");

            //var p2 = CreatePerson(2, "p2", 22, persons);
            //Console.WriteLine($" Id = {p2.Id} Name = {p2.Name} Age = {p2.Age}");


            //var p2 = GetPerson(3, "p1", 22, GetAge);
            //persons[3] = p1;
        }

        //public static Person GetPerson(int id, string name, int age, Func<int, int> getAge)
        //{
        //    Person person = new Person();
        //    person.Id = id;
        //    person.Name = name;
        //    person.Age = getAge(age);

        //    return person;
        //}

        //public static int GetAge(int age)
        //{
        //    return age*2;
        //}

        //public static Person CreatePerson(int id, string name, int age, Person[] pList)
        //{
        //    if (arrayPosition >= pList.Length)
        //    {
        //        Console.WriteLine("Space is full");
        //    }

        //    Person person = new Person();
        //    person.Id = id;
        //    person.Name = name;
        //    person.Age = age;
        //    pList[arrayPosition] = person;
        //    arrayPosition++;

        //    return person;
        //}

        //public static Person CreatePersonList(int id, string name, int age, int[] arr)
        //{
        //    Person person = new Person();
        //    person.Id = id;
        //    person.Name = name;
        //    person.Age = age;

        //    return person;
        //}
    }
}
