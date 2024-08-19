
using MethodOverloading.cs;

public class Program
{
    public static void Main()
    {
        Add(1, 2);
        Add(2, 3, 2);
        Add(3.3, 4, 3);
        Interest interest = new Interest();
        Console.WriteLine(interest.ABCBank(23.1, 343));
        Console.WriteLine(interest.ABCBank(23, 343));
        Console.WriteLine(interest.ABCBank(23.2, 343.3, 5));
    }

    public static void Add(int FN, int SN)
    {
        Console.Out.WriteLine("Sum =  {0}", FN + SN);
    }
    public static void Add(int FN, int SN, int TN)
    {
        Console.Out.WriteLine("Sum =  {0}", FN + SN);
    }
    public static void Add(double FN, int SN, int TN)
    {
        Console.Out.WriteLine("Sum =  {0}", FN + SN);
    }
}



