namespace StringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Rakib", "Rahat", "Sakib" };

            var result = Array.FindAll(arr, ar => ar.StartsWith('R'));

            for ( int i = 0; i < result.Length; i++ )
            {
                Console.WriteLine(result[i]);
            }

            int bSearch = Array.BinarySearch(arr, "sdgfhds");
            if ( bSearch.ToString() == "-")
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Console.WriteLine(bSearch);
            }

            string[] planets = { "Mercury", "Menus",
                "Earth", "Mars", "Jupiter",
                "Saturn", "Sranus", "Neptune" };

            Console.WriteLine(Array.Exists(planets, p => p.StartsWith("S")));
            var planets2 = Array.Exists(planets, p => p.StartsWith("X"));

            if(planets2)
            {
                Console.WriteLine("Value found!");
            }
            else
            {
                Console.WriteLine("Value not found!");
            }

            int x = Array.IndexOf(planets, "Neptune", 0, 8);

            if(x == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine(x);
            }

            var source = new[] { "Ally", "Bishop", "Billy" };
            var target = (string[])source.Clone();

            var intNum = new[] { 1, 2, 3 };
            var intNumTarget = (int[])intNum.Clone();
        }
    }
}
