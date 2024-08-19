using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDarray
{
    public  class PersonController
    {
        public Person[] people = new Person[10];
        public int currentIndex = 0;

        public void AddPerson(int id, string name, double salary)
        {
            if (currentIndex >= people.Length)
            {
                Console.WriteLine("Database is full, Cannot add more people in the database.");
                return;
            }

            people[currentIndex] = new Person { Id = id, Name = name, Salary = salary };
            currentIndex++;
            Console.WriteLine("Person added successfully in the database.");
        }

        public void PrintPeople()
        {
            Console.WriteLine("Current list of people:");
            for (int i = 0; i < currentIndex; i++)
            {
                if (people[i] != null)
                {
                    Console.WriteLine($"Id: {people[i].Id}, Name: {people[i].Name}, Salary: {people[i].Salary}");
                }
            }
            Console.WriteLine();
        }

        public void UpdatePerson(int id, string name, double salary)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (people[i] != null && people[i].Id == id)
                {
                    people[i].Name = name;
                    people[i].Salary = salary;
                    Console.WriteLine("Person updated successfully in the database");
                    return;
                }
            }
            Console.WriteLine($"Person with Id {id} not found.");
        }

        public void DeletePerson(int id)
        {
            int index = Array.FindIndex(people, 0, currentIndex, p => p != null && p.Id == id);

            if (index != -1)
            {
                //people = RemoveAt(people, index);
                currentIndex--;
                Console.WriteLine("Person removed successfully from database");
            }
            else
            {
                Console.WriteLine($"Person with Id {id} not found.");
            }
        }
    }
}
