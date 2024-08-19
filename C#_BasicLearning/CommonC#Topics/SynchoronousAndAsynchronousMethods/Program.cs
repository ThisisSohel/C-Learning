using System;
using System.IO;
using System.Threading.Tasks;

namespace SynchoronousAndAsynchronousMethods
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var t1 = Task1();
            var t2 = Task2();
            var t3 = Task3();
            var t4 = Task4();

            Task.WaitAll(t1, t2, t3, t4);

            //await Task.WhenAll(Task1, Task2, Task3, Task4);
            //Console.WriteLine();
            //Task<int> task = PrintInfo();
            
            //Console.WriteLine(task.Result);
        }

        public static async Task Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 1 is starting...");
                Thread.Sleep(4000);
                Console.WriteLine("Task 1 is completed");
            });
        }

        public static async Task Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 is starting...");
                Thread.Sleep(1000);
                Console.WriteLine("Task 2 is completed");
            });
        }

        public static async Task Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 is starting...");
                Thread.Sleep(2000);
                Console.WriteLine("Task 3 is completed");
            });
        }

        public static async Task Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 4 is starting...");
                Thread.Sleep(6000);
                Console.WriteLine("Task 4 is completed");
            });
        }

        public static async Task<int> PrintInfo()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"{i}");
            }
            await Task.Delay(5000);
            Console.WriteLine("Hi");
            return 1;
        }
    }
}
