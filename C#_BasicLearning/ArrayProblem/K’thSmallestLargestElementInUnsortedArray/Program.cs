namespace K_thSmallestLargestElementInUnsortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[10];
            int k;
            Console.WriteLine("Enter K'th number: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Array Number");

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The K'th element is : " + FindNumber(arr, k));
        }

        public static int FindNumber(int[] arr, int k)
        {
            int temp = 0;

            for (int i = 0;i < 6 ;i++)
            {
                for (int j = i+1; j < 6 ;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr[k - 1];
        }
    }
}
