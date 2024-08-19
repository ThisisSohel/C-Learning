namespace BasicProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if(float.TryParse(input, out var result))
            {
                var cInput = Convert.ToSingle(input);  // Float
                Console.WriteLine(cInput.GetType());
                int x = 10;
                Console.WriteLine(x.GetType());
                cInput++;
                Console.WriteLine(cInput+x);

                int num = 10;
                float num1 = 30;

                int sum = num + (int)num1;
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Not a number");
            }

        }
    }
}
