//using System.Collections;

//var arrList = new ArrayList();

//arrList.Add(1);
//arrList.Add(4);
//arrList.Add(2);
//arrList.Add(5);
//arrList.Add(3);
//arrList.Add(null);


//arrList.Add(null);
////arrList.Insert(0, 3);
////arrList.Remove(arrList[3]);
//arrList.RemoveAt(0);
//arrList.RemoveRange(2,3);
//Console.WriteLine(arrList.Contains(32754));

//var arrCopy = new ArrayList();
//arrCopy = arrList;
//arrList.Sort();
//foreach (var item in arrList)
//{
//    Console.WriteLine(item);
//}

//arrList.Reverse();
//foreach (var item in arrList)
//{
//    Console.WriteLine(item);
//}




////Console.WriteLine(arrList[5]);

//var arrList2 = new ArrayList()
//{
//    2, 3, "True", "False"
//};

//arrList2.Add(2);
//foreach (var item in arrList2)
//{
//    Console.WriteLine(item);
//}

//for (int i = 0; i<arrList2.Count; i++)
//{
//    Console.WriteLine(arrList2[i]);
//}

//int[] arr = {1, 2, 3};
//arrList2.Clear();

//List<int> list = new List<int>();
//list.Add(1);
//list.Add(2);
//list.Add(3);
//list.Add(4);
////list.Add(null);

//var list1 = new ArrayList();
//list1.Add(null);

//var students = new List<Student>()
//{
//    new Student() { Id = 1,}
//    new Student()
//}

//var student = new List<Student>()
//              {

//              };



//string[] cities2 = new string[3] {"fsd", "asfd", "fdghsf"};


//var list2 = new List<string>();

//list2.AddRange(cities2);

//List<int> ints = new List<int>() { 1, 2, 2, 3 };

//Console.WriteLine(ints[1]);

//foreach (int i in ints)
//{
//    Console.WriteLine(i);
//}

//var student = new List<Student>()
//{
//    new Student(){Id = 1, Name = "dgs"};
//    new Student() { Id = 1, Name = "dgs" };
//}

//var result = from s in list
//             where s.Name = "dgs"
//             selec s;

//foreach(var student in result)
//{
//    Console.WriteLine($"Student: {student.Id}");
//}

//SortedList<int, string> numberNames = new SortedList<int, string>()
//{
//    {3, "Three" },
//    {2, "gee" }
//};




//SortedList<string, string> cities = new SortedList<string, string>()
//                                    {
//                                        {"London", "UK"},
//                                        {"New York", "USA"},
//                                        { "Mumbai", "India"},
//                                        {"Johannesburg", "South Africa"}
//                                    };

//foreach (KeyValuePair<int, string> kvp in numberNames)
//{
//    Console.WriteLine(kvp.key, kvp.Value);
//}

//ArrayList arrayList = new ArrayList();
//arrayList.Add(10);
//arrayList.Add(11);
//arrayList.Add(12);
//arrayList.Add(10);
//arrayList.Add(11);
//arrayList.Add(12);
//arrayList.Add(10);
//arrayList.Add(11);
//arrayList.Add(12);
//arrayList.Add(10);
//arrayList.Add(11);
//arrayList.Add(12);

//Console.WriteLine(arrayList.Contains(462362452));
//Console.WriteLine("IsReadOnly: " + arrayList.IsReadOnly);
//var arrayList2 = new ArrayList()
//{
//    12, 34, "dsfg", "sdfgj"
//};

//arrayList2.Insert(0, 12121);
//arrayList.InsertRange(2, arrayList2);
//arrayList.RemoveAt(1);
//arrayList.RemoveRange(2, 3);

//foreach  (var i in arrayList)
//{
//    Console.WriteLine(i);
//}

//Stack<int> ints = new Stack<int>();
//ints.Push(1);
//ints.Push(2);
//ints.Push(3);
//ints.Push(4);
//ints.Push(5);
//foreach (var number in ints)
//{
//    Console.WriteLine(number);
//}


//int[] ar = new int[] { 1, 2, 3 };

//Stack<int> int2 = new Stack<int>(ar);
////int2.Clear();
//foreach (var number in int2)
//{
//    Console.WriteLine(number);
//}

//Console.WriteLine(int2.Count());
//Console.WriteLine(int2.Peek());

//Stack<string> floats = new Stack<string>();
//floats.Push("sd");
//floats.Push("sdfds");
//floats.Push(null);
//Console.WriteLine(floats.Contains(null));
//foreach (var number in floats)
//{
//    Console.WriteLine(number);
//}

//Queue<string> strings = new Queue<string>();    
//strings.Enqueue("a");
//strings.Enqueue("b");
//strings.Enqueue("c");
//strings.Enqueue(null);
//strings.Dequeue();

//foreach (var number in strings)
//{
//    Console.WriteLine(number);
//}

//Tuple<int, string> t1 = Tuple.Create(1, "34");
//me(t1);
//var person = Tuple.Create(2, 3, 4, 5, 6, 7, 8, Tuple.Create(4, 34, 33333));
//Console.WriteLine(person.Rest.Item1);

//static void me (Tuple<int, string> t1)
//{
//    Console.WriteLine(t1.Item1);
//    Console.WriteLine(t1.Item2);
//}

//var p = t2();
//static Tuple <int, string> t2()
//{
//    return Tuple.Create(1, "we");
//}

////valueTuple

//var p2 = (1, 2, "234", 3, 2, 3, 5, Tuple.Create(1, 33));
//Console.WriteLine(p2.Rest);

//(int Id, string Name) n = (1, "ss");
//Console.WriteLine(n.Name);

//ArrayList list2 = new ArrayList();
//list2.Add(1);
//list2.Add(2);   



