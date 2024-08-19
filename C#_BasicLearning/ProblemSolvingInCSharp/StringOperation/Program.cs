namespace StringOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "Hello World:dh;ds\nsdjh\tdgsj";
            //string[] strings = str.Split(' ', ':', ';', '\n', '\t');

            //for (int i = 0; i < strings.Length; i++)
            //{
            //    Console.WriteLine(strings[i]);
            //}

            //string subString = "Hello Bd";
            //int x = subString.LastIndexOf('l');
            //Console.WriteLine(x);
            //string sub = subString.Substring(0, 4);
            //Console.WriteLine(sub);

            string strTrim = "gdfsd634 sdgjfd f455 *%*";
            string[] strArray = { "dh", "gdjs", "fdghfd" };

            Console.WriteLine(strTrim.Trim(' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '%'));
            Console.WriteLine(strTrim.Remove(1, 4));

            Console.WriteLine(string.Join("*", strArray));

            string strRep = "HdgH";
            Console.WriteLine(strRep.Replace('H', 'e'));

            string strLeftPad = "Good";
            Console.WriteLine(strLeftPad.PadLeft(10, '*'));

            string strChar = "Hello";

            char[] strChars = strChar.ToCharArray();

            for (int i = 0; i < strChars.Length; i++)
            {
                Console.WriteLine(strChars[i]);
            }

            char ch = '\0';
            Console.WriteLine(ch);

            string date = String.Format("Today's date is {0}", DateTime.Now);
            Console.WriteLine(date);
        }
    }
}
