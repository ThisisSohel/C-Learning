namespace MoveAllNegativeNumbersToBeginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { -1, 2, -3, 4, 5, 6, -7, 8, 9 };
            var arr = new int[10];

            Console.WriteLine("Enter array element: ");
            for (int i = 0; i < 9; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            SortMethod(arr);
        }

        public static void SortMethod(int [] arr)
        {
            Array.Sort(arr);

            for (int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
