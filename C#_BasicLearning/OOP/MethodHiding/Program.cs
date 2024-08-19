
public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + "---");
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;
}
public class PartTimeEmployee : Employee
{

    public new void PrintFullName()
    {
        //base.PrintFullName(); //This is how chaild class called the base class property
        Console.WriteLine(FirstName + " " + LastName + "From Part time");
    }
}

public class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Rakib";
        FTE.LastName = "Hasan";
        FTE.Email = "xyz@gmail.com";
        FTE.YearlySalary = 5000000;
        FTE.PrintFullName();
        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Part";
        PTE.LastName = "Time";
        ((Employee)PTE).PrintFullName();

    }
}


