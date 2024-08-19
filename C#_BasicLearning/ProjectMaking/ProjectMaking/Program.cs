namespace CRUDarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonController controller = new PersonController();

            while (true) 
            {
                Console.WriteLine("Choose an operation: ");
                Console.WriteLine("1. Add ");
                Console.WriteLine("2. View all persons list. ");
                Console.WriteLine("3. Update a person. ");
                Console.WriteLine("4. Delete a person. ");
                Console.WriteLine("5. Exit. ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                        case 1:
                        {
                            Console.Write("Enter Id: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Salary: ");
                            double salary = double.Parse(Console.ReadLine());
                            controller.AddPerson(id, name, salary);

                            break;
                        }
                        case 2:
                        {
                            controller.PrintPeople();
                            break;
                        }
                        case 3:
                        {
                            Console.Write("Enter Id of the person to update: ");
                            int updateId = int.Parse(Console.ReadLine());
                            Console.Write("Enter new Name: ");
                            string updateName = Console.ReadLine();
                            Console.Write("Enter new Salary: ");
                            double updateSalary = double.Parse(Console.ReadLine());
                            controller.UpdatePerson(updateId, updateName, updateSalary);
                            break;
                        }
                        case 4:
                        {
                            Console.Write("Enter Id of the person to delete: ");
                            int deleteId = int.Parse(Console.ReadLine());
                            controller.DeletePerson(deleteId);
                            break;
                        }
                        case 5:
                        {
                            return;
                        }
                        default:
                        {
                            Console.WriteLine("Invalid Choice! Try Again!");
                            break;
                        }
                }
            }
        }
    }
}
