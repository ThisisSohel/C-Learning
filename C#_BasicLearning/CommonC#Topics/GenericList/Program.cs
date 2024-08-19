namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TypeChecker(1.1);
            //TypeChecker("Hello");

            ButterList<int> list = new ButterList<int>();
            list.AddToList(1);

            ButterList<string> butterList = new ButterList<string>();
            butterList.AddToList("Hello");

            SampleClass<PersonModel> sampleClass = new SampleClass<PersonModel>();

            MathOperations<int> intMath = new();
            Console.WriteLine(intMath.Add(1, 4));

            MathOperations<double> doubleMath = new();
            Console.WriteLine(doubleMath.Add(2.2, 3.4));

          
        }

        public static void TypeChecker<T> (T data)
        {
            Console.WriteLine("Type: " + data.GetType());
            Console.WriteLine("Value: " + data);
        }

        public class PersonModel
        {
            public string Name { get; set; }
            public int Id { get; set; }

            public PersonModel()
            {

            }
            public PersonModel(int id)
            {
                Id = id;
            }
        }
    }
}
