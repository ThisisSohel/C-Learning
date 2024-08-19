using System.Security.Cryptography.X509Certificates;

namespace ThreadPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task t1 = Task.Run(() =>
            //{
            //    Console.WriteLine("Task1running");
            //    Task.Delay(1000).Wait();
            //    Console.WriteLine("Task1 done");
            //});
            //Task t2 = Task.Run(() =>
            //{
            //    Console.WriteLine("Task2running");
            //    Task.Delay(2000).Wait();
            //    Console.WriteLine("Task2 done");
            //});
            //Task t3 = Task.Run(() =>
            //{
            //    Console.WriteLine("Task3running");
            //    Task.Delay(5000).Wait();
            //    Console.WriteLine("Task3 done");
            //});

            //Task.WaitAll(t1, t2,t3);

            bool iteration = true;
            while (iteration)
            {
                Console.WriteLine("1- Add user");
                Console.WriteLine("2- List user");
                Console.WriteLine("3- Delete User By Name");
                Console.WriteLine("4- User Update:");
                Console.WriteLine("5- Exit");

                var input = Console.ReadLine();
                if (int.TryParse(input, out int reuslt))
                {
                    switch (reuslt)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter user name: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter user email: ");
                                string email = Console.ReadLine();

                                UserDataBinding(name, email);

                                async Task UserDataBinding(string name, string email)
                                {
                                    Console.WriteLine("Person is being added.....");
                                    Person person = new Person();
                                    person.Name = name;
                                    person.Email = email;
                                    await person.AddUser(person);
                                }
                                break;
                            }
                        case 2:
                            {
                                var methodCall = DataList();
                                async Task DataList()
                                {
                                    Person listUser = new Person();
                                    await listUser.PersonsList();
                                }
                                break;
                            }
                        case 3:
                            {
                                break;
                            }
                        case 4:
                            {


                                break;
                            }
                        default:
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Enter a valid input");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Please input a numeric number: ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }

            }
        }
    }
}

