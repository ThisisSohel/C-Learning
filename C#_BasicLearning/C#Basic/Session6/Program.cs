



//void Print(string a)
//{
//    Console.WriteLine("Print " + a);
//}

//Console.WriteLine("Enter Input");

//var a = Console.ReadLine();
//Console.WriteLine(a.GetType());



//switch (a)
//{
//    case "1":
//        {
//            Print(a);
//            break;
//        }
//    case "2":
//        {
//            Print(a);
//            break;
//        }
//    case "3":
//        {
//            Print(a);
//            break;
//        }
//    case "4":
//        {
//            Print(a);
//            break;
//        }
//    case "5":
//        {
//            Print(a);
//            break;
//        }
//    default:
//        {
//            Console.WriteLine("Number not found!");
//            break;
//        }
//}

//if (a == "1" )
//{
//    Console.WriteLine("Print " + a);
//}
//else
//{
//    Console.WriteLine("Not one!");
//}

//    int i = 1;
//    do
//    {
//        i++;
//        Console.WriteLine("Hello world" + i);
//    } while (i < 5);

///*
//   2 , 3, 4
// */

/*
    1, two, 3, four,,,,,
 */

void StringWord(int x)
{
    if(x == 2)
    {
        Console.WriteLine("Two");
    }
    else if(x == 4)
    {
        Console.WriteLine("four");
    }
}

int i = 1;

while (i <= 9)
{
    if(i%2 == 0)
    {
        StringWord(i);
    }
    else    
    {
        Console.WriteLine(i);
    }
    i++;
}