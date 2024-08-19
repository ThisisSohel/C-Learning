namespace PalindromCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "madam";
            string strReverse = "";

            for (int i = str.Length-1; i >= 0 ; i--)
            {
                strReverse += str[i].ToString();
            }
            if(strReverse == str)
            {
                Console.WriteLine("String is Palindrom");
            }
            else
            {
                Console.WriteLine("Not Palindrom!");
            }
        }
    }
}
