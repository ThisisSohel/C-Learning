using System;
using System.IO;

namespace ExecptionAndExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:Users\User\Desktop1\myFIle8.txt");
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
