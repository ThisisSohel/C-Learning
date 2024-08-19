
Customer customer = new Customer("xy", "xc");
customer.FullName();
Customer customer3 = new Customer("xy", "xc", 232);
customer3.FullName1();

Customer customer2 = new Customer();
customer2.FullName();

class Customer
{
    string _fName;
    string _lName;
    int Id;

    public Customer()
        : this ("ewrwer", "ewrer", 23)
    {

    }
    public Customer(string Fname, string Lname, int id)
    {
        _fName = Fname;
        _lName = Lname;
        Id = id;
    }
    public Customer(string Fname, string Lname) 
    {
        _fName = Fname;
        _lName = Lname;
    }


    public void FullName()
    {
        Console.WriteLine(_fName + " " +   _lName);
    }

    public void FullName1()
    {
        Console.WriteLine(_fName + " " + _lName + " " + Id);
    }
}