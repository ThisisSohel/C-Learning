namespace RefValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x);

            PNumber(ref x);
            Console.WriteLine(x);

            //Console.WriteLine((int)WeekDays.Wednesday);
            foreach(var en in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine((int)en + " " + en);
            }

            foreach(var en in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(en);
            }

            int xCompare = 10;
            int yCompare = 20;

            var comResult = xCompare > yCompare ? "X greater than" : "Y greater than";
        }

        public static void PNumber(ref int xRef)
        {
            xRef++;
            Console.WriteLine(xRef);
        }

        enum WeekDays
        {
            Monday = 20,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
