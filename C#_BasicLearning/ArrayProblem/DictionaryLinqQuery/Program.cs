namespace DictionaryLinqQuery
{
    internal class Program
    {
        class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Salary { get; set; }
        }
        static void Main(string[] args)
        {

            int[] arr = new int[4] { 1, 2, 3, 4};
            List<Customer> list = new List<Customer>();
            Console.WriteLine(list.Capacity);

            Dictionary<int, int > kp = arr.ToDictionary(C => C, C=>C);
            List<int> listArray = arr.ToList();
            Dictionary<int, int> dicList = listArray.ToDictionary(C => C, C=>C);

            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Rakib",
                Salary = 20000
            };

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Rakib Hasan",
                Salary = 20000
            };

            Customer customer3 = new Customer()
            {
                Id = 3,
                Name = "Sakib",
                Salary = 23500
            };

            Customer customer4 = new Customer()
            {
                Id = 4,
                Name = "Tonmoy",
                Salary = 30000
            };

            Dictionary<int, Customer> customerDlist = new Dictionary<int, Customer>();
            customerDlist.Add(customer1.Id, customer1);
            customerDlist.Add(customer2.Id, customer2);
            customerDlist.Add(customer3.Id, customer3);
            customerDlist.Add(customer4.Id, customer4);

            var salarySorting = from c in customerDlist
                                where (c.Value.Salary >= 20000) && c.Key >= 3
                                select c;

            var dis = customerDlist.Select(c => c.Value.Salary).Distinct();
            Console.WriteLine(dis.Count());

            foreach (var s in dis)
            {
                Console.WriteLine(s);
            }


            foreach (var s in salarySorting)
            {
                Console.WriteLine(s.Value.Id + " " + s.Value.Name + " " + s.Value.Salary);
            }
            if (customerDlist.ContainsKey(customer1.Id))
            {
                customerDlist[customer1.Id].Name = "Sohel";
                customerDlist[customer1.Id].Salary = 100000;
            }else
            {
                Console.WriteLine("User not found!");
            }

            foreach (var cust in customerDlist)
            {
                Console.WriteLine(cust.Value.Id + " " + cust.Value.Name + " " + cust.Value.Salary);
            }
        }
    }
}
