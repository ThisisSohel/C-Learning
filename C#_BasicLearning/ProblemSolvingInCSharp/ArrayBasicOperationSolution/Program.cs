using System.Text;

namespace ArrayBasicOperationSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] cars = new string[3] { "BMW", "AUDI" , "Nisan"};
            //int[] ints = new int[] { 10, 2, 3, 15, 20, 15 };
            //Console.WriteLine(Array.Exists(cars, carFind => carFind.StartsWith("B")));
            //Array.Clear(ints, 0, 2);
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}
            ////Console.WriteLine("The last index of 15 is = " + Array.IndexOf(ints,15));
            ////Console.WriteLine("The binary search of 15 is = " + Array.BinarySearch(ints,2, 4, 75));

            //Array.Sort(ints);
            //Console.WriteLine("Max Number: " + ints.Max());
            //Console.WriteLine("Min Number: " + ints.Min());
            //Console.WriteLine("Sum Numbers: " + ints.Sum());



            //int[,] twoDimension = { { 1, 2, 3 }, { 4, 7, 8 }, { 10, 20, 30 } };
            //Console.WriteLine(twoDimension.Length);

            //for (int i = 0; i < twoDimension.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twoDimension.GetLength(1); j++)
            //    {
            //        Console.WriteLine(twoDimension[i,j]);
            //    }
            //}

            //Console.WriteLine(twoDimension[0,1]);

            //System.String str = "Hi";
            //Console.WriteLine(str);
            //string str1 = "Hi";
            //Console.WriteLine(str1);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello!");
            stringBuilder.AppendLine("World");
            StringBuilder stringBuilder2 = new StringBuilder();
            stringBuilder2 = stringBuilder;
            stringBuilder2.Append("Bangladesh");
            string strRetrieve = stringBuilder2.ToString();
            Console.WriteLine(stringBuilder2.Length);
            Console.WriteLine(stringBuilder);

            for (int i = 0; i < stringBuilder2.Length; i++)
            {
                Console.WriteLine(stringBuilder2[i]);
            }
        }
    }
}
