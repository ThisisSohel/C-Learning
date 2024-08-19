namespace ListLinqQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Rakib",
                City = "Dhaka"
            };

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Rakib Hasan",
                City = "Rajshahi"
            };

            Customer customer3 = new Customer()
            {
                Id = 1,
                Name = "Joe",
                City = "Los Angles"
            };

            Customer customer4 = new Customer()
            {
                Id = 2,
                Name = "Tanvir Jaber",
                City = "Rajshahi"
            };


            List<Customer> cList = new List<Customer>();
            cList.Add(customer1);
            cList.Add(customer2);
            cList.Add(customer3);
            cList.Add(customer4);
            cList.AddRange(cList);

            var city = from c in cList 
                       where c.City == "Rajshahi"
                       select new
                       {
                           Name = c.Name,
                           City = c.City
                       };
            var cityList = cList.Where(c => c.City == "Rajshahi");

            foreach(var c in cityList)
            {
                Console.WriteLine(c.Name + " " + c.Id + " " + c.City);
            }
            foreach (var customer in city)
            {
                Console.WriteLine(customer.Name + " " + customer.City );
            }

            string[] names = { "Hansel", "Gretel", "Helga", "Gus" };
            var nameQuery = from n in names
                            where n.Contains("a")
                            select n;
            foreach (var name in nameQuery)
            {
                Console.WriteLine(name);
            }

            var nameQuery1 = names.Where(C => C.StartsWith("H"));

            foreach (var name in nameQuery1)
            {
                Console.WriteLine(name);
            }

            string[] trees = { "Elm", "Banyon", "Rubber" };

            var tree = from n in trees
                       select n.ToUpper();

            foreach(var t in tree)
            {
                Console.WriteLine(t);
            }

            var disCity = cList.Select(c => c.City).Distinct();

            foreach(var d in disCity)
            {
                Console.WriteLine(d);
            }

            int[] scores = [90, 71, 82, 93, 75, 82];

            var score = from s in scores
                        where s is < 80 and > 71
                        orderby s descending
                        select s;
            foreach (var c  in score)
            {
                Console.WriteLine(c);
            }
        }
    }
}
