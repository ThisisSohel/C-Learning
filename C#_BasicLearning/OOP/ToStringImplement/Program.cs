namespace ToStringImplement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Sohel",
                Age = 1,
            };
            Console.WriteLine(person);
        }
    }
}
