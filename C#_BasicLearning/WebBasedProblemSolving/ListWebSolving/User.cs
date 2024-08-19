using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListWebSolving
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    public class UserManager : User
    {
        public static List<User> users = new List<User>();

        public void AddUsers(User user)
        {
            if (users.Exists(u => u.Email == user.Email))
            {
                Console.WriteLine("This user is already there");
            }
            else
            {
                users.Add(user);

            }

        }

        public void GetUsers()  
        {
            var notNullUser = from u in users
                              where u.Name != null && u.Email != null
                              select u;

            foreach (var user in users)
            {
                Console.WriteLine("Name: {0} Email: {1} CreateDate: {2}", user.Name, user.Email, user.RegistrationDate);
            }
        }

        public void RemoveUser(string username)
        {
            var user = GetUserByUserName(username);
            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine($"User with name {user.Name} is deleted");
            }
            else
            {
                Console.WriteLine("User not found!");
            }
        }

        public void SearchUser(string username)
        {
            var individualUser = GetUserByUserName(username);
            if (individualUser != null)
            {
                Console.WriteLine("Name: {0} Email: {1}", individualUser.Name, individualUser.Email);
            }
            else
            {
                Console.WriteLine("User not Found!");
            }
        }

        public User GetUserByUserName (string userName)
        {
            return users.Find(u => u.Name == userName);
        }

        public void  GetAllUsersByUserName(string userName)
        {
            var alluser = from u in users
                          where u.Name == userName
                          select u;
            //List<User> allUser = users.FindAll(u => u.Name == userName);

            foreach (var user in alluser)
            {
                Console.WriteLine("Name: {0} Email: {1}", user.Name, user.Email);
            }

            //foreach (var user in allUser)
            //{
            //    Console.WriteLine("Name: {0} Email: {1}", user.Name, user.Email);
            //}

        }

        public void GetUsersByIndexWise(int fi, int lc)
        {
            List<User> indexedUser = users.GetRange(fi, lc);
            foreach (var user in indexedUser)
            {
                Console.WriteLine("Name: {0} Email: {1}", user.Name, user.Email);
            }
        }

        public void ListSlice()
        {
            List<User> sliceUser = users.Slice(0, users.Count - 1);
            foreach (var user in sliceUser)
            {
                Console.WriteLine("Name: {0} Email: {1}", user.Name, user.Email);
            }
        }

        public void UserUpdate(string name)
        {
            var findUser = GetUserByUserName(name);
            if (users.Contains(findUser))
            {
                Console.WriteLine("Enter the new name you want to update");
                string updateName = Console.ReadLine();
                findUser.Name = updateName;
                Console.WriteLine("User name is updated!");
            }
            else
            {
                Console.WriteLine("User not found!");
            }
        }

    }
}
