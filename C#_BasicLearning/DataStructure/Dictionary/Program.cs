using Dictionary;



Dictionary<int, string> dictionaryList = new Dictionary<int, string>()
{
    {1, "b"},
    {2, "c"},
    {4, "e"},
    {3, "d"},

    {5, "f"},
    {6, "g"},
};

dictionaryList[6] = "Six";
string res;
if(dictionaryList.TryGetValue(4, out res))
{
    Console.WriteLine(dictionaryList[4]);
}
else
{
    Console.WriteLine("Value not found!!");
}

if (dictionaryList.ContainsKey(3))
{
    Console.WriteLine(dictionaryList[3]);
}
else
{
    dictionaryList.Add(3, "c");
}

for (int i = 0; i < dictionaryList.Count; i++)
{
    Console.WriteLine("Key: {0}, Value: {1}", dictionaryList.ElementAt(i).Key, dictionaryList.ElementAt(i).Value);
}

