namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());

            Console.WriteLine("");

            Fruit fruit1 = new Apple();
            Console.WriteLine(fruit1.GetColor());
        }
    }
}
