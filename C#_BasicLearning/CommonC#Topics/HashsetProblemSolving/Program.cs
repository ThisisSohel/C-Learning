namespace HashsetProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            set.Add(1);
            set.Add(2);
            set.Add(3);

            set.RemoveWhere(x => set.Contains(x));
            set.Add(1);
        }
    }
}
