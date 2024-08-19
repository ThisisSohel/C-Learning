

//CustomValue customValue = new CustomValue();
//customValue.intValue = 42;
//customValue.stringValue = "foo";
//CustomValue customValue1 = new CustomValue();
//customValue1 = customValue;
//customValue1.intValue = 43;
//customValue1.stringValue = "bar";
//Console.WriteLine($"Int Value: {customValue.intValue}");
//Console.WriteLine($"Reference Value: {customValue.stringValue}");
//Console.WriteLine($"Int Value: {customValue1.intValue}");
//Console.WriteLine($"Reference Value: {customValue1.stringValue}");
//class CustomValue
//{
//    public int intValue;
//    public string stringValue;
//}

//void ModifyValue (int value)
//{
//    value = value * 2;
//    //Console.WriteLine(value);
//}

//int number = 2;
//Console.WriteLine(number);
//ModifyValue(number);
//Console.WriteLine(number);

//using System.Drawing;
//using ValueTypeRefType;

//Person person = new Person();
//person.Name = "Test";
//Person person2 = person;

//Person person3 = new Person();
//Person person4 = new Person();

//bool isEqual = person == person2;
//bool isEqual2 = person2 == person3;


//int a = 1;
//int b = a;
//b = 10;
//Console.WriteLine(a);
//Console.WriteLine(b);

using ValueTypeRefType;



DemoMain.Demo();

class DemoMain
{
    public static void Demo()
    {
        int a = 1; // value Type a = 1 --001x
        int b = a; //value type b = 1 --002x
        Console.WriteLine(b); // 1
        b = 10; //value type b = 10 --003x
        Console.WriteLine(a); //1
        Console.WriteLine(b);//10

        Person person = new Person(); // Ref type p ---004x
        person.Name = "xy"; // 
        Console.WriteLine(person.Name); //xy
        Person person2 = person; //ref type p2 = 004x
        person2.Name = "ABC";
        Console.WriteLine(person.Name);  //p -> ABC
    }
}

