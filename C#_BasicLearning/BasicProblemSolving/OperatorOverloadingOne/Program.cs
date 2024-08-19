namespace OperatorOverloadingOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperatorOverloading sum = new OperatorOverloading();
            sum.number = 10;
            sum.str = "hello ";

            sum++;
            Console.WriteLine(sum.number);

            OperatorOverloading sum1 = new OperatorOverloading();
            sum1.number = 5;
            sum1.str = "hey";

            OperatorOverloading sum2 = new OperatorOverloading();
            sum2 = sum1 + sum;

            Console.WriteLine(sum2.number + " " + sum2.str);
        }

        public class OperatorOverloading
        {
            public int number;
            public string str;

            public static OperatorOverloading operator + (OperatorOverloading op1 , OperatorOverloading op2)
            {
                OperatorOverloading op = new OperatorOverloading();
                op.number = op1.number + op2.number;
                op.str = op1.str + op2.str;
                return op;
            }

            public static OperatorOverloading operator ++(OperatorOverloading op1)
            {
                OperatorOverloading op = new OperatorOverloading();
                op.number = ++op1.number;
                return op;
            }
        }
    }
}
