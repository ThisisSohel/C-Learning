namespace OddNumberOccure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10 };
            int count = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i]%2 != 0) 
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of odd number occurance is: {count}");
        }
    }
}
