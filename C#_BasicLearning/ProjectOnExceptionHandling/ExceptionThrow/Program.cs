namespace ExceptionThrow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Name = "Test";
            //std.Id = 1;

            Student std1 = null;

            string str = "gh   ";

            //try
            //{
            //    PrintStudentName(std1);
            //}catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            //Console.ReadKey();

            try
            {
                PrintStringMessage(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }

        private static void PrintStudentName (Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Id is null");
            }
            else
            {
                Console.WriteLine(student.Name);
            }
        }

        public static void PrintStringMessage(string str)
        {
            if(str == null)
            {
                throw new ArgumentNullException("String is null here");
            }else if (str.Length <5)
            {
                throw new Exception("String length can not be less than 5");
            }
            else if(str.Trim().Length < 5)
            {
                throw new Exception("String length can not be less than 5 without white space");
            }
        }
    }
}
