using System.IO;

namespace PersonList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            Person p1 = new Person()
            {
                Id = 1,
                Name = "Foo",
                Salary = 2342
            };
            Person p2 = new Person()
            {
                Id = 1,
                Name = "Rakib",
                Salary = 1230
            };

            Person p3 = new Person()
            {
                Id = 2,
                Name = "Rakib Hasan",
                Salary = 1200
            };

            Person p4 = new Person()
            {
                Id = 2,
                Name = "Sakib Hasan",
                Salary = 1300
            };

            personList.Add(p1);
            personList.Add(p2);
            personList.Add(p3);
            personList.Add(p4);

            Console.WriteLine("\nFind: Part where name contains \"Hasan\": {0}",
                                  personList.Find(x => x.Name.Contains("Hasan")));

            if (personList.LastIndexOf(p1) == -1)
            {
                Console.WriteLine("Not Found!");
            }
            else
            {
                Console.WriteLine(p1.Id + p1.Name + p1.Salary);
            }

            if(personList.Contains(p1))
            {
                Console.WriteLine("P1 is found!");
            }
            else
            {
                Console.WriteLine("Not found!");
            }


        }
    }
}
