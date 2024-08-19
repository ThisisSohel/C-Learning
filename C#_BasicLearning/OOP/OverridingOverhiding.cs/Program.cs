public class Person
{
    public virtual void Info()
    {
        Console.WriteLine("Hello from base class!");
    }
}
public class Employee: Person
{
    public new void Info()
    {
        //base.Info();
        Console.WriteLine("Hello from Derived class");
    }
}
public class BaseClass
{
    public new void Print()
    {
        Console.WriteLine("I am base class");
    }
}

public class DerivedClass : BaseClass
{
    public new void Print()
    {
        Console.WriteLine("I am derived class");
    }
}


public class Program
{
    public static void Main()
    {
        //BaseClass b1 = new BaseClass();
        //b1.Print();
        //BaseClass b = new DerivedClass();
        //b.Print();
        Person emp = new Employee();
        emp.Info();
    }
}



