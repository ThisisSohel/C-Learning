namespace ClassObject
{
    internal class Program
    {
        static class A
        {
            public static int id;

            public static void ValueType()
            {
                id = 1;
                Console.WriteLine(id);
                int x = id;
                x = 200;
                Console.WriteLine(id);

            }

        }
        static void Main(string[] args)
        {
            A.id = 1;
            Console.WriteLine(A.id);

            A.a2 = a;
            a2.id = 2;
            Console.WriteLine(a.id);

            A.ValueType();
        }
    }
}
