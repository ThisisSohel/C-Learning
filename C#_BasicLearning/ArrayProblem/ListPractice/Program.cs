namespace ListPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");

            dinosaurs.InsertRange(1, dinosaurs);

            foreach (var d in dinosaurs)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("-----------");
            List<string >findAll = dinosaurs.FindAll(p => p.StartsWith("T"));
            foreach (var d in findAll)
            {
                Console.WriteLine(d);
            }

            if(dinosaurs.Exists(p => p.EndsWith("u")))
            {
                dinosaurs.RemoveAll(p => p.EndsWith("u"));
            }
            else
            {
                Console.WriteLine("False");
            }
            var index = dinosaurs.FindLastIndex(p => p.StartsWith("T"));
            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Not found!");
            }

        }
    }
}
