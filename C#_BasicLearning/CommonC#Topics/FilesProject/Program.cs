namespace FilesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathName = @"C:\Users\User\Desktop\myFile4.txt";

            string sFile = @"C:\Users\User\Desktop\myFile4.txt";
            string dFile = @"C:\Users\User\Desktop\myFile7.txt";

            File.WriteAllText(pathName, "Hello!World");
            File.Copy(sFile, dFile);
            string readText = File.ReadAllText(pathName);
            string dFileRead = File.ReadAllText(dFile);
            Console.WriteLine(dFileRead);
            Console.WriteLine(readText);

            FileStream fOpen = File.Open(pathName, FileMode.Open);
        }
    }
}
