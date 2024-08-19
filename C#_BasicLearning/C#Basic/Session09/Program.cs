
A a1 = new A(); 
a1.x = 1;
a1.y = 2;
Console.WriteLine(a1.x + " " + a1.y);

A a2 = new A(); 
a2 = a1; 
a2.x = 2;
Console.WriteLine(a1.x + " " + a1.y);

A a3 = new A();

a3.ValueType();
//Before 0
//After 10
A.ValueType2();
//Before 1
//After 1
a3.ValueType3();

A obj = new A();
Console.WriteLine("Before " + obj.x);
obj.y = obj.x;
obj.y = 10;
Console.WriteLine("After " + obj.x);
//Before 0
//After 0
class A
{
    public int x;
    public int y;

    public void ValueType()
    {
        Console.WriteLine("Before " + x);
        y = x;
        y = 10;
        Console.WriteLine("After " + x);
    }
    public static void ValueType2()
    {
        int x = 1;
        //int y;
        Console.WriteLine("Before " + x);
        ref int y = ref x;
        y = 10;
        Console.WriteLine("After " + x);
    }

    public void ValueType3()
    {
        x = 1;
        Console.WriteLine("Before x3--" + x);
        ref int y = ref x;
        y = 10;
        Console.WriteLine("After x3--" + x);
    }
}




//class Program
//{

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Hello World");
//    }

//    class A
//    {

//    }
//}



//class Demo
//{
//    public static void MainDemo(string[] args)
//    {
//        Console.WriteLine("Hello World");


//    }
//}