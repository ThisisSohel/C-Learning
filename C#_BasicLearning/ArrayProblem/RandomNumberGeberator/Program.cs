namespace RandomNumberGeberator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            byte[] bytes = new byte[4];
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(random.NextBytes(bytes));

            }
            Random rnd1 = new Random(10); //seed value 10
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(rnd1.Next());
            }
        }
    }
}
