using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperationUsingArray
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        Person[] persons = new Person[10];
        int arrayPosition = 0;
        //public Person(int id, string name, int age)
        //{
        //    Id = id;
        //    Name = name;
        //    Age = age;
        //}

        public void CreatePerson(Person person)
        {
            int arrayPosition = 0;
            if(arrayPosition > 10)
            {
                Console.WriteLine("There is no space available in the array!");
            }
            else
            {
                persons[arrayPosition] = person;
                arrayPosition++;
            }
        }

        public void UpdatePerson(Person person)
        {

            if(arrayPosition < 10)
            {
                Console.WriteLine("Need an valid index");
            }
            else
            {
                persons[arrayPosition] = person;
            }
        }

        public void DeletePerson(Person person)
        {
            int arrayPosition = 0;
            if (arrayPosition < 10)
            {
                Console.WriteLine("Need a valid index!");
            }
            else
            {
                
            }
        }

        public void ListPersone(Person person)
        {
            for(int i = 0; i < arrayPosition; i++)
            {
                Console.WriteLine(persons[i].Id + " " + persons[i].Name + " " + persons[i].Age);
            }
        }
    }
}
