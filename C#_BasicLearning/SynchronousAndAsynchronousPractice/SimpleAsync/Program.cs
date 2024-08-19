namespace SimpleAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string processedData = await ProcessDataAsync();
            Console.WriteLine($"Processed Data: {processedData}");
        }

        public static async Task<string> FetchDataAsync()
        {
            Console.WriteLine("Data fetch starting.....");
            await Task.Delay(3000);
            Console.WriteLine("Data fetched!");
            return "Sample Data";
        }

        public static async Task<string> ProcessDataAsync()
        {
            Console.WriteLine("Data data processing.....");
            string data = await FetchDataAsync();
            return data;
        }
    }
}
