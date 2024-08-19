namespace StringSimpleProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'A', 'B', 'C' };
            Console.WriteLine(chars);

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }

            string str = "Hello";

            char[] ch = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                ch[i] = str[i];
            }
            Console.WriteLine(ch);
        }
    }
}
