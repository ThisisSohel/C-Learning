namespace ArrayWebSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool itr = true;
            //while (itr)
            //{
            //    Console.WriteLine("1- Add user");
            //    Console.WriteLine("2- List user");

            //    var input = Console.ReadLine();
            //    if(int.TryParse(input, out int res))
            //    {
            //        switch (res)
            //        {
            //            case 1:
            //                {
            //                    for (int i = 0; i < 2; i++)
            //                    {
            //                        for(int j = 0; j < 2; j++)
            //                        {
            //                            Console.WriteLine("Enter user Id: ");
            //                            int id = Convert.ToInt32(Console.ReadLine());
            //                            Console.WriteLine("Enter user Name: ");
            //                            string name = Console.ReadLine();

            //                            UserDataBinding(id, name, i, j);
            //                            void UserDataBinding(int id, string name, int i, int j)
            //                            {
            //                                User us = new User();
            //                                us.Id = id;
            //                                us.Name = name;
            //                                us.CreateUser(us, i, j);
            //                            }
            //                        }
            //                    }

            //                    break;
            //                }
            //            case 2:
            //                {
            //                    User userList = new User();
            //                    Console.WriteLine("List of User");
            //                    userList.ListUser();
            //                    break ;
            //                }
            //            default:
            //                {
            //                    return;
            //                }
            //        }

            //    }
            //}


            int[,] arr = new int[2, 2];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }


        }
    }
}
