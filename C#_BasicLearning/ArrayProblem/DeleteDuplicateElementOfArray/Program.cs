namespace DeleteDuplicateElementOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 6, 7, 4, 7, 8 };

            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (var i in arr)
            {
                if (dic.ContainsKey(i))
                {
                    dic.Remove(i);  
                }
                else
                {
                    dic.Add(i, i);
                }
            }

            foreach (var i in dic)
            {
                Console.WriteLine(i.Key);
            }
        }
    }
}
