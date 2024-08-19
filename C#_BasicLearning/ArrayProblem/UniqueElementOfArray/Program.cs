namespace UniqueElementOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 4, 6, 7, 4, 7 };

            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int i in arr) 
            {
                if (dic.ContainsKey(i))
                {
                    dic[i]++;
                }
                else
                {
                    dic[i] = 1;
                }
            }

            foreach (var i in dic)
            {
                if(i.Value == 1)
                Console.WriteLine(i.Key);
            }
        }
    }
}
