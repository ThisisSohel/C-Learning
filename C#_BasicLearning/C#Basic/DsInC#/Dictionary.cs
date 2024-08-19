

//using System.Collections;
//using System.Runtime.InteropServices;

//Customer customer1 = new Customer()
//{
//    Id = 112,
//    Name = "Sohel",
//    Salary = 1000
//};
//Customer customer2 = new Customer()
//{
//    Id = 113,
//    Name = "Sohel1",
//    Salary = 200
//};
//Customer customer3 = new Customer()
//{
//    Id = 111,
//    Name = "Sohel2",
//    Salary = 1000
//};

//SortedList<int, Customer> sortList = new SortedList<int, Customer>();
//Dictionary<int, Customer> customerDic = new Dictionary<int, Customer>();
//Hashtable hashtable = new Hashtable();
//Stack<Customer> list = new Stack<Customer>();
//ArrayList arrayList = new ArrayList();
//List<Customer> cList = new List<Customer>();
//Queue<Customer> queue = new Queue<Customer>();

////Tuple<Customer> tuple = Tuple.Create(customer1);

////foreach(Customer cusTuple in tuple)
////{
////    Console.WriteLine("Id = {0} Name= {1} Salary = {2}", cusTuple.Id, cusTuple.Name, cusTuple.Salary);
////}

//queue.Enqueue(customer1);
//queue.Enqueue(customer2);
//queue.Enqueue(customer3);
//queue.Enqueue(customer1);

//if (queue.Contains(customer1))
//{
//    Console.WriteLine("Element is in the queue");
//}
//Console.WriteLine("The queue size: " + queue.Count);

//Console.WriteLine("Print from Queue");
//foreach (Customer qCust in queue)
//{
//    Console.WriteLine("Id = {0} Name= {1} Salary = {2}", qCust.Id, qCust.Name, qCust.Salary);
//}


//list.Push(customer1);
//list.Push(customer2);
//list.Push(customer3);

//if (list.Contains(customer3))
//{
//    Console.WriteLine("Customer is found!");
//}
//Console.WriteLine("Print from Stack");
//foreach (var stackCustomer in list)
//{
//    Console.WriteLine("Id = {0} Name= {1} Salary = {2}", stackCustomer.Id, stackCustomer.Name, stackCustomer.Salary);
//}
//if (list.Count == 0)
//{
//    Console.WriteLine("The stack is empty!");
//}
//else
//{
//    Console.WriteLine("Customer after Pop");
//    Customer popCustomer = list.Pop();
//    Console.WriteLine("Id = {0} Name= {1} Salary = {2}", popCustomer.Id, popCustomer.Name, popCustomer.Salary);

//}

//Console.WriteLine("Customer after peak");
//Customer peakCustomer = list.Peek();
//Console.WriteLine("Id = {0} Name= {1} Salary = {2}", peakCustomer.Id, peakCustomer.Name, peakCustomer.Salary);




//cList.Add(customer1);
//cList.Add(customer2);
//cList.Add(customer3);
////cList.Insert(0, customer1);
////Customer ctl = (Customer)customer1.Id;
//Console.WriteLine("Salary Based print from List");
//Customer cFind = cList.FindLast(cust => cust.Salary > 200);
//Console.WriteLine("Id = {0} Name = {1} Salary = {2}", cFind.Id, cFind.Name, cFind.Salary);

//List<Customer> cFindAll = cList.FindAll(cust => cust.Salary > 200);
//Console.WriteLine("Whose salary is over 200");
//foreach (Customer findAll in cFindAll)
//{
//    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", findAll.Id, findAll.Name, findAll.Salary);
//}

//if (cList.Exists(cust => cust.Name.StartsWith("S")))
//{
//    Console.WriteLine("User is found!");
//}
//else
//{
//    Console.WriteLine("User is not found!");
//}
//if (cList.Contains(customer3))
//{
//    Console.WriteLine("User Is found");
//}
//else
//{
//    Console.WriteLine("User Id is not found");
//}
//Console.WriteLine(cList.IndexOf(customer1, 1));
//Console.WriteLine("Print From List");
//for (int i = 0; i < cList.Count; i++)
//{
//    Customer clist = cList[i];
//    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", clist.Id, clist.Name, clist.Salary);
//}


