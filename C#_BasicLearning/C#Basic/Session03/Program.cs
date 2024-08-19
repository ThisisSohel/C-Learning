using Session03;
using System.Linq.Expressions;
class Program
{
    static void Main(string[] args)
    {
        MyList elementToAdd = new MyList();
        elementToAdd.AddElementToList(1);
        elementToAdd.AddElementToList(2);
        elementToAdd.AddElementToList(3);

        MyList myList = new MyList();
        myList.AddElementToList(4);
        myList.AddElementToList(5);
        myList.AddElementToList(6);

        myList.AddRange(elementToAdd);
        

        myList.LoadList();
        // 4 5 6 1 2 3

        //MyList myList = new MyList();
        //List<int> list = new List<int>();   
        //bool exit = false;

        //while (!exit)
        //{
        //    Console.WriteLine("1. Add Element to List");
        //    Console.WriteLine("2. Delete Element from List");
        //    Console.WriteLine("3. Read List of Element");
        //    Console.WriteLine("4. Read List of ListRange");
        //    Console.WriteLine("5. Exit");

        //    int readChoice = Convert.ToInt32(Console.ReadLine());

        //    switch (readChoice)
        //    {
        //        case 1:
        //            {
        //                Console.WriteLine("Enter the element to add in List:");
        //                int element = Convert.ToInt32(Console.ReadLine());
        //                myList.AddElementToList(element);
        //                break;
        //            }
        //        case 2:
        //            {
        //                Console.WriteLine("Enter the index to delete a element from List:");
        //                int index = Convert.ToInt32(Console.ReadLine());
        //                myList.DeleteFromList(index);
        //                break;
        //            }
        //        case 3:
        //            {
        //                Console.WriteLine("Elements in the list:");
        //                myList.LoadList();
        //                break;
        //            }
        //        case 4:
        //            {
        //                Console.WriteLine("Elements from Listrange:");

        //                myList.MyListRangePrint();
        //                break;
        //            }
        //        case 5:
        //            exit = true;
        //            break;
        //        default:
        //            Console.WriteLine("Invalid Input!");
        //            break;
        //    }
        //}

    }
}
