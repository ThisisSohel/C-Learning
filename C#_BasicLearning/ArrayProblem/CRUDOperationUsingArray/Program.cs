using System.Security;

namespace CRUDOperationUsingArray
{
    internal class Program
    {
        static Person[] persons = new Person[10];
        static int currentIndex = 0;
        static void Main(string[] args)
        {

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1. Add Person to Array");
                Console.WriteLine("2. List Person from Array");
                Console.WriteLine("3. Delete A Person from Array");
                Console.WriteLine("4. Read List of Persons");
                Console.WriteLine("5. Exit");

                int readChoice = Convert.ToInt32(Console.ReadLine());


                switch (readChoice)
                {
                    case 1:
                        {
                            AddPerson();
                            break;
                        }
                    case 2:
                        {
                            ListPerson();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("A person in the Array:");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("All Person in ArrayList:");
                            break;
                        }
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }

        }
        public static void AddPerson()
        {
            if(persons.Length <= currentIndex)
            {
                Console.WriteLine("Array is full!");
                return;
            }
            Console.WriteLine("Enter the Persons to add in List:");

            Console.WriteLine("Enter Person Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Person Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Person Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            persons[currentIndex] = new Person
            {
                Id = id,
                Name = name,
                Age = age
            };
            currentIndex++;
            Console.WriteLine("Person Added Successfully!");
        }

        public static void ListPerson()
        {
            Console.WriteLine("Current List of Persons");
            for (int i = 0; i < currentIndex; i++)
            {
                if (persons[i].Id != null)
                {
                    Console.WriteLine($"Id: {persons[i].Id} Name: {persons[i].Name} Age: {persons[i].Age}");
                }
            }
        }
    }
}
