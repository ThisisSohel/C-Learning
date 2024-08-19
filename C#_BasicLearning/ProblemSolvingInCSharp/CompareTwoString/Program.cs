namespace CompareTwoString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "Hello";

            for(int i = 0; i < str1.Length; i++)
            {
                for(int j = 0 ; j < str2.Length; j++)
                {
                    if (str1[i] != str2[j])
                    {
                        Console.WriteLine("Not Equal");
                        return;
                    }
                }
            }
            Console.WriteLine("Equal");
        }
    }
}
