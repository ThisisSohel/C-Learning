namespace UniqueArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5};

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = i+1; j < ints.Length; j++)
                {
                    if (ints[i] == ints[j])
                    {
                        Console.WriteLine("Not an unique array!");
                        return;
                    }
                }
            }
            Console.WriteLine("Unique array");
        }
    }
}
