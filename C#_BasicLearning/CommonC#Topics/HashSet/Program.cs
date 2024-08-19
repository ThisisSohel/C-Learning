namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> ints = new HashSet<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(3);

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
        public class UniversityInfo
        {
            private string Name;

            public string NameSet
            {
                get { return Name; }
                set { Name = value; }
            }
        }
    }
}
