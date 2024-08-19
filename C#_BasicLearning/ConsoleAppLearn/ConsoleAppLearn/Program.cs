
using System;
using ClassLibraryStandard;
using ConsoleAppLearn.Data;
using ConsoleAppLearn.Models;
using Alias = Hi.Sohel.Data;

namespace ConsoleAppLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your firstname: ");
            //string? firstName = Console.ReadLine();

            //Console.WriteLine("Enter your secondname: ");
            //string? secondName = Console.ReadLine();

            //string fullName = PersonProcessor.JoinName(firstName, secondName);

            //Console.WriteLine($"Your full name is: {fullName}");

            Alias.DataAccess dataAccess = new ();
            Models.PersonModel personModel = new Models.PersonModel();
            Data.PersonModel personModel2 = new Data.PersonModel();

            System.MyConsole console = new System.MyConsole();
            console.MyConsoleMethod();
            ConsoleAppLearn.Data.Nested.NestedData nestedNameSpace = new Data.Nested.NestedData();
            nestedNameSpace.NestedMethod();
        }
    }
}


