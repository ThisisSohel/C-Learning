
using AbstractInterface.cs;

namespace OOPLearning
{

    public class Program
    {
        public static void Main()
        {

            FullTimeEmployee fte = new FullTimeEmployee()
            {
                Id = 1,
                FirstName = "Sakib",
                LastName = "Rana",
                AnnaulSalary = 40000
            };
            Console.WriteLine(fte.FullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("..................");

            PartTimeEmployee pte = new PartTimeEmployee()
            {
                Id = 2,
                FirstName = "Sara",
                LastName = "San",
                HourlyPay = 200,
                TotalHoursWorked = 23
            };
            Console.WriteLine(pte.FullName());
            Console.WriteLine(pte.GetMonthlySalary());
            Console.WriteLine("..................");

            PersonBase person1 = new Person1()
            {
                Id = 1,
                Name = "Sohel"
            };

            person1.Info();

           
        }
    }

}
