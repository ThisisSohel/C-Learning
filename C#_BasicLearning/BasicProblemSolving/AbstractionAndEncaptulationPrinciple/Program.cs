namespace AbstractionAndEncaptulationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInputValidator validator = new UserInputValidator();
            bool isValidMail = validator.ValidateEmail("mdsrana11@gmail.com");
            bool isValidPass = validator.ValidatePassword("5346");

            if (isValidMail)
            {
                Console.WriteLine("Your mail is correct!");
            }
            else
            {
                Console.WriteLine("Incorrect Mail!");
            }

            if (isValidPass)
            {
                Console.WriteLine("Your password is correct!");
            }
            else
            {
                Console.WriteLine("Incorrect password!");
            }
        }
    }
}
