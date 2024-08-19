namespace ArrayLinqQuery
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
                Salary = 20000
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
 

            Customer[] customers = new Customer[5];
            customers[0] = customer1;
            customers[1] = customer2;
            customers[2] = customer3;
            customers[3] = customer4;
            //customers[4] = customer5;

            Customer[] cust = (Customer[]) customers.Clone();


            var findCity = from c in customers
                           where c != null &&
                                 c.Salary > 10000 &&
                                 c.Salary < 20000
                           select new
                           {
                               Name = c.Name,
                               Salary = c.Salary,
                           };

            foreach (var c in findCity)
            {
                Console.WriteLine(c.Name + " " + c.Salary );
            }

            decimal[]  arr = new decimal[5];
            arr[0] = 36543;
            arr[1] = 3654;
            arr[2] = 1000;
            arr[3] = 3245;

            var salary = from s in arr
                         where s != null && s >1000 && s < 4000
                         select s;

            foreach (var s in salary)
            {
                Console.WriteLine(s);
            }
        }
    }
}
