namespace Ternary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;

            //var result = x > y ? "X is greater" : "Y is greater";
            //Console.WriteLine(result);

            int x = 200;
            string str = Convert.ToString(x);
            Console.WriteLine(str);

            bool b = true;
            string strBool = Convert.ToString(b);
            Console.WriteLine(strBool);
            char c = 'a';
            int xInt = Convert.ToInt32(c);
            Console.WriteLine(xInt);

            string str10 = "Hi";
            string str11 = "Hello";

            string greetings = string.Concat(str10, str11);
            Console.WriteLine(greetings);

            for (int i = 0; i < greetings.Length; i++)
            {
                Console.WriteLine(greetings[i]);
            }


            string strNumber = "1,2,3";

            Stack<int> stack = new Stack<int>();
            string[] charArray = strNumber.Split(',');

            for (int i = 0;i < charArray.Length; i++)
            {
                stack.Push(Convert.ToInt32(charArray[i]));
            }

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
