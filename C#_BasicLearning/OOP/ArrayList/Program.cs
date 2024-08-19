

using ArrayList1;

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
 ArrayList arrayList = new ArrayList
ArrayList custList = new ArrayList(Customer);
custList.Add(customer1);    
custList.Add(customer2);
custList.Add(customer3);
//custList.AddRange(custList);
custList.Insert(0, customer1);
custList.RemoveAt(3);
//custList.RemoveRange(0, 3);
if (custList.Contains(customer1))
{
    Console.WriteLine("User is already there!");
}
custList[customer1.Id].Name = "ZZZZ"; 

foreach (Customer cList in custList)
{
    Console.WriteLine("Id = {0} Name {1} Salary {2}", cList.Id, cList.Name, cList.Salary);
}