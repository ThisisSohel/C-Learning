using System.Threading;

namespace ThreadExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                Console.WriteLine("S1");
                Thread.Sleep(4000);
                Console.WriteLine($"Thread-1 and Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            }).Start();

            new Thread(() =>
            {
                Console.WriteLine("S2");
                Thread.Sleep(9000);
                Console.WriteLine($"Thread-2 and Thread Id: {Thread.CurrentThread.ManagedThreadId}");

            }).Start();

            new Thread(() =>
            {
                Console.WriteLine("S3");
                Thread.Sleep(TimeSpan.FromDays(30));

                Console.WriteLine($"Thread-3 and Thread Id: {Thread.CurrentThread.ManagedThreadId}");

            }).Start();

            new Thread(() =>
            {
                Console.WriteLine("S4");
                Thread.Sleep(1000);
                Console.WriteLine($"Thread-4 and Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            }).Start();

            //ThreadPool.QueueUserWorkItem((obj) =>
            //{
            //    Console.WriteLine("Started TP1");
            //    Thread.Sleep(1);
            //    Console.WriteLine("Ended TP1");
            //});

            //ThreadPool.QueueUserWorkItem((obj) =>
            //{
            //    Console.WriteLine("Started TP2");
            //    Thread.Sleep(1);
            //    Console.WriteLine("Ended TP2");
            //});

            //ThreadPool.QueueUserWorkItem((obj) =>
            //{
            //    Console.WriteLine("Started TP2");
            //    Thread.Sleep(1);
            //    Console.WriteLine("Ended TP2");
            //});

            //ThreadPool.QueueUserWorkItem((obj) =>
            //{
            //    Console.WriteLine("Started TP2");
            //    Thread.Sleep(1);
            //    Console.WriteLine("Ended TP2");
            //});

            //Console.ReadKey();
            //var t1 = Task.Run(() =>
            //{
            //    Thread.Sleep(4000);
            //    Console.WriteLine("Run 1");

            //});

            //var t2 = Task.Run(() =>
            //{
            //    for (int i = 0; i < 2000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("Run 2");

            //});

            //var t3 = Task.Run(() =>
            //{
            //    Thread.Sleep(7000);
            //    Console.WriteLine("Run 3");
            //});

            //var t4 = Task.Run(() =>
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine("Run 4");
            //});

            //Task.WaitAll(t1, t2, t3, t4);

        }
    }
}
