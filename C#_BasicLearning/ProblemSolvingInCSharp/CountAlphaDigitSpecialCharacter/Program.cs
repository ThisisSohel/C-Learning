namespace CountAlphaDigitSpecialCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "fdgjajds*hgdf%42";
            int alphaCount = 0;
            int digitCount = 0;
            int speChaCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= 'a' && str[i] <='z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphaCount++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digitCount++;
                }
                else
                {
                    speChaCount++;
                }
            }
            Console.WriteLine("Alpha - " + alphaCount);
            Console.WriteLine("Digit - " + digitCount);
            Console.WriteLine("SpecialCharacter - " + speChaCount);
        }
    }
}
