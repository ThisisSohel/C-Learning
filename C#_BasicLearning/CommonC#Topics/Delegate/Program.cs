

using System.Security.Cryptography.X509Certificates;

public delegate void MyDel(string message);
public delegate int MyDelNumber(int number);

class Program
{
    static void Main(string[] args)
    {
        MyDel strDel = new MyDel(StringMethod);
        strDel.Invoke("Hello string method");

        MyDelNumber myDelNumber = NumberMethod;
        Console.WriteLine("Del number is : " + myDelNumber(354));
    }
    public static void StringMethod(string message)
    {
        Console.WriteLine(message);
    }

    public static int NumberMethod(int message)
    {
        return message++;
    }
}

