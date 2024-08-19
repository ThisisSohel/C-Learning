

using SortedList.cs;
using System.Collections;
using System.Collections.Generic;

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
Hashtable hashtable = new Hashtable();
hashtable.Add(customer1.Id, customer1);
hashtable.Add(customer2.Id, customer2);
hashtable.Add(customer3.Id, customer3);

//Customer cd = (Customer)hashtable[customer2.Id];
//cd.Name = "Hi";
//List<Customer> cu;
//cu = (List<Customer>)hashtable.Values;
//var item = (Customer)hashtable[customer1.Id]!;
//var item2 = new object();

//item.Name = "GGG";
foreach (DictionaryEntry kv in hashtable)
{
    Console.WriteLine("Key = {0}", kv.Key);
    Customer cust = (Customer)kv.Value!;
    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", cust.Id, cust.Name, cust.Salary);
}
Dictionary<int, Customer> keyValuePairs = new Dictionary<int, Customer>();
keyValuePairs.Add(1, customer1);
keyValuePairs.Add(2, customer2);
keyValuePairs.Add(3, customer3);
//Customer cd = (Customer)keyValuePairs[customer1.Id];
//cd.Name = "Hi";
//keyValuePairs[customer2.Id].Name = "WW";
int value = keyValuePairs.Values.ElementAt(1).Id;
Console.WriteLine("Index: " + value);
foreach (KeyValuePair<int, Customer> kv in keyValuePairs)
{
    Console.WriteLine("Key = {0}", kv.Key);
    Customer cust = kv.Value;
    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", cust.Id, cust.Name, cust.Salary);
}
SortedList<int, Customer> sList = new SortedList<int, Customer>();
sList.Add(1, customer1);
sList.Add(2, customer2);
sList.Add(3, customer3);

Console.WriteLine(sList.IndexOfKey(customer1.Id));

sList[customer1.Id].Name = "Saber";

if (sList.ContainsKey(2563))
{
    Console.WriteLine("User is Found!");
}
else
{
    Console.WriteLine("User is not Found!");

}
if (sList.ContainsValue(customer3))
{
    Console.WriteLine("User is Found!");
}
else
{
    Console.WriteLine("User is not Found!");

}
Customer result;
if (!sList.TryGetValue(12, out result))
{
    Console.WriteLine("User is Found!");
}
else
{
    Console.WriteLine("User is not Found!");

}
foreach (KeyValuePair<int, Customer> kv in sList)
{
    Console.WriteLine("Key = {0}", kv.Key);
    Customer cust = kv.Value;   
    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", cust.Id , cust.Name, cust.Salary);
}
