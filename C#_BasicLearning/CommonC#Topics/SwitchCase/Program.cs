
int i  = (int)WeekDays.Thursday;
Console.WriteLine(i);

switch (i)
{
    case 0:
        {
            Console.WriteLine("Monday");
            break;
        }
    case 1:
        {
            Console.WriteLine("Tuesday");
            break;
        }
    case 2:
        {
            Console.WriteLine("Wednesday");
            break;
        }
    case 3:
        {
            Console.WriteLine("Thrusday");
            break;
        }
    case 4:
        {
            Console.WriteLine("Friday");
            break;
        }
    case 5:
        {
            Console.WriteLine("Saturday");
            break;
        }
    case 6:
        {
            Console.WriteLine("Sunday");
            break;
        }
    default:
        {
            Console.WriteLine("default");
            break;
        }

}
enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}




