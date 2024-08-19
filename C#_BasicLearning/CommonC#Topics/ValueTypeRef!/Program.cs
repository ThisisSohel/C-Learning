


using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {

        int x = 10;
        NumberChange(ref x);
        Console.WriteLine("Outside the Method: " + x);
        void NumberChange(ref int b)
        {
            b++;
            Console.WriteLine("Inside the Method: "+ b);
        }
    }
}