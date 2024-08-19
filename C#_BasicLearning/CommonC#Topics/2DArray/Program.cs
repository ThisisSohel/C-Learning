namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 2] ;
            int[,] arr2 = new int[2, 2] ;

            Console.WriteLine("Enter inputs in the first array:");
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter inputs in the second array:");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.WriteLine(arr1[i, j] * arr2[i, j]);
                }
            }
        }
    }
}
