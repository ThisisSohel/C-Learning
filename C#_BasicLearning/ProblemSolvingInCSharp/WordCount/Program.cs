namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World Tim Tim";
            WordCount(str);
        }

        public static void WordCount(string str)
        {
            int wordCount = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
                {
                    wordCount++;
                }
            }
            Console.WriteLine(wordCount);
        }
    }
}
