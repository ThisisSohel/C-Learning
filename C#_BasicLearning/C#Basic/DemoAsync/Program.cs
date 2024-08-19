namespace DemoAsync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Start B");
            //var s = B();
            //Console.WriteLine("Start C");
            //var s1 = C();

            //Task.WaitAll(s, s1);
            Thread thread1 = new Thread(new ThreadStart(Function1));
            Thread thread2 = new Thread(new ThreadStart(Function2));
            thread1.Start();
            thread2.Start();
            //MyAsyncFunction();

        }

        //public static async Task B()
        //{

        //    await Task.Delay(5000);

        //    Console.WriteLine("Finish B");
        //}

        //public static async Task C()
        //{
        //    await Task.Delay(3000);

        //    Console.WriteLine("Finish C");

        //}

        static void Function1()
        {
            Console.WriteLine("Task started! fun1");

            Task.Delay(2000);
            Console.WriteLine("Task Done! fun1");
        }
        static void Function2()
        {
            Console.WriteLine("Task started! fun2");

            Task.Delay(7000);
            Console.WriteLine("Task Done! fun2");

        }

        //static async Task MyAsyncFunction()
        //{
        //    await Task.Run(() => Function1());
        //    await Task.Run(() => Function2());
        //}

    }
}
