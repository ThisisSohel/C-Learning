namespace Peaksmallerthanitsneighbours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 15, 2, 23, 90, 67 };
            int leftValue;
            int rightValue;

            for (int i = 1; i < arr.Length-1; i++)
            {
                leftValue = arr[i -1];
                rightValue = arr[i + 1];
                if (arr[i] > leftValue && arr[i] > rightValue)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
