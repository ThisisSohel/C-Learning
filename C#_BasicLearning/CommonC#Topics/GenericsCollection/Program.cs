namespace GenericsCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[] { "Bd", "UK" };

            List<string> list = new List<string>(array);

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
