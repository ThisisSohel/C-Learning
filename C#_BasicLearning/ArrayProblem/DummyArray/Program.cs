namespace DummyArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 3};
            int count = 1;
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        Console.WriteLine(count);
                    }
                }
            }
        }
    }
}
