using CRUDlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PersonController
{

    public List<Person> people = new List<Person>();

    public void AddPerson(int id, string name, double salary)
    {
        if (people.Exists(p => p.Id == id))
        {
            Console.WriteLine("Person with this Id already exists in the database.");
            return;
        }

        people.Add(new Person { Id = id, Name = name, Salary = salary });
        Console.WriteLine("Person added successfully in the database.");
    }

    public void PrintPeople()
    {
        Console.WriteLine("Current list of people:");
        foreach (var person in people)
        {
            Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Salary: {person.Salary}");
        }
        Console.WriteLine();
    }

    public void UpdatePerson(int id, string name, double salary)
    {
        var person = people.Find(p => p.Id == id);
        if (person != null)
        {
            person.Name = name;
            person.Salary = salary;
            Console.WriteLine("Person updated successfully in the database.");
        }
        else
        {
            Console.WriteLine($"Person with Id {id} not found in the database.");
        }
    }

    public void DeletePerson(int id)
    {
        var person = people.Find(p => p.Id == id);

        if (person != null)
        {
            people.Remove(person);
            Console.WriteLine("Person deleted successfully from the database.");
        }
        else
        {
            Console.WriteLine($"Person with Id {id} not found in the database.");
        }
    }

}