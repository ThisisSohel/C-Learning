namespace CommandLineArgs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Enter the input: ");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Hello," + args[0]);
            Console.ReadKey();
        }
    }
}
