namespace ObjectMethodPass
{
    internal class Program
    {
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public static List<Person> list = new List<Person>();
            public static Person[] people = new Person[3];
            public static int arrPosituon = 0;

            public Person CreatePerson(Person person, int id, string name)
            {

                person.Id = id;
                person.Name = name;
                list.Add(person);
                people[arrPosituon] = person;
                arrPosituon++;
                return person;
            }

            public void LoadPerson()
            {
                foreach (var l in list)
                {
                    Console.WriteLine(l.Id + " " + l.Name);
                }
            }

            public void LoadPersonArray()
            {
                var arrLoad = from a in people
                              where a != null 
                              select a;
                foreach (var l in arrLoad)
                {
                    Console.WriteLine(l.Id + " -- " + l.Name);
                }
            }
        }

        static void Main(string[] args)
        {
   
            Person p1 = new Person();
            p1.CreatePerson(p1, 1, "Rakib");

            Person p2 = new Person();
            p2.CreatePerson(p2, 2, "Sohan");

            p2.LoadPerson();
            Console.WriteLine("----------");
            p2.LoadPersonArray();
        }
    }
}
