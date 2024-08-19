namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperatorOverloading obj1 = new OperatorOverloading();
            obj1.Num1 = 10;
            obj1.str1 = "hello";

            OperatorOverloading obj2 = new OperatorOverloading();
            obj2.Num1 = 20;
            obj2.str1 = "hey";

            OperatorOverloading obj3 = new OperatorOverloading();
            obj3 = obj1 + obj2;
            Console.WriteLine("The sum of obj1 and obj2 is: " + obj3.Num1);
            Console.WriteLine("The sum of obj1 and obj2 is: " + obj3.str1);

            Ticket firstTicket = new Ticket(3);
            Ticket secondTicket = new Ticket(4);

            Ticket sumTicket = firstTicket + secondTicket;
            Console.WriteLine("The total duration in hours is : " + sumTicket.DurationHours);


            int number = Convert.ToInt32(Console.ReadLine());
            float fNumber = Convert.ToSingle(Console.ReadLine());
            double dNumber = Convert.ToDouble(Console.ReadLine());  
            decimal ddNumber = Convert.ToDecimal(Console.ReadLine());
        }

      
    }
        public class OperatorOverloading
        {
            public int Num1 = 0;
            public string str1 = "";

            public static OperatorOverloading operator + (OperatorOverloading obj1, OperatorOverloading obj2)
            {
                OperatorOverloading operatorOverloading = new OperatorOverloading();
                operatorOverloading.Num1 = obj1.Num1 + obj2.Num1;
                operatorOverloading.str1 = obj1.str1 + obj2.str1;
                return operatorOverloading;
            }
        }

        public interface IName
        {
            public void NameSet();
        }
        public interface IAge
        {
            public void AgeSet();
        }

        public class Employee : IName, IAge 
        {
            public void AgeSet()
            {
                Console.WriteLine("Age is set!");
            }

            public void NameSet()
            {
                Console.WriteLine("Name is set!");
            }
        }


        
    }
}
