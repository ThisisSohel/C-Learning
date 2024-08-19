namespace BackGroundThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(BackGroundThread);
            th.Start();

            th.IsBackground = true;
            Console.WriteLine("Main Thread Ends...");
        }

        static void BackGroundThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread is running...........");
                Thread.Sleep(2000);
            }
            Console.WriteLine("Thread ends!!");
        }
    }
}
