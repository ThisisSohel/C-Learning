//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Runtime.InteropServices;

namespace ProjectEntryPoint
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Rakib";

            RefChange(student);
            Console.WriteLine(student.Name);

            int age = 20;
            ValueChange(age);
            Console.WriteLine(age);



        }
        static void RefChange(Student s)  //Student s = student; ---> s.Name = "Hi"
        {
            s.Name = "Hi";
        }

        static void ValueChange(int s)  
        {
            s = 2000;
        }

    }
}