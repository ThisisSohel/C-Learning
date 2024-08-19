namespace MultipleThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enumerable.Range(0, 1000).ToList().ForEach(f =>
               new Thread(() =>
               {
                   Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} has started!");
                   Thread.Sleep(8000);
                   Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} has ended!");
               }).Start()
            );

            //Enumerable.Range(0, 10).ToList().ForEach(f =>
            //   Task.Run(() =>
            //   {
            //       Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} has started!");
            //       Thread.Sleep(8000);
            //       Console.WriteLine($"Thread number {Thread.CurrentThread.ManagedThreadId} has ended!");
            //   })
            //); 
        }
    }
}
