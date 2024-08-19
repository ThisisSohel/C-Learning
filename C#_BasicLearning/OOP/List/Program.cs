

//using List;

//Customer customer1 = new Customer()
//{
//    Id = 1,
//    Name = "Sakib",
//    Salary = 2000
//};
//Customer customer2 = new Customer()
//{
//    Id = 11,
//    Name = "Suny",
//    Salary = 3000
//};
//Customer customer3 = new Customer()
//{
//    Id = 12,
//    Name = "Rakib",
//    Salary = 1000
//};

//List<Customer> custList = new List<Customer>();
//custList.Add(customer1);
//custList.Add(customer2);
//custList.Add(customer3);
//custList[0].Name = "gdjgsgd";  //Update name
////custList.AddRange(custList);
//custList.Insert(0, customer1);
//custList.RemoveAt(3);
////custList.RemoveRange(0, 3);
//if (custList.Contains(customer1))
//{
//    Console.WriteLine("User is already there!");
//}
//custList[customer1.Id].Name = "ZZZZ";
//List<Customer> findAll = custList.FindAll(c => c.Salary > 1000);

//foreach (Customer cList in custList)
//{
//    Console.WriteLine("Id = {0} Name {1} Salary {2}", cList.Id, cList.Name, cList.Salary);
//}

//string str = "dhg,fjdh";
//string[] str1 = new string[3];
//string[] str2 = str.Split(',');
//Console.WriteLine(str2.Length);
//for (int i = 0; i < str2.Length; i++)
//{
//    Console.WriteLine(str2[i]);
//}

//str1[0] = "gdgjsdjhfj";
//str1[1] = "dhsgfh";
//str1[2] = "dfhdgs";
//char[] ch = new char[3];
//ch[0] = 'g';
//ch[1] =  'A';
//ch[2] = 'e';

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine(ch[i]);
//}
//string multipleStr = "dg/dfh.fh%sd gdj:gdj;jhd\td*g";
//string[] multiStr = multipleStr.Split(' ', '/', '.', ':', ';', '\t', '*', '%');
//Console.WriteLine(multiStr.Length);
//for (int i = 0; i < multiStr.Length; i++)
//{
//    Console.WriteLine(multiStr[i]);
//}

string str = "  Hel2lo   ";
string str2 = "DS"; 
//Console.WriteLine(str.Substring(1, 2));
//Console.WriteLine(str.Remove(1, 2));
Console.Write(str.Trim(' '));
Console.Write(str2);

//string stringTrim = "sdhgfjsd3fdjsf";
//string [] strSplit = stringTrim.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', ' ');
//for (int i = 0; i < strSplit.Length; i++)
//{
//    Console.WriteLine(i + " " + strSplit[i]);
//}

string padLeft = "Hello";
Console.WriteLine("PadLeft: " + padLeft.PadLeft(9, '*'));
Console.WriteLine("Paded String Length: " + padLeft.Length);