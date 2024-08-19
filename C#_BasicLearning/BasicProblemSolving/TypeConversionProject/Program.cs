using System.Timers;

namespace TypeConversionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (double.TryParse(input, out var result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Your inputed value is not a number!");
            }

            //    int[] nums;
            //    nums = new int[] { 1, 2, 3, 4, 5, };

            //    int[] nums2 = new int[3] { 1, 2, 3};
            //    var xArray = new int[4] {1, 2, 3, 4};

            //    int[] evenNum = { 1, 2, 3 };

            //    int[,] oddNum = new int[3, 2];


            //    for(int i = 0; i<3; i++)
            //    {
            //        for(int j = 0; j<2; j++)
            //        {
            //            var input = Console.ReadLine();
            //            if(int.TryParse(input, out var result))
            //            {
            //                oddNum[i,j] = result;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Not a number!");
            //            }
            //        }
            //    }
            //    for (int i = 0; i < 3; i++)
            //    {
            //        for (int j = 0; j < 2; j++)
            //        {
            //            Console.Write(oddNum[i, j] + " ");
            //        }
            //        Console.WriteLine("\n");
            //    }
            //}
        }
}
