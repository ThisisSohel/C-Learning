
//Customer customer = new Customer();
//customer.Print1();
//customer.Print2();

public interface ICustomer1
{
    public void Print1();
}

public interface ICustomer2 : ICustomer1
{
    public void Print2();
}

public class Customer : ICustomer2
{
    public void Print1()
    {
        Console.WriteLine("Implemented Interface 1");
    }
    public void Print2()
    {
        Console.WriteLine("Implemented Interface 2");
    }
}