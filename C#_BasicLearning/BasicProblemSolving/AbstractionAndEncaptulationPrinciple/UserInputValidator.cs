using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AbstractionAndEncaptulationPrinciple
{
    public class UserInputValidator
    {
        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(emailPattern, email);
        }

        private bool IsValidPassword(string password)
        {
            if (password.Trim().Length == 0)
            {
                Console.WriteLine("White space is not allowed");
            }
            else if (password.Trim().Length > 10)
            {
                Console.WriteLine("Pass length more than 10 is not allowed");
            }
            else
            {
                Console.WriteLine("Pass length is too short!");
            }
            return password.Trim().Length >= 8;
        }

        public bool ValidateEmail(string email)
        {
            return IsValidEmail(email);
        }

        public bool ValidatePassword(string passwrd)
        {
            return IsValidPassword(passwrd);
        }
    }
}
