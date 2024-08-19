

using Interface.cs;

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle(243.2);
        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine("V Area: "+ circle.CalculateVArea());
        Demo demo = new Demo();
        demo.FirstMethod();
        demo.SecondMethod();
    }
}
