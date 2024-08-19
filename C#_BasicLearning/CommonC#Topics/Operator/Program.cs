

//int x = 5;
//Console.WriteLine("+x = {0}", x *= 3);
//Console.WriteLine("+x = {0}", +x + 3);

//string str = null;
//str ??= "Hello World";
//Console.WriteLine(str);

//bool b = true;
//bool c = true;

//if (b & c)
//{
//    Console.WriteLine("Same type");
//}
//else
//{
//    Console.WriteLine("Different type");
//}

//int num1 = 5;
//int num2 = 6;

//int result = num1 > num2 ? 1 : 2;
//Console.WriteLine(result);

//var res = num1 < num2 ? "num1 is greater " : "num2 is greater";


//int X = 75875;
//int Y = 20;

//var r = X == Y ? "Both are equal" :
//        X > Y ? "X is greater than Y" :
//        X < Y ? "Y is greater than x" : "Nothing happes";
//Console.WriteLine(r);

//switch(X)
//{
//    case 1:
//        {
//            Console.WriteLine("1");
//            break;
//        }
//    case 2:
//        {
//            Console.WriteLine("2");
//            break;
//        }
//    case 3:
//        {
//            Console.WriteLine("3");
//            break;
//        }
//    default:
//        {
//            Console.WriteLine("default");
//            break;
//        }
//}

//int number = 15;
//bool Isnumber = number == 16?  true: false;
//Console.WriteLine(Isnumber);

//List<int> ? ints = null; 

//bool? isnumber = null;
//Console.WriteLine(isnumber);

//(ints ??= new List<int>()).Add(5);
//Console.WriteLine(ints[0]);

//int? nullValue = null;

//string item  = null;
//string item2 = "Hi";
//string item3 = "Hello";

//string item4 =  item ?? item2;
//string item5 = item3 ?? item2;

//Console.WriteLine(item4);
//Console.WriteLine(item5);


int x = 5;
var leftShift = x << 2;
Console.WriteLine(leftShift);
int y = 10;

var result = x > y ? "X is greater" : "Y is greater";
Console.WriteLine(result);

//float floatNumber = Convert.ToSingle(Console.ReadLine());
//double doubleNumber = Convert.ToDouble(Console.ReadLine());
//int intNumber = Convert.ToInt32(Console.ReadLine());
//decimal decimalNumber = Convert.ToDecimal(Console.ReadLine());
//char charnumber  = Convert.ToChar(Console.ReadLine()!);
//Console.WriteLine(charnumber);

string str = "12-03-2024";
DateTime dt;

var isValid = DateTime.TryParse(str, out dt);
Console.WriteLine(isValid);