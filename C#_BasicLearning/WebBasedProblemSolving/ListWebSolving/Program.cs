using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace ListWebSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool iteration = true;
            while (iteration)
            {
                Console.WriteLine("1- Add user");
                Console.WriteLine("2- List user");
                Console.WriteLine("3- Delete User By Name");
                Console.WriteLine("4- Find single user:");
                Console.WriteLine("5- Find All users:");
                Console.WriteLine("6- Show userlist indexwise(Fisrt and Last):");
                Console.WriteLine("7- Show userlist inSlice:");
                Console.WriteLine("8- User Update:");
                Console.WriteLine("10- Exit");

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

                                void UserDataBinding(string name, string email)
                                {
                                    UserManager us = new UserManager();
                                    us.Name = name;
                                    us.Email = email;
                                    us.RegistrationDate = DateTime.Now;

                                    us.AddUsers(us);
                                }
                                break;
                            }
                        case 2:
                            {
                                UserManager listUser = new UserManager();
                                listUser.GetUsers();
                                break;
                            }
                        case 3:
                            {
                                UserManager userDelete = new UserManager();
                                Console.WriteLine("Enter user name to delete a user: ");
                                string userName = Console.ReadLine();
                                userDelete.RemoveUser(userName);
                                break;
                            }
                        case 4:
                            {
                                UserManager findUser = new UserManager();
                                Console.WriteLine("Enter username to search an user");
                                string userName = Console.ReadLine();
                                findUser.SearchUser(userName);

                                break;
                            }
                        case 5:
                            {
                                UserManager getAllUser = new UserManager();
                                Console.WriteLine("Enter the name you are searching for - ");
                                string userName = Console.ReadLine();
                                Console.WriteLine("List of all the search users");
                                getAllUser.GetAllUsersByUserName(userName);
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("Enter your first Index: ");
                                int findex = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the number of element: ");
                                int lCount = Convert.ToInt32(Console.ReadLine());

                                UserManager findUserByIndex = new UserManager();
                                findUserByIndex.GetUsersByIndexWise(findex-1, lCount - 1);
                                break;
                            }
                        case 7:
                            {
                                UserManager findUser = new UserManager();
                                findUser.ListSlice();
                                break;
                            }
                        case 8:
                            {
                                UserManager userManager = new UserManager();
                                Console.WriteLine("Enter the user name whose name you want to update: ");
                                string name = Console.ReadLine();
                                userManager.UserUpdate(name);
                                break;
                            }
                        case 10:
                            {

                                iteration = false;
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
