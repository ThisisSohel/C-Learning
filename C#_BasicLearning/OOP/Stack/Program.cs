

using Stack;

Customer customer1 = new Customer()
{
    Id = 1,
    Name = "Sakib",
    Salary = 2000
};
Customer customer2 = new Customer()
{
    Id = 11,
    Name = "Suny",
    Salary = 3000
};
Customer customer3 = new Customer()
{
    Id = 12,
    Name = "Rakib",
    Salary = 1000
};

Stack<Customer> stack = new Stack<Customer>();
stack.Push(customer1);
stack.Push(customer2);
stack.Push(customer3);

foreach (var sList in stack)
{
    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", sList.Id, sList.Name, sList.Salary);
}
Console.WriteLine("Pop");
stack.Pop();
foreach (var sList in stack)
{
    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", sList.Id, sList.Name, sList.Salary);
}
Console.WriteLine("Peak");
stack.Peek();
foreach (var sList in stack)
{
    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", sList.Id, sList.Name, sList.Salary);
}