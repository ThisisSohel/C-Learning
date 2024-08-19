namespace StringAscendingOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter a string");
            str = Console.ReadLine();

            char [] chars;
            chars = str.ToCharArray(0, str.Length);

            char ch;

            for (int i = 0; i< chars.Length; i++)
            {
                for (int j = i +1 ; j < chars.Length; j++)
                {
                    if (chars[i] > chars[j])
                    {
                        ch = chars[j];
                        chars[j] = chars[j];
                        chars[j] = ch;
                    }
                }
            }

            foreach (char c in chars)
            {
                ch = c;
                Console.WriteLine(ch);
            }
        }
    }
}
