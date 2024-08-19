namespace SimpleAsync4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var task1 = StartSchoolAssembly();
            var task2 = TeachClass12();
            var task3 = TeachClass11();


            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution Time: { watch.ElapsedMilliseconds}ms"); 
        }

        public static async Task StartSchoolAssembly()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                Console.WriteLine("School Started");
            });
        }


        public static async Task TeachClass12()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Taught class 12");
            });


        }

        public static async Task TeachClass11()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("Taught class 11");
            });


        }
    }
}
