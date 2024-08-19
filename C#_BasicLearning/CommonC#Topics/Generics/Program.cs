

using System.Security.Cryptography.X509Certificates;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Person<string> person = new Person<string>();
            //person.AddorUpdate("sdhgfjh", "sjkfbsdjhgf");

            Student<string> stu1 = new Student<string>()
            {
                Id = 1,
                Success = "true"
            };

            var stu2 = new Student<int>()
            {
                Id = 2,
                Success = 1
            };

            var stu3 = new Student<bool>()
            {
                Id = 3,
                Success = false
            };

            stu1.PrintStudentInfo(stu1);
            stu2.PrintStudentInfo(stu2);
            stu3.PrintStudentInfo(stu3);

            StudentCalculation<int> calAdd = new StudentCalculation<int>();
            Console.WriteLine("The addition is: {0}", calAdd.Add(20, 30));

            StudentCalculation<int> calSub = new StudentCalculation<int>();
            Console.WriteLine("The addition is: {0}", calSub.Subtract(20, 30));

            StudentCalculation<int> calMul = new StudentCalculation<int>();
            Console.WriteLine("The addition is: {0}", calMul.Multiplication(20, 30));

            StudentCalculation<int> calDiv = new StudentCalculation<int>();
            Console.WriteLine("The addition is: {0}", calDiv.Multiplication(40, 2));
        }
    }
}