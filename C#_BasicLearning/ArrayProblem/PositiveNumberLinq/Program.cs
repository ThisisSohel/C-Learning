namespace PositiveNumberLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, -6, 10, -8, 299 };  
            
            var arr1 = arr.Where( p => p > 0 && p < 12);

            foreach ( var i in arr1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
