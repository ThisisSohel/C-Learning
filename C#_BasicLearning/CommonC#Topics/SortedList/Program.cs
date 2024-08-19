using System;
using System.Collections;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, int> sortList = new SortedList<int, int>();

            sortList.Add(1, 2);
            sortList.Add(2, 3);
            sortList.Add(3, 4);
            sortList.Add(4, 5);
            sortList.Add(5, 6);

            SortedList<int, int> newSortedList = (SortedList<int, int>)(sortList);
            for (int i = 0; i < newSortedList.Count; i++)
            {
                Console.WriteLine(newSortedList.Keys[i] + " " + newSortedList.Values[i]);
            }
            int sum = 0;
            int res;
            sortList.Remove(1000);

            //int index = sortList.IndexOfKey(5);
            
            if (sortList.ContainsValue(6))
            {
                Console.WriteLine("Value is already there");
            }

            if (sortList.IndexOfKey(5) == -1)
            {
                Console.WriteLine("Index key not found!");
            }
            else
            {
                Console.WriteLine(sortList[5]);
            }
        
            if(sortList.TryGetValue(4, out res))
            {
                Console.WriteLine("Key: {0}, Value: {1}", 4, res);
            }
            if (sortList.ContainsKey(54))
            {
                Console.WriteLine(sortList[4]);
                Console.WriteLine(sortList.Keys[3] + " " + sortList.Values[3]);
            }
            else
            {
                Console.WriteLine("Key not found");
            }

            for (int i = 0; i < sortList.Count; i++)
            {
                Console.WriteLine(sortList.Keys[i] + " " + sortList.Values[i]);
                sum = sum + ((int)sortList.Keys[i]);
            }
            Console.WriteLine(sum);
        }

    }
}
