

class Program
{
    public static void Main()
    {
        Program program = new Program();
        int x = Program.MethodPrint(30);
        Console.WriteLine(x);
        int total = 0;
        int product = 0;    
        Calculate(2, 4, out total, out product);
        Console.WriteLine("Total = {0} && Product = {1}", total, product);
    }

    public static int MethodPrint(int number)
    {
        Console.WriteLine("Method Print - " + number);
        return number;
    }

    public static void Calculate(int FN, int SN, out int sum, out int product)
    {
        sum =  FN + SN;
        product = SN * SN;
    }
}
