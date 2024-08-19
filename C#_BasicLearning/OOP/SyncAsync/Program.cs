namespace SyncAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("process start...");
            await Sum(3, 6);
            Console.WriteLine("Process End");

            var t1 = Task1();
            var t2 = Task2();
            var t3 = Task3();
            Task.WaitAll(t1, t2, t3);
        }

        public static async Task Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task1 is Started!....");
                Thread.Sleep(2000);
                Console.WriteLine("Task1 is Ended!");
            });
        }

        public static async Task Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task2 is Started!....");
                Thread.Sleep(1000);
                Console.WriteLine("Task2 is Ended!");
            });
        }

        public static async Task Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task3 is Started!....");
                Thread.Sleep(5000);
                Console.WriteLine("Task3 is Ended!");
            });
        }

        public static async Task Sum(int a, int b)
        {
            Console.WriteLine("Before Delay...");
            await Task.Delay(3000);
            Console.WriteLine("process done(Sum)!!");
        }
    }
}
