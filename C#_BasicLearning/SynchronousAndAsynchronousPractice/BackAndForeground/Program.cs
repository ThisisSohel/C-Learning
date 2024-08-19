namespace ForegroundThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread fThread = new Thread(ForeGroundThread);
            fThread.Start();
            Console.WriteLine("Main Thread Ends!");
        }

        static void ForeGroundThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Thread is running...........");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Thread ends!!");
        }
    }
}
