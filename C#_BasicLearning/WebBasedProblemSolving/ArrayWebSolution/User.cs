using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWebSolution
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static User[,] users = new User[2,2];

        public void CreateUser(User user, int i, int j)
        {
            users[i, j] = user;
        }

        public void ListUser()
        {
            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Id: {users[i, j].Id}  Name: {users[i, j].Name}");
                }
            }
        }
    }
}
