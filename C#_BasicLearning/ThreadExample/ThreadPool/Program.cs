
using System.Threading;

    internal class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(0, 1000).ToList().ForEach(f =>
            {
                ThreadPool.QueueUserWorkItem((ob) =>
                {
                    Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} has started!");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} has ended!");
                });

            });
            Console.ReadKey();
        }
    }

