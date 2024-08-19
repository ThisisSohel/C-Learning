

string str = "Hello World";
char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
str.CopyTo(6, chars, 3, 3);
Console.WriteLine(chars);

//Console.WriteLine(str.IndexOf('W'));

//string[] strArr = str.Split(' ');

//for (int i = 0; i < strArr.Length; i++)
//{
//    Console.WriteLine($"Index {i}: {strArr[i]}");
//}


//string multipleStr = "dg/dfh.fhsd gdj:gdj;jhd\tdg";
//string[] multiStr = multipleStr.Split(' ', '/', '.', ':', ';', '\t');

//for (int i = 0;i < multiStr.Length; i++)
//{
//    Console.WriteLine(multiStr[i]);
//}

string subString = "Hello Bangladesh53465 People";
int lastIndex = 17;
if (subString.Length < 0 || subString.Length < lastIndex)
{
    Console.WriteLine("Index is out of bound");
}
else
{
    Console.WriteLine("Sub String1: " + subString.Substring(0, lastIndex));
}


string stringTrim = "sdhgfjsd34234fdjsf";
Console.WriteLine("RemoveElement: " + stringTrim.Remove(0, 10));
Console.WriteLine(stringTrim.Trim('1', '2', '3', '4', '5', '6', '7', '8', '9'));

//string strReplace = "HELLO";
//Console.WriteLine("Replaced String: " + strReplace.Replace('H', 'O').Replace('l', ' ') + strReplace.ToUpper());
//Console.WriteLine("EndWith: " + strReplace.EndsWith('O'));

//string strLength = "g,f,j,d,d";
//Console.WriteLine("String Length: " + strLength.Length);

//string padLeft  = "Hello";
//Console.WriteLine("PadLeft: "+ padLeft.PadLeft(9, '*'));
//Console.WriteLine("Paded String Length: "+ padLeft.Length);

string padRight = "Hello";
Console.WriteLine("PadLeft: " + padRight.PadRight(9, '*'));
Console.WriteLine("Paded String Length: " + padRight.Length);

//char ch1 = '5';
//Console.WriteLine(ch1.ToString());

//string strCom1 = "Hi";
//string strCom2 = "Hi";
//Console.WriteLine("String Comparison: " + (strCom1 == strCom2));

//string[] strComArray = { "dhg1", "sjhsa2", "dfgdfg3", "dgsg4", "sdhgfjhd5", "dsgfjd6", "dgfjhdg7"};

////string strCom3 = string.Join('*', strComArray);
////Console.WriteLine(strCom3);

//string strCom4 = string.Join('*', strComArray, 2, 4);
//Console.WriteLine(strCom4);

//if (strCom1.Contains('i'))
//{
//    Console.WriteLine("Letter Found!");
//}
//else
//{
//    Console.WriteLine("Not Found!!");
//}

//string strChar = "Hello";
//Console.WriteLine(strChar.Count());
//char[] charStr = strChar.ToCharArray();
//Console.WriteLine("Characters...");
//for (int i = 0; i < charStr.Length; i++)
//{
//    Console.WriteLine(charStr[i]);
//}

//string name1 = "Jack Smith";
//string name2 = "John Doe";

//var concatString = string.Concat(name1, name2);
//Console.WriteLine(concatString);

//var copyString = string.Copy(name1);
//copyString.Remove(2, 2);
//Console.WriteLine(copyString.ToUpper());

//var findIndex = name1.IndexOf('S', 2, 2);
//Console.WriteLine(findIndex);
//if (name1.Contains('J'))
//{
//    Console.WriteLine("Character is found!");
//}
//else
//{
//    Console.WriteLine("Character is not found!");
//}

//Dictionary<int, string> strList = new Dictionary<int, string>();
//List<Person> people = new List<Person>()
//{
//    new Person
//    {
//        Name = "Alice",
//        Age = 25
//    },
//    new Person
//    {
//        Name = "Charlie",
//        Age = 26
//    }
//};

//strList.Add(1, "Hey");
//strList.Add(2, "Bye");


//if (!strList.ContainsKey(3))
//{
//    strList.Add(3, "boom");
//    Console.WriteLine("Value Added!");
//}

//List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

//var evenNumber = list.Where(x => x % 2 == 0).ToList();

//foreach (int i in evenNumber)
//{
//    Console.WriteLine(i);
//}
//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

