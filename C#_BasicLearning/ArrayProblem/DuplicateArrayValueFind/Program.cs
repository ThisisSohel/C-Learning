namespace DuplicateArrayValueFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 7, 8, 4, 6, 4,  6 };

            Dictionary<int, int> duArray = new Dictionary<int, int>();

            
            foreach(var du in arr)
            {
                if (duArray.ContainsKey(du))
                {
                    duArray[du]++;
                    duArray[du] = duArray[du] + 1;
                }
                else
                {
                    duArray[du] = 1;
                    /*
                      duArray.key = 3
                      duArray.Value = 1

                      duArray[du] = 1
                     */
                    duArray.Add(du, 1);

                }
            }
            foreach(var du in duArray)
            {
                if (du.Value > 1)
                {
                    Console.WriteLine(du.Key + " " + du.Value);
                }     
            }
        }
    }
}
