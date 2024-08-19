namespace ArraySumOfGivenTargetValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 20, 15, 10, 30, 5, 6 };
            Console.WriteLine("Enter target value: ");
            int terget = int.Parse(Console.ReadLine());
            int fIndex = 0;
            int lIndex = 0;

            TwoSum(arr, terget, out fIndex, out lIndex);
            Console.WriteLine($"Terget sum found! and their index is {fIndex} and {lIndex}");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] + arr[j] == terget)
                    {
                        Console.WriteLine($"Terget sum found! and their index is {i} and {j}");
                        return;
                    }
                }
            }
            Console.WriteLine("Terget sum not Found!");
        }

        public static void TwoSum (int[] arr , int terget, out int fIndex, out int lIndex)
        {
            fIndex = 0;
            lIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == terget)
                    {
                        fIndex = i;
                        lIndex = j;
                        return;
                    }
                }
            }
            Console.WriteLine("Terget sum not Found!");
        }
    }
}
