namespace OverFlowException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter number");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
