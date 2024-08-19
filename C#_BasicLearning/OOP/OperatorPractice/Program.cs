namespace OperatorPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            var result = x > y ? "x is greater" : "Y is greater";

            Console.WriteLine(result);
            //var switchValue = Convert.ToInt32(Console.ReadLine());
            //switch (switchValue)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("hfgdgfh");
            //            break;
            //        }
            //    case 2:
            //        {
            //            Console.WriteLine();
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine();
            //            break;
            //        }
            //}

            List<int> list = new List<int>();
            SortedList<int, string> keyValuePairs = new SortedList<int, string>();
            //foreach (int i in list)
            //{
            //    list.Add(i);
            //}

            //int[] arr;
            //arr = new int[5] {1, 2, 3,4 ,5};

            //for (int i = 0; i < 5; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}


            try
            {
                string str = "12";

                var res= int.Parse(str);
                
                  Console.WriteLine(res);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            Employee<int> employee = new Employee<int>();

            employee.Data = 1000;
            Console.WriteLine(employee.Data);

            Employee<string> employee2 = new Employee<string>();

            
            Console.WriteLine(employee2.Data);

            var inputValue = Console.ReadLine();

            if (int.TryParse(inputValue, out int number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Input is not a valid format!");
            }
        }
    }
}
