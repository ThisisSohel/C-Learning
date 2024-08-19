using System.Collections.Generic;

namespace ValueAndRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "xyz";
            person.PersonInfo();

            Person person1 = new Person();
            person1 = person;
            person1.Name = "Hello";
            person.PersonInfo();

            int x = 10;
            int y = x;
            y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);

            int a = 100;
            int b = 200;
            Method(ref a, ref b);

            var result = x > y ? "X is greater that x" : "Y is greater than x";
            Console.WriteLine(result);

            int[] arr = new int[10] { 1, 2, 3,4 ,5 ,6 ,7 ,8 , 12, 12};

            decimal dec = 12;
            float fol = 12;

            Dictionary<int , int> map = new Dictionary<int , int>();


            int[,] ints = new int[2, 2]; 

            string s1 = "Hello";
            string s2 = "Hello";

            string s3 = string.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.WriteLine(s1.Contains("Hell"));

            if(int.TryParse("Hello", out var result1))
            {
                Console.WriteLine(result1);
            }

            var en = new Encap1();
            en.PersonName = "Jhoe";
            en.PersonAddress = "Biden";
            en.FullInfo();

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public static void Method(ref int x, ref int y)
        {

            y = x;
            y = 10;
            Console.WriteLine(x);
        }

        public abstract class Person1
        {
            public Person1()
            {
                
            }

            protected Person1(int x)
            {
                
            }
            public abstract void Method();
        }

        public sealed class SealedClass : Person1
        {
            public SealedClass()
            {
                
            }
            public SealedClass(int x)
            {
                
            }

            public static void sta()
            {

            }
            public override void Method()
            {
                throw new NotImplementedException();
            }
        }

        public struct Struct
        {
            public Struct()
            {

            }

            public Struct(int x)
            {
                
            }
        }

        public interface IInterface
        {
            void Method();
        }

        public class Encap
        {
            private string Name { get; set; }
            private string Address { get; set; }

            public string PersonName
            {
                get { return Name; }
                set { Name = value; }
            }

            public string PersonAddress
            {
                get { return Address; }
                set { Address = value; }
            }

            public void FullInfo()
            {
                Console.WriteLine($"Name = {PersonName} Address = {PersonAddress}");
            }
        }

        public class Encap1 : Encap
        {

        }

        public class GenericClass<T> where T : class, IEnumerable<T>
        {
            public T Data { get; set; }
            public void Gmethod<T>()
            {
                Console.WriteLine("G Method!");
            }
        }
    }
}
