namespace BasicPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Addition(out number);

            Console.WriteLine(number);

            Stack<int> stackElement = new Stack<int>();
            stackElement.Push(1);
            stackElement.Push(2);
            stackElement.Push(3);
            stackElement.Push(4);
            stackElement.Push(1);


            foreach (int i in stackElement)
            {
                Console.WriteLine(i);
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            foreach(int i in queue)
            {
                Console.WriteLine(i);
            }

            Dictionary<int, string> map = new Dictionary<int, string>();

            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Rakib", "Dhaka");
            DisplayTuple(person);
            Console.WriteLine($"The person Id: {person.Item1}");
            Console.WriteLine($"The person Id: {person.Item2}");
            Console.WriteLine($"The person Id: {person.Item3}");

            var employee = Tuple.Create(1, 2, 3,Tuple.Create(3, 4));
            Console.WriteLine(employee.Item4.Item1);
        }

        public static void Addition(out int number)
        {
            number = 100;
            number++;
        }

        public static void DisplayTuple(Tuple<int, string, string> tuple)
        {
            Console.WriteLine($"Id = {tuple.Item1}");
            Console.WriteLine($"First Name = {tuple.Item2}");
            Console.WriteLine($"Address = {tuple.Item3}");
        }

        public class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
    }
}
