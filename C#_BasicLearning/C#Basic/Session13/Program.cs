namespace Session13
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("process start...");
            await Sum(3, 6);
            Console.WriteLine("Process End");

        }

        public static async Task Sum(int a, int b)
        {
            Console.WriteLine("Before Delay...");
            await Task.Delay (3000);
            Console.WriteLine("process done(Sum)!!");
        }
    }
}
