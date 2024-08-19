

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
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
    }
    public void DisplayInfo(string city, int age)
    {
        Console.WriteLine("City: " + city);
        Console.WriteLine("Age: " + age);
    }
}


//Static Polymorphism

public class Interest
{
    public double ADB(double amount, double rate)
    {
        return amount * (amount * rate);
    }
    public double ADB(double amount, double rate, double holderCharge)
    {
        return amount * (amount * rate) + holderCharge;
    }
}

//Dynamic Polimorphism
public class Interest1
{
    public virtual double ADB(double amount, double rate)
    {
        return amount * rate;
    }
}
public class SimpleInterest : Interest1
{
    public override double ADB(double amount, double rate)
    {
        return amount * rate + 200;
    }
}
public class FixedInterest : Interest1
{
    private double serviceCharge;
    public FixedInterest(double sCharge)
    { 
        serviceCharge = sCharge;
    
    }
    public override double ADB(double amount, double rate)
    {
        return amount * rate + serviceCharge;
    }
}


namespace PolymorphismClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //PersonInfo personInfo = new PersonInfo("Sohel");
            //PersonInfo personInfo2 = new PersonInfo("Rakib");
            //PersonInfo personInfo1 = new PersonInfo("Sakib");

            //personInfo2.DisplayInfo("Software Engineer");
            //personInfo.DisplayInfo("Dhaka", 25);
            //personInfo.DisplayInfo(25, "Dhaka");


            //Interest adb = new Interest();
            //var totalRate = adb.ADB(200.23, 3);
            //Console.WriteLine($"Total rate is: {totalRate}");

            //var totalRate1 = adb.ADB(2323.234, 3, 10);
            //Console.WriteLine($"Total1 rate is: {totalRate1}");

            //Interest1 simpelInterest = new SimpleInterest();
            //Interest1 fixedInterest = new FixedInterest(10);

            //Console.WriteLine("The total rate of simple interest is: " + simpelInterest.ADB(2,2));
            //Console.WriteLine("The total rate of fixed interest is: " +  fixedInterest.ADB(2,2));

        }
    }
}