
//using System.Collections;

////Hashtable<Person> = new Hashtable<Person>();
////Stack Stack = new Stack();

//Person person = new Person();
//SortedList<int, Person> keyValuePairs = new SortedList<int, Person>();
//Hashtable hashtable = new Hashtable();
//List<Person> people = new List<Person>();
//ArrayList arrayList = new ArrayList();

//person.InfoSet();

//keyValuePairs.Add(1, person);
//keyValuePairs.Add(2, person);

//people.Add(person);

//arrayList.Add(person);

//hashtable.Add(1, person);

//Console.WriteLine("Data from List");
//Console.WriteLine("");
//foreach (var th in people)
//{
//    th.InfoLoad();
//    Console.WriteLine("");
//}
//Console.WriteLine("Data from ArrayList");
//Console.WriteLine("");
//foreach (var th in arrayList)
//{
//    Console.WriteLine("Id : {0} value: {1}", person.Id, person.Name);
//}
//Console.WriteLine("Data from Hashtable...");
//foreach (DictionaryEntry th in hashtable)
//{
//    Console.WriteLine("Id : {0} value: {1}", th.Key, th.Value);
//}
//Console.WriteLine("Data from SortedList...");
//foreach (var kp in keyValuePairs)
//{
//    Console.WriteLine("Id : {0} value: {1}", kp.Key, kp.Value);
//}
//public class Person
//{
//    public int Id { get; set; } 
//    public string Name { get; set; }

//    public void InfoSet()
//    {
//        Id = 1;
//        Name = "test";
//    }
//    public void InfoLoad()
//    {
//        Console.WriteLine($"Id = {Id} and Name = {Name}");
//    }
//    public override string ToString()
//    {
//        return ($"Id = {Id} and Name = {Name}");
//    }
//}


//using System.Collections.Generic;

//Customer customer = new Customer()
//{
//    Id = 111,
//    Name = "Sakib",
//    Address = "Dhaka"
//};
//Customer customer1 = new Customer()
//{
//    Id = 112,
//    Name = "Sakib1",
//    Address = "Mirpur_2"
//};
//Customer customer2 = new Customer()
//{
//    Id = 113,
//    Name = "Sakib2",
//    Address = "Mirpur"
//};

//Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();

//customerDictionary.Add(customer.Id, customer);
//customerDictionary.Add(customer1.Id, customer1);
//customerDictionary.Add(customer2.Id, customer2);

//Customer customerInfo = customerDictionary[(customer.Id)];
//Console.WriteLine("Id = {0}, Name = {1}, Address = {2}", customerInfo.Id, customerInfo.Name, customerInfo.Address);

//Customer customerInfo1 = customerDictionary[(customer1.Id)];
//Console.WriteLine("Id = {0}, Name = {1}, Address = {2}", customerInfo1.Id, customerInfo1.Name, customerInfo1.Address);

//foreach(KeyValuePair<int, Customer> keyValuePair in customerDictionary)
//{
//    Console.WriteLine("Key = {0}", keyValuePair.Key);
//    Customer cust = keyValuePair.Value;
//    Console.WriteLine("Id = {0}, Name = {1}, Address = {2}", cust.Id, cust.Name, cust.Address);
//    Console.WriteLine("..............................................................");
//}
//foreach(int key in customerDictionary.Keys)
//{
//    Console.WriteLine("Key = {0}", key);
//    //Console.WriteLine("Id = {0}, Name = {1}, Address = {2}", cust.Id, cust.Name, cust.Address);
//    //Console.WriteLine("..............................................................");
//}

////Customer cust;
////if (customerDictionary.TryGetValue(575786, out cust))
////{
////    Console.WriteLine("Id = {0}, Name = {1}, Address = {2}", cust.Id, cust.Name, cust.Address);
////}
////else
////{
////    Console.WriteLine("The Id key holder is not found");
////}
//Customer customer = new Customer()
//{
//    Id = 111,
//    Name = "Sohel",
//    Salary = 1000
//};
//Customer customer1 = new Customer()
//{
//    Id = 112,
//    Name = "Sohel1",
//    Salary = 200
//};
//Customer customer2 = new Customer()
//{
//    Id = 113,
//    Name = "Sohel2",
//    Salary = 1000
//};

//Dictionary<int, Customer> customerDic = new Dictionary<int, Customer>();


//customerDic.Add(customer.Id, customer);
//customerDic.Add(customer1.Id, customer1);
//customerDic.Add(customer2.Id, customer2);

//List<Customer> customers = new List<Customer>();
//customers.Add(customer);
//customers.Add(customer1);
//customers.Add(customer2);


// Dictionary<int, Customer> dic = customers.ToDictionary(cust => cust.Id, cust => cust);

//foreach(KeyValuePair<int, Customer> kvp in dic)
//{
//    Console.WriteLine("Id = {0}", kvp.Key);
//    Customer cust = kvp.Value;
//    Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.Id, cust.Name, cust.Salary);
//}

//var salaryCount = customerDic.Count(t => t.Value.Salary >= 1000);
//if (salaryCount > 1)
//{
//    Console.WriteLine("Good List");
//}
//Console.WriteLine("Total number of value is : {0}", customerDic.Count(t => t.Value.Salary >= 1000));
//Console.WriteLine("Total number of Customer whose name start wih 'S' : {0}", customerDic.Count(t => t.Value.Name.StartsWith('S')));
////Console.WriteLine(customerDic.Remove(111));
////customerDic.Clear();

//Customer cust;
//if (customerDic.TryGetValue(12365, out cust))
//{
//    Console.WriteLine("Id = {0}, Name = {1}, Address = {2}", cust.Id, cust.Name, cust.Salary);
//}
//else
//{
//    Console.WriteLine("Id is not found!");
//}

//if (!customerDic.ContainsKey(22873427))
//{
//    Console.WriteLine("Id is not found");
//}

////Customer cd1 = customerDic[(customer.Id)];
////Console.WriteLine("Id = {0}", cd1.Id);

//foreach (KeyValuePair<int, Customer> keyValue in customerDic)
//{
//    Console.WriteLine("Id = {0}", keyValue.Key);
//    Customer cust1 = keyValue.Value;
//    Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust1.Id, keyValue.Value.Name, keyValue.Value.Salary);
//    Console.WriteLine("..................................................................................................");
//}
//public class Customer
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public decimal Salary { get; set; }
//}