namespace DictionaryLinkQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                Name = "Rakib",
                Salary = 10000
            };

            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Rakib Hasan",
                Salary = 10000
            };

            Customer customer3 = new Customer()
            {
                Id = 3,
                Name = "Joe",
                Salary = 15000
            };

            Customer customer4 = new Customer()
            {
                Id = 4,
                Name = "Tanvir Jaber",
                Salary = 12000
            };
            Customer customer5 = new Customer()
            {
                Id = 5,
                Name = "Tanvir Jaber",
                Salary = 13000
            };

            Dictionary<int, Customer> custList = new Dictionary<int, Customer>();
            custList.Add(customer1.Id, customer1);
            custList.Add(customer2.Id, customer2);
            custList.Add(customer3.Id, customer3);
            custList.Add(customer4.Id, customer4);
            custList.Add(customer5.Id, customer5);

            var cust = from c in custList
                       where c.Key == 2 || c.Value == (object)"Tanvir Jaber"
                       select c;

            foreach ( var c in cust)
            {
                Console.WriteLine(c.Value.Name + " " + c.Value.Salary);

            }

            char[] sequence = {'m', 'q', 'o', 's', 'y',
                          'a', 'a', 'c', 'y', 'o'};

            var dis = sequence.Distinct();

        }
    }
}
