namespace FoundMejorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] ints = { 1, 2, 3, 2, 10, 2, 2, 3 };
            int count = 0;
            int findMax = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = i+1; j < ints.Length; j++)
                {
                    if (ints[i] == ints[j])
                    {
                        findMax++;
                        count++;
                    }
                    if (findMax < count)
                    {
                        findMax = count;
                    }
                }
            }

        }
    }
}
