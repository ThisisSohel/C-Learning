using System.Collections;

namespace GenericsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> store = new DataStore<string>("Hello");
            Console.WriteLine(store.Data);
            store.Display("Bangla");
            Console.WriteLine("Return Method Data: " + store.ReturnDisplay("ReturnData"));

            DataStore<int> st = new DataStore<int>(123);
            Console.WriteLine(st.Data);
            st.Display(3645);

            DataStore<int> store2 = new DataStore<int>(1000);
            Console.WriteLine(store2.Data);

            MultiDataStore<string, int > multiDataStore = new MultiDataStore<string, int>();
            multiDataStore.Value = "Hello";
            multiDataStore.Value1 = 5;
            Console.WriteLine(multiDataStore.Value + " " + multiDataStore.Value1);

            MultiDataStore<int, int> intData = new MultiDataStore<int, int>();
            intData.Value = 20;
            intData.Value1 = 5;
            Console.WriteLine(intData.Value + " " + intData.Value1);

            MultiDataStore<int, string> stringData = new MultiDataStore<int, string>();
            stringData.Value = 20;
            stringData.Value1 = "Hello";
            Console.WriteLine(stringData.Value + " " + stringData.Value1);

            GenericConstraint<string> constraint = new GenericConstraint<string>();
            GenericConstraint<string> ints = new GenericConstraint<string>();
            DataTypeClass<int> dataTypeClass = new DataTypeClass<int>();
            DataTypeClass<char> dataTypeClass1 = new DataTypeClass<char>();

            CollectionClass<ArrayList> collectionClass = new CollectionClass<ArrayList>();  
        }
    }
}
