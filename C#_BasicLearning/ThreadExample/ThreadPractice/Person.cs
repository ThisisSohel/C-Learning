using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPractice
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public static List<Person> personList = new List<Person>();


        public async Task AddUser(Person person)
        {
            await Task.Delay(2000);
            personList.Add(person);
            Console.WriteLine("Person is added to the list!");
        }

        public async Task PersonsList()
        {
            Console.WriteLine("Person list is under processing! Please wait!!");
            await Task.Delay(3000);
            Console.WriteLine("Person List is here:");
            foreach (Person person in personList)
            {
                Console.WriteLine($"Person Name {person.Name} and Id is {person.Email}");
            }
        }
    }
}
