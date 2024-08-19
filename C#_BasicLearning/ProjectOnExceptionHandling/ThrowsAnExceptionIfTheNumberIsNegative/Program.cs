namespace ThrowsAnExceptionIfTheNumberIsNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a integer number");
                int number = Convert.ToInt32(Console.ReadLine());
                ValidatePositiveNumber(number);
                OverFlowValidator(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ValidatePositiveNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException("Negative number is not allowed");
            }
        }

        public static void OverFlowValidator(int number)
        {
            if (number > 10)
            {
                throw new OverflowException("Number is out of bound!");
            }
        }

        public class NegativeNumberException : Exception
        {
            public NegativeNumberException(string message):base(message)
            {

            }
        }

        public class OverflowException : Exception
        {
            public OverflowException(string message): base(message) { }
        }
    }
}
