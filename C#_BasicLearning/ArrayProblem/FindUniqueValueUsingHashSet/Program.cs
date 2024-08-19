namespace FindUniqueValueUsingHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 5, 2, 4, 2, 4 };

            HashSet<int> arraySet = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!arraySet.Contains(arr[i]))
                {
                    arraySet.Add(arr[i]);
                    Console.WriteLine(arr[i] + " ");
                }
            }
        }
    }
}
