using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAsync3
{
    public class Calculation
    {
        public async Task<int> Summation(int a, int b)
        {
            int sum = 0;
            try
            {
                Console.WriteLine("Sum calculating........");
                await Task.Delay(5000);
                sum = a + b;    
                Console.WriteLine("Summation done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return sum;
        }

        public async Task<int> Subtraction(int a, int b)
        {
            int subtraction = 0;
            try
            {
                Console.WriteLine("Sub calculating........");
                await Task.Delay(6000);
                subtraction = a - b;
                Console.WriteLine("Subtraction done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return subtraction;
        }

        public async Task<int> Multiplication(int a, int b)
        {
            int multiplication = 0;
            try
            {
                Console.WriteLine("Multiplication calculating........");
                await Task.Delay(2000);
                multiplication = a * b;
                Console.WriteLine("Multiplication done! ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return multiplication;
        }
    }
}
