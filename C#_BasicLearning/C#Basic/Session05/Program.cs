//6 "f"
//  
//not found
//
/*
 
*/

//Dictionary<int, string> kv = new Dictionary<int, string>();
//kv.Add(1, "a");
//kv.Add(2, "b");
//kv.Add(3, "c");
//kv.Add(4, "d");
//kv.Add(5, "e");
//kv.Add(6, "f");

//string result;

//if (kv.TryGetValue(7, out result))
//{
//    Console.WriteLine(result);
//}
//else
//{
//    Console.WriteLine("Value is not found!");
//}

//if (kv.ContainsKey(6))
//{
//    kv[6] =  "a";
//}
//else
//{
//    Console.WriteLine("Key not found!");
//}


//for (int i = 0; i < kv.Count; i++)
//{
//    Console.WriteLine("Key = {0} Value = {1}", kv.ElementAt(i).Key, kv.ElementAt(i).Value);
//}

//SortedList<int, string> sList = new SortedList<int, string>();
//sList.Add(1, "a");
//sList.Add(2, "b");
//sList.Add(3, "c");
//sList.Add(4, "d");
//sList.Add(5, "e");
//sList.Add(6, "f");

//if (sList.ContainsKey(7))
//{
//    Console.WriteLine(sList[7]);
//}
//else
//{
//    Console.WriteLine("Id not found");
//}

//if (sList.ContainsKey(5))
//{
//    sList[5] = "a";
//    Console.WriteLine(sList[5]);
//}
//else
//{
//    Console.WriteLine("Key is not found!");
//}
//if (sList.ContainsKey(6))
//{
//    sList.Remove(6);
//    Console.WriteLine("Key deleted!");
//}
//else
//{
//    Console.WriteLine("key is not found!");
//}
//for (int i = 0; i < sList.Count; i++)
//{
//    Console.WriteLine("Key: {0} value: {1}", sList.Keys[i], sList.Values[i]);
//}

List<int> list = new List<int>();
list.Add(0);
list.Add(1);
list.Add(2);
list.Add(3);
list.AddRange(list);

if (list.Contains(2))
{
    Console.WriteLine(list[2]);
}
else
{
    Console.WriteLine("Not Found!");
}

int[] arr = new int[2];
arr[0] = 100;
arr[1] = 200;

list.AddRange(arr);

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine("Value: {0}", list[i]);
}
if (list.Contains(3))
{
    //list.Remove(3);
    //list.RemoveAt(4);
    list.RemoveRange(1, 2);
    Console.WriteLine("List iteam is deleted!");
}
else
{
    Console.WriteLine("Item not found!");
}
list.Remove(0);
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine("Value: {0}", list[i]);
}