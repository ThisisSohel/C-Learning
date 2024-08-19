using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDdictionary
{
    public class PersonController
    {
        public Dictionary<int, Person> people = new Dictionary<int, Person>();

        public void AddPerson(int id, string name, double salary)
        {
            if (people.ContainsKey(id))
            {
                Console.WriteLine("Person with this Id already exists in the database.");
                return;
            }

            people[id] = new Person { Id = id, Name = name, Salary = salary };
            Console.WriteLine("Person added successfully in the database.");
        }

        public void PrintPeople()
        {
            Console.WriteLine("Current list of people:");
            foreach (var person in people.Values)
            {
                Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Salary: {person.Salary}");
            }
            Console.WriteLine();
        }

        public void UpdatePerson(int id, string name, double salary)
        {
            if (people.ContainsKey(id))
            {
                people[id].Name = name;
                people[id].Salary = salary;
                Console.WriteLine("Person updated successfully in the database.");
            }
            else
            {
                Console.WriteLine($"Person with Id {id} not found in the database.");
            }
        }

        public void DeletePerson(int id)
        {
            if (people.Remove(id))
            {
                Console.WriteLine("Person deleted successfully in the database.");
            }
            else
            {
                Console.WriteLine($"Person with Id {id} not found.");
            }
        }
    }
}