//arrayList.Add(customer1);
//arrayList.Add(customer2);
//arrayList.Add(customer3);
//arrayList.Insert(0, customer1);
//arrayList.InsertRange(1, arrayList);
//Console.WriteLine(arrayList.Count);
//arrayList.RemoveAt(0);
//arrayList.RemoveRange(1, 3);
////hashtable[customer1.Id].Name = "Sabir Hasan";
//if (arrayList.Contains(customer1))
//{
//    Console.WriteLine("User Is found");
//}
//else
//{
//    Console.WriteLine("Id is not found");
//}
//Customer cust = (Customer)arrayList[0]!;
//cust.Name = "Sahil";
//Console.WriteLine("Print from ArrayList:");

//foreach (var customer in arrayList)
//{
//    Customer customer4 = (Customer)customer;
//    Console.WriteLine("Id = {0} Name= {1} Salary = {2}", customer4.Id, customer4.Name, customer4.Salary);
//}


////hashtable.Add(1, "abc");
////hashtable.Add(3, "xyz");
////hashtable.Add(2, "xyz");
//hashtable.Add(customer1.Id, customer1);
//hashtable.Add(customer2.Id, customer2);
//hashtable.Add(customer3.Id, customer3);
////hashtable.Remove(customer1.Id);
//if (hashtable.ContainsKey(234234))
//{
//    hashtable.Remove(customer1.Id);
//    Console.WriteLine("The user is Deleted");
//}
//else
//{
//    Console.WriteLine("Id is not found!");
//}
////Console.WriteLine("The hash value of user is: ", hashtable[customer1.Id].GetHashCode());
////hashtable[customer1.Id].Name = "Sabir Hasan";

//Console.WriteLine("Output from Hashtable: ");
//foreach (DictionaryEntry ht in hashtable)
//{
//    Customer hashCust = (Customer)ht.Value!;
//    Console.WriteLine("Id = {0} Name {1} Salary = {2}", ht.Key, hashCust.Name, hashCust.Salary);
//}

//sortList.Add(customer1.Id, customer1);
//sortList.Add(customer2.Id, customer2);
//sortList.Add(customer3.Id, customer3);
////sortList.Remove(customer1.Id);
////sortList[customer1.Id].Name = "Sabir Hasan";


//if (sortList.ContainsKey(customer1.Id))
//{
//    Console.WriteLine("Customer is found!");
//}
//Customer c;
//if (sortList.TryGetValue(4654564, out c))
//{
//    Console.WriteLine("Customer is Found!");
//}
//else
//{
//    Console.WriteLine("Customer is not found!");
//}
//Console.WriteLine("Print from Sorted List");

//for (int i = 0; i < sortList.Count; i++)
//{
//    Customer c2 = sortList.Values[i];
//    Console.WriteLine("Id = {0} Name = {1} Salary = {2}", sortList.Keys[i], c2.Name, c2.Salary);
//}

//Customer[] arr = new Customer[3];
//arr[0] = customer1;
//arr[1] = customer2;
//arr[2] = customer3;

////arr[0].Name = "sgdjs";

//List<Customer> arrayToList = arr.ToList();
//Console.WriteLine("Print from Array: ");
//foreach (var cust2 in arr)
//{
//    Console.WriteLine("Id = {0} Name= {1} Salary = {2}", cust2.Id, cust2.Name, cust2.Salary);
//}

//Dictionary<int, Customer> kp = arr.ToDictionary(cust => cust.Id, cust => cust);



//customerDic.Add(customer1.Id, customer1);
//customerDic.Add(customer2.Id, customer2);
//customerDic.Add(customer3.Id, customer3);



////customerDic.Remove(767);

//int updateToValue = customer1.Id;
//customerDic[updateToValue].Name = "Rakib";

//Customer result;

//Console.WriteLine("Total Item = {0}", customerDic.Count(t => t.Value.Salary < 1000));
//if (customerDic.TryGetValue(656, out result))
//{
//    Console.WriteLine("Id is not in List");
//}
//if (customerDic.ContainsKey(customer1.Id))
//{
//    Console.WriteLine("Id is already in List");
//}
//else
//{
//    customerDic.Add(customer1.Id, customer1);
//}
////customerDic.Clear();
////Customer cust1 = customerDic[customer1.Id];
////Console.WriteLine("Id = {0}, Name = {1} Salary = {2}", cust1.Id, cust1.Name, cust1.Salary);

//foreach (KeyValuePair<int, Customer> kv in customerDic)
//{
//    Console.WriteLine("Key = {0}", kv.Key);
//    Customer cust2 = kv.Value;
//    Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust2.Id, cust2.Name, cust2.Salary);
//}
//public class Customer
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public decimal Salary { get; set; }
//}