

using Struct.cs;

public class Program
{
    public static void Main(string[] args)
    {
        Customer customer = new Customer(121, "Mark");
        customer.PrintDetails();
        Customer customer1 = new Customer();
        customer.PrintDetails();
    }
}