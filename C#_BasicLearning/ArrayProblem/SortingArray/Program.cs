namespace SortingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 10, 4, 6, 8, 7 };
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
