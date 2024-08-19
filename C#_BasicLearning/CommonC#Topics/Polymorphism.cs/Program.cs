class Bank
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual void Interest(decimal amount)
    {
        Console.WriteLine("Interest : " +  amount * 20);
    }
    public virtual void Interest(decimal amount, decimal monthlyIncrease)
    {
        Console.WriteLine("Interest2 : " + (amount * 20) + monthlyIncrease);
    }
}

class Bank1 : Bank
{
    public override void Interest(decimal amount)
    {
        //base.Interest(amount);
        Console.WriteLine("Interest1 of Bank1: ");
    }
    public override void Interest(decimal amount, decimal monthlyIncrease)
    {
        //base.Interest(amount, monthlyIncrease);
        Console.WriteLine("Interest2 of Bank1: ");
    }
}
public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual void PrintName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }

}
public class fTime : Employee
{
    public string address { get; set; }
    public override void PrintName()
    {
        base.PrintName();
        Console.WriteLine(address);
    }
}
public class pTime: Employee
{
    public override void PrintName()
    {
        base.PrintName();
    }
}
//public class fTime : Employee
//{
//    public override void PrintName()
//    {
//        Console.WriteLine(FirstName + " " + LastName + " --Full Time");
//    }
//}

//public class LTime : Employee
//{
//    public override void PrintName()
//    {
//        Console.WriteLine(FirstName + " " + LastName + " --Part Time");
//    }
//}


public class Program
{
    public static void Main()
    {
        //Employee emp = new Employee();
        //emp.FirstName = "Rakib";
        //emp.LastName = "Hasan";
        //emp.PrintName();
        //Employee fe = new fTime();
        //fe.FirstName = "Hasan";
        //fe.LastName = "ALi";
        //fe.PrintName();
        //Employee le = new LTime();
        //le.FirstName = "Hasan1";
        //le.LastName = "ALi1";
        //le.PrintName();


        Bank bank = new Bank();
        bank.Interest(121);
        bank.Interest(121, 2);

        Bank bank1 = new Bank1();
        bank1.Interest(121);
        bank1.Interest(121, 2);
    }
}