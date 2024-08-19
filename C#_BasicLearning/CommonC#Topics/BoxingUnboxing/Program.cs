

namespace BoxingUnboxing
{
    class A
    {
        public int x;
        public int y;
    }
    internal class Program
    {
        public static void Main(string[] args)
        {

            //A a = new A();
            //a.x = 1;
            //a.y = 2;
            //Console.WriteLine("x = {0} and y = {1}", a.x, a.y);
            //object obj = a;
            //a.y = 20;

            //Console.WriteLine("Y = {0}", ((A)obj).y);
            //Console.WriteLine("X = {0}", ((A)obj).x);

            //A b = new A();
            //b = a;
            //object objb = b;
            //A i = (A)objb;
            //i.x = 1;
            //i.y = 2;
            //Console.WriteLine("xi = {0} and yi = {1}", i.x, i.y);

            //Console.WriteLine("X = {0}", ((A)objb).x);

            ////A b = new A();
            ////int i = (int)objb;
            ////Console.WriteLine(i);

            //Console.WriteLine("The value of objb Y = {0}", ((A)objb).y);

            //int i = 123;
            //object obj = i;
            //Console.WriteLine(obj);

            //obj = 321;
            //i = (int)obj;
            //Console.WriteLine(i);

            //List<object> list = new List<object>();

            //list.Add("First Group");
            //for(int j =1; j <= 5; j++)
            //{
            //    list.Add(j);
            //}

            //list.Add("Second Group");
            //for (int j = 6; j <= 10; j++)
            //{
            //    list.Add(j);
            //}

            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //int sum = 0;
            //for (int j = 1; j <= 5; j++)
            //{
            //    sum = sum + ((int)list[j]);
            //}
            //Console.WriteLine(sum);

            //object[] arr = new object[10];
            //int arraySum = 0;

            //for (int j = 0;j < 5; j++)
            //{
            //    arr[j] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Enter string Element");
            //for (int j = 5; j < 10; j++)
            //{
            //    arr[j] = Console.ReadLine();
            //}

            //for (int j = 0; j < 5; j++)
            //{
            //    arraySum = arraySum + ((int)arr[j]);
            //}
            //Console.WriteLine(arraySum);

            //for (int j = 5; j < 10; j++)
            //{
            //    Console.WriteLine(arr[j]);
            //}

            //int x = 10;
            //object obj = x;
            //object obj1 = 20;
            //int sum = 20;
            //sum = sum + (int)obj;
            //Console.WriteLine(sum);
            //Console.WriteLine(obj);
            //obj = "dgfjhg";
            //Console.WriteLine(obj);
            //obj = 365.3245;
            //Console.WriteLine(obj);
            //obj = 35473654;
            //Console.WriteLine(obj);

            Bonus bonus = new Bonus();
            bonus.Salary = 1;
            object obj = bonus.Salary;
            int x = (int)bonus.Salary;
            //int x = 20;

            int SlarySum = x + (int)obj;
            Console.WriteLine(SlarySum);
        }
    }
}
