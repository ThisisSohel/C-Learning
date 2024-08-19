using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static int currentIndex = 0;

        public void CreatePerson(int id, string name, int  age, Person[] people)
        {
            if (currentIndex >= people.Length)
            {
                Console.WriteLine("Database is full");
                return;
            }

            people[currentIndex] = new Person 
            {   Id = id, 
                Name = name, 
                Age = age 
            };
            currentIndex++;
        }

        public void CreatePersonList(Person[] people)
        {
            Console.WriteLine("Current list of people:");
            for (int i = 0; i < currentIndex; i++)
            {
              Console.WriteLine($"Id: {people[i].Id}, Name: {people[i].Name}, Salary: {people[i].Age}");
            }
        }
        public void CreatePersonListWithList(int id, string name, int age, List<Person> people)
        {
            people.Add(new Person
            {
                Id = id,
                Name = name,
                Age = age
            });
        }

        public void CreatePersonLoad(List<Person> people)
        {
            Console.WriteLine("Current list of List-of-people:");
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"Id: {people[i].Id}, Name: {people[i].Name}, Salary: {people[i].Age}");
            }
        }

        public void DeletePersonArrayList(Person[] people)
        {
            if(currentIndex != 0)
            {
                Array.Clear(people, 0, currentIndex);
                currentIndex = 0;
                Console.WriteLine("People ArrayList is empty now!");
            }
        }

        public void DeletePersonArrayListById(Person[] people, int id)
        {
            int individualPerson = Array.IndexOf(people, id);
            if ()
            {
                Array.Clear(people, 0, currentIndex);
                currentIndex = 0;
                Console.WriteLine("People ArrayList is empty now!");
            }
        }

        public void DeletePersonListOfList(List<Person> people)
        {
            people.Clear();
            Console.WriteLine("List is clear now!");
        }

    }
}
