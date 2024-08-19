
public class Employee
{
    public string FirstName = "FN ";
    public string LastName = "LN ";
    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public override void PrintFullName()
    {
       // base.PrintFullName();
        Console.WriteLine(FirstName + " " + LastName + "Full Time");
    }
}
public class PartTimeEmployee : Employee
{

    public override void PrintFullName()
    {
        base.PrintFullName();
        Console.WriteLine(FirstName + " " + LastName + "Part Time");
    }
}

public class PersonInfo
{
    private string Name;
    private int Age;

    public PersonInfo(string name)
    {
        Name = name;    
    }

    public void DisplayInfo(string occupation)
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Occupation: " + occupation);
    }
    public void DisplayInfo(int age, string city)
    {
        Console.WriteLine("Age "+ age);
        Console.WriteLine("City: " + city);
    }
    public void DisplayInfo(string city, int age)
    {
        Console.WriteLine("Age " + age);
        Console.WriteLine("City: " + city);
    }

}
public class Interest
{
    public virtual double ADB(double amount, double rate)
    {
        return amount * rate;
    }
}
public class SimpleInterest : Interest
{
    public override double ADB(double amount, double rate)
    {
        return amount * rate + 2;
    }
}
public class FixedInterest : Interest
{
    public override double ADB(double amount, double rate)
    {
        return amount * rate + 4000;
    }
}

public class Program
{
    public static void Main()
    {
        Employee emp = new Employee();
        emp.PrintFullName();
        FullTimeEmployee FT = new FullTimeEmployee();
        FT.PrintFullName();
        PartTimeEmployee PT = new PartTimeEmployee();
        PT.PrintFullName();
        PersonInfo personInfo = new PersonInfo("Sakib");
        personInfo.DisplayInfo("Teacher");
        personInfo.DisplayInfo(25, "Dhaka");        
        PersonInfo personInfo1 = new PersonInfo("Rakib");
        personInfo1.DisplayInfo("Army");
        personInfo1.DisplayInfo("Dhaka", 32);
        Interest simple = new SimpleInterest();
        Console.WriteLine(simple.ADB(2, 2));
    }
}



