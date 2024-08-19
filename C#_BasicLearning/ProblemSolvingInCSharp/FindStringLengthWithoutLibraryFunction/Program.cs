namespace FindStringLengthWithoutLibraryFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            str = str + '\0';
            int length = 0;
            while(str[length] != '\0')
            {
                length++;
            }
            Console.WriteLine(length);
        }
    }
}
