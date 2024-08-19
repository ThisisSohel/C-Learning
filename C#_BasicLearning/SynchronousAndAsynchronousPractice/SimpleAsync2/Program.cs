namespace SimpleAsync2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Start calculating.......");
            int sum = await CalculateSumAsync(1, 2);
            Console.WriteLine(sum);

        }

        public static async Task<int> CalculateSumAsync(int a, int b)
        {
            try
            {
                Console.WriteLine("Calculating....");
                await Task.Delay(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return a + b;
        }
    }
}
