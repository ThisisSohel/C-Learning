namespace ThreadPool1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(0, 10).ToList().ForEach(f =>
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} has started!");
                    Thread.Sleep(8000);
                    Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} has ended!");
                });

            });
            Console.ReadKey();
        }
    }
}
