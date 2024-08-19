
using System.Collections;

//ArrayList arrayList = new ArrayList();
//arrayList.Add(null);
//arrayList.Add(1);
//arrayList.Add(4);
//arrayList.Add(5);
//arrayList.Add(7);

//arrayList.Remove(0);  


//int index = arrayList.IndexOf(7);

//if (index != -1)
//{
//    Console.WriteLine("Index Found");
//    arrayList.RemoveAt(100);
//}
//else
//{
//    Console.WriteLine("Index Not Found");
//}


ArrayList arrayList = new ArrayList()
{
    1, 2, 8, 3, 4,"null", "Hello"
};

arrayList.Insert(1, "Second Item");
arrayList.Insert(2, "Inserting ArrayList");
arrayList.InsertRange(3, arrayList);
//var  firstElement = arrayList[4];
//Console.WriteLine(firstElement);

if (arrayList.Contains(800))
{
    arrayList.Remove(800);
}
else
{
    Console.WriteLine("No iteam to remove");
}

int index = arrayList.IndexOf(345632);
if (index != -1)
{
    Console.WriteLine(arrayList[index]);
}
else
{
    Console.WriteLine("Value not found");
}
//var element = arrayList[6];
//Console.WriteLine(element);

//Hashtable hashtable = new Hashtable();
//hashtable.Add(1, 2);
//hashtable.Add(2, 3);
//hashtable.Add(3, 4);

//arrayList.AddRange(hashtable);
//Console.WriteLine(arrayList.Count);

//Stack stack = new Stack();
//stack.Push(1);
//stack.Push(2);
//stack.Push(3);

//arrayList.AddRange(stack);
//Console.WriteLine(arrayList.Count);

//for (int i = 0; i < arrayList.Count; i++)
//{
//    Console.WriteLine(arrayList[i]);
//}

foreach (var i in arrayList)
{
    Console.WriteLine(i);
}