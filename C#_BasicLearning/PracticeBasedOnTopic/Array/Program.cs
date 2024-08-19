

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //StoreInArray storeInArray = new StoreInArray();
            //storeInArray.ArrayPrint();
            //ArrayReverse arrayReverse = new ArrayReverse();
            //arrayReverse.ArrayReaversePrint();
            //ArraySum arraySum = new ArraySum();
            //arraySum.ArraySumPrint();
            //ArrayCopy arrayCopy = new ArrayCopy();
            //arrayCopy.ArrayCopyToArray();
            //DuplicateArray duplicateArray = new DuplicateArray();
            //duplicateArray.DupliacateFind();

            int[] arr = { 1, 2, 3, 4, 5, };
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 1;

            int[] arr2 = arr.Distinct().ToArray();
            var a = new List<int>();
            a.Add(1);
            a.Add(2);
            Console.WriteLine(a.Remove(2));

        }
    }
}
