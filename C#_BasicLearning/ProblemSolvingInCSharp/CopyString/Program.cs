namespace CopyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello gdfjhs jshfgj sd";
            string[] str2 = new string[str1.Length];
            int count = 0;

            for (int i = 0; i < str1.Length; i++)
            {

                str2[i] = str1[i].ToString();
                count++;
            }
            
            for (int i = 0;i < str2.Length; i++)
            {
                Console.WriteLine(str2[i]);
            }
            Console.WriteLine($"Coppied Caharacter is : {count}");
        }
    }
}
