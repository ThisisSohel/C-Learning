

//int fact = 1;
//int factNumber;
//Console.WriteLine("Enter the factorial number:");
//factNumber = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= factNumber; i++)
//{
//    fact = fact * i;
//}
//Console.WriteLine("Factorial number is: " + fact);


//int factorial(int f)
//{
//    if (f == 0)
//    {
//        return 1;
//    }
//    else
//    {

//        return (f * factorial(f - 1));
//    }
//}

//Console.WriteLine(factorial(5));

//Console.WriteLine("Enter the number for digit sum");
//int digitSum = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//while (digitSum > 0)
//{
//    int remainder = digitSum % 10;
//    sum = sum + remainder;
//    digitSum = digitSum / 10;
//}
//Console.WriteLine(sum);

//int n1 = 0;
//int n2 = 1;
//int n3 = 0;

//Console.WriteLine("Enter the number to find fibonacci");
//int fiboNum = Convert.ToInt32(Console.ReadLine());
//Console.Write(n1+ " ");
//Console.Write(n2 +" ");
//for (int i = 2; i < fiboNum; i++)
//{
//    n3 = n1 + n2;
//    Console.Write(n3 + " ");
//    n1 = n2;
//    n2 = n3;
//}

//List<int> list = new List<int>();
//list.Add(1);
//list.Add(2);
//list.Add(3);
//list.Add(4);
//list.Reverse();

//foreach (int i in list)
//{
//    Console.WriteLine(i);
//}
//int i = 1;
//for (; ; )
//{
//    if(i <= 10)
//    {
//        Console.WriteLine(i);
//        i++;
//    }
//    else
//    {
//        break;
//    }
//}

//do
//{
//    Console.WriteLine(i);
//    if (i == 3)
//    {
//        break;
//    }
//    i++;
//} while(i < 5);


//char ch = ' ';
//Console.WriteLine(ch);

int x = 1;
do
{
    Console.WriteLine(x);
    x++;
} while (x<=10);

do
{

}while (x<=10);