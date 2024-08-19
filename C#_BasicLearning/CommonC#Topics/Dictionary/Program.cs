namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dList = new Dictionary<int, string>();

            dList.Add(1, "A");
            dList.Add(2, "B");

            foreach (var d in dList)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }

            for (int i = 0; i < dList.Count; i++)
            {
                Console.WriteLine("Key = {0} and Value = {1}", dList.ElementAt(i).Key , dList.ElementAt(i).Value);
            }
        }
    }
}
