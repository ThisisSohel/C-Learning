//using System;
//using System.Collections.Generic;

//Customer customer = new Customer()
//{
//    Id = 1,
//    Name = "Sohel",
//    Salary = 2000
//};
//Customer customer1 = new Customer()
//{
//    Id = 2,
//    Name = "Sohel1",
//    Salary = 4000
//};
//Customer customer2 = new Customer()
//{
//    Id = 3,
//    Name = "Sohel2",
//    Salary = 4000
//};
//Savings savings = new Savings()
//{
//    Id = 4,
//    Name = "Rakib",
//    Salary = 2364673
//};

//List<Customer> customers = new List<Customer>();
//Customer[] arr = new Customer[3];
//arr[0] = customer;
//arr[1] = customer1;
//arr[2] = customer2;

////for (int i = 0; i < arr.Length; i++)
////{
////    Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", arr[i].Id, arr[i].Name, arr[i].Salary);
////}

//customers = arr.ToList();

//customers.Add(customer);
//customers.Add(customer1);
//customers.Add(customer2);
//customers.Add(savings);
//customers.Insert(1, customer2);

//Dictionary<int, Customer> dictionary = customers.ToDictionary(cust => cust.Id);

//foreach (KeyValuePair<int, Customer> keyValue in dictionary)
//{
//    Console.WriteLine("Key: {0}", keyValue.Key);
//    Customer cust = keyValue.Value;
//    Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
//}

//int indexFirst = customers.FindIndex(cust => cust.Salary == 4000);
//Console.WriteLine(indexFirst);
//int indexLast = customers.FindLastIndex(cust => cust.Salary == 4000);
//Console.WriteLine(indexLast);


//List<Customer> c1 = customers.FindAll(cust => cust.Salary == 4000);

//foreach (Customer c in c1)
//{
//    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.Salary);
//}


//if (customers.Contains(savings))
//{
//    Console.WriteLine("Saving contain to the list");
//}
//else
//{
//    Console.WriteLine("Saving does not contain to the list");
//}
//if (customers.Exists(cust => cust.Name.StartsWith("Z")))
//{
//    Console.WriteLine("Customer object exist in the list");
//}
//else
//{
//    Console.WriteLine("Customer object does not exist in the list");

//}

//Console.WriteLine("List size: " + customers.Count);
//Console.WriteLine("Index: {0}", customers.IndexOf(customer2, 0, 4));

//foreach (Customer c in customers)
//{
//    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", c.Id, c.Name, c.Salary);
//}

//for (var i = 0; i < customers.Count; i++)
//{
//    Customer c = customers[i];
//    Console.WriteLine("Id = {0} Name: {1} Salary: {2}", c.Id, c.Name, c.Salary);
//}


//public class Customer
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public decimal Salary { get; set; }
//}

//public class Savings : Customer
//{

//}