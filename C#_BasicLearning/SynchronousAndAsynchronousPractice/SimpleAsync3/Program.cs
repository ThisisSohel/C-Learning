using System.Threading.Tasks;

namespace SimpleAsync3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Calculation calc = new Calculation();

           
            Console.WriteLine("Summation staring....");
            var sum = calc.Summation(2, 4);



            Console.WriteLine("Subtraction staring....");
            var sub = calc.Subtraction(2, 4);


            Console.WriteLine("Multiplication staring....");
            var mul = calc.Multiplication(2, 4);


            Task.WaitAll(sum, sub, mul);
            Console.WriteLine($"Summation result is: {sum.Result}");
            Console.WriteLine($"Subtraction result is: {sub.Result}");
            Console.WriteLine($"Multiplication result is: {mul.Result}");
        }
    }
}
