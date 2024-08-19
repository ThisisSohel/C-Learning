using System.Collections;
using System.Security.Cryptography;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashNumber = new Hashtable();
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Hashtable has = new Hashtable(dic);

            hashNumber.Add("A", "A1");
            hashNumber.Add("B", "B1");
            hashNumber.Add(1, "C1");

            Console.WriteLine(hashNumber["A"]);
            //for (int i = 0; i < hashNumber.Count; i++)
            //{
            //    var value = hashNumber[key];
            //    Console.WriteLine("Key: {0} Value: {1}", hashNumber.Keys[i] , hashNumber.Values[i]);
            //}

            foreach (DictionaryEntry d in hashNumber)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
            string str = "JHsdgsj";
            Console.WriteLine(str.Remove(3, 1));
            var cities = new Hashtable(){
                 {"UK", "London, Manchester, Birmingham"},
                 {"USA", "Chicago, New York, Washington"},
                 {"India", "Mumbai, New Delhi, Pune"}
            };

            if (cities.ContainsKey("USA"))
            {

            }
            cities["USA"] = "A1";
            string str2 = (string)cities["USA"];
            Console.WriteLine(str2);
        }
    }
}
