namespace NewProjectDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string strNumber = "12,24,25,123";
            Stack<int> stack = new Stack<int>();
            string[] charArray = strNumber.Split(",");
            /*
              i = 0 ---> stackPush->12;
              i = 1 ---> stackPush->24;
              i = 2 ---> stackPush->25;
              i = 3 ---> stackPush->123;

             */
            for (int i = 0; i < charArray.Length; i++)
            {
                stack.Push(Convert.ToInt32(charArray[i]));
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            //StackMethod(strNumber);
            string str2 = "13," + strNumber;
            /*
             1
             3
             ,
             1
             2
             ,
             2
             4
             ,
             2
             5
             * /
            //Console.WriteLine(str2.Length); //6

            //for (int i = 0; i < str2.Length; i++)
            //{
            //    Console.WriteLine(str2[i]);
            //}

            string str = "Hello"; 
            /*
             H
             e
             l
             l
             0
             */

            //for (int i = 0; i<str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
        }

        public static void StackMethod(string strNumber)
        {
            Stack<int> stack = new Stack<int>();
            int length = strNumber.Length;  //8
            Console.WriteLine(length);
            int stackLength = stack.Count; //0


            //for (int i = 0;i < strNumber.Length; i++) 
            //{
            //    if (strNumber[i] != ',')
            //    {
            //       string  strSum = strSum + strNumber[i];
            //    }
            //}
            if (stackLength <= length) //0<=5
            {
                int strNumberInt = Convert.ToInt32(strNumber);
                int strNumberInt2 = Convert.ToInt32("13,12,24,25");

                stack.Push(strNumberInt); //12
            }

            while (stackLength > 0)
            {
                int individualData = stack.Pop();
                if (individualData == ',')
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(individualData);
                }

            }

        }
    }
}