//using System.Collections;
//using System.Runtime.InteropServices;

//ArrayList arrayList = new ArrayList();
//arrayList.Add(1);
//arrayList.Add(2);
//arrayList.Add(5);
//arrayList.Add(3);
//arrayList.Add(4);

//foreach (int i in arrayList)
//{
//    Console.WriteLine(i);
//}


//Console.WriteLine(arrayList[0]);

//List<int> list = new List<int>();
//list.Add(1);
//list.Add(3);
//list.Add(2);
//foreach (int i in list)
//{
//    Console.WriteLine(i);
//}
//Tuple<int, string> tuple = new Tuple<int, string>(1, "Sohel");


//Console.WriteLine(tuple1.Item1);
//Console.WriteLine(tuple1.Item3);

//var tuple1 = Tuple.Create(4, 4);
//Dp(tuple1);
//static void Dp(Tuple<int, int> tuple1)
//{
//    Console.WriteLine(tuple1.Item1);
//    Console.WriteLine(tuple1.Item2);
//}

//static void Main(string[] args)
//{
//    var person = GetPerson();
//    Console.WriteLine(person.Item1);
//    Console.WriteLine(person.Item2);
//}

//static Tuple<int, int> GetPerson()
//{
//    return Tuple.Create(1, 2);
//}

//SortedList<int, string> keyValuePairs = new SortedList<int, string>();
//keyValuePairs.Add(1, "sd");
//keyValuePairs.Add(2, "ewrew");
//keyValuePairs.Add(5, "sdfsd");
//keyValuePairs.Add(10, "dsfds");
//if (!keyValuePairs.ContainsKey(20))
//{
//    keyValuePairs[20] = "Rakib";
//}
//keyValuePairs[4] = "Sohel";
////keyValuePairs.Add(2, "sdfds");
//Console.WriteLine(keyValuePairs[1]);

//foreach(KeyValuePair<int, string> pair in keyValuePairs)
//{
//    Console.WriteLine("key: {0}, value: {1}", pair.Key, pair.Value);
//}


//for (int i = 0; i < keyValuePairs.Count; i++)
//{
//    Console.WriteLine("key: {0}, value: {1}", keyValuePairs.Keys[i], keyValuePairs.Values[i]);
//}

//IDictionary<int, int> keyValuePairs1 = new Dictionary<int, int>();

//keyValuePairs1.Add(2, 3);
//keyValuePairs1.Add(1, 2);
//keyValuePairs1.Add(3, 4);
////Console.WriteLine(keyValuePairs1[19]);
//if (!keyValuePairs1.ContainsKey(1))
//{
//    Console.WriteLine(keyValuePairs1[1]);
//}
//keyValuePairs1[1] = 2342;
////keyValuePairs1.Remove(1);
////keyValuePairs1.Clear();
//int result;
//if(keyValuePairs1.TryGetValue(9, out result))
//{
//    Console.WriteLine($"{result}");
//}
//foreach (KeyValuePair<int, int> keyValuePair2 in keyValuePairs1)
//{
//    Console.WriteLine("Key: {0}, Value: {1}", keyValuePair2.Key, keyValuePair2.Value);
//}

//Hashtable hashtable = new Hashtable();
//hashtable.Add(3, "ggsjd");
//hashtable.Add(1, "dfsh");
//hashtable.Add(2, "dgfjh");

//foreach (DictionaryEntry dictionaryEntry in hashtable)
//{
//    Console.WriteLine("Key: {0}, Value: {1}", dictionaryEntry.Key, dictionaryEntry.Value);
//}


//Dictionary<int, string> dic = new Dictionary<int, string>();
//dic.Add(2, "we");
//dic.Add(3, "eww");
//dic.Add(1, "we");
//Hashtable ht = new Hashtable(dic);


//using System.ComponentModel;

//SortedDictionary <int, int> dr = new SortedDictionary<int, int>();  

//dr.Add(0, 1);
//dr.Add(3, 4);
//dr.Add(1, 2);
//dr.Add(2, 3);

//Console.WriteLine(dr.Count);

//foreach(KeyValuePair<int, int> pair in dr)
//{
//    Console.WriteLine("Key: {0} and Value: {1}", pair.Key, pair.Value);
//}

//var i = 1000;
//double a = 3542.234;
//int b = Convert.ToInt32(a);
//Console.WriteLine(b);

//int[] ints = new int[5];
//ints[0] = 2;
//ints[1] = 3;
//ints[2] = 4;

//int[] ints2 = {1, 2,2,3};
//var num = new int []{ 1, 10,23, 2, 4, 3, 1000 };
//Console.WriteLine(num.Length);
//Console.WriteLine(num.Max());
//Console.WriteLine(num.Min());
//Console.WriteLine(num.Sum());
//Console.WriteLine(num.Average());
//Array.Sort(num);
//for (int i = 0; i < num.Length; i++)
//{
//    Console.WriteLine(num[i]);
//}
//Console.WriteLine("Binary Search");
//Console.WriteLine(Array.BinarySearch(num, 10));
////Console.WriteLine(Array.MaxLength);
//int[,] arr2d = new int[3, 2]{
//                                {1, 2},
//                                {3, 4},
//                                {5, 6}
//                            };

//int[,] num = new int[3, 2]
//{
//    {1, 2 }, {3, 4},{4, 5}
//};

//string[][] basicInfo = new string[2][];

//basicInfo[0] = new string[3];
//basicInfo[1] = new string[3];

//basicInfo[0][0] = "01";
//basicInfo[0][1] = "Rakib";
//basicInfo[0][2] = "Dhaka";

//basicInfo[1][0] = "01";
//basicInfo[1][1] = "Rakib";
//basicInfo[1][2] = "Dhaka";

