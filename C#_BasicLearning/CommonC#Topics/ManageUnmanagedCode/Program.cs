namespace ManageUnmanagedCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                unsafe
                {
                    int iData = 10;
                    int* pData = &iData;
                    Console.WriteLine("Data: " + iData);
                    Console.WriteLine("Address: " + (int)pData);
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error");
            }
        }
    }
}
