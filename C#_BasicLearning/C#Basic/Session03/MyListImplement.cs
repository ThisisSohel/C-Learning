using Session03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Session03
{

    public class MyList
    {
        public int[] listElement;
        private int arrayCapacity;
        private int listSize;
        public int Count;


        public MyList()
        {
            arrayCapacity = 3;
            listSize = 0;
            Count = 0;
            listElement = new int[arrayCapacity];
        }

        public void AddElementToList(int element)
        {
            if (listSize == arrayCapacity)
            {
                arrayCapacity = arrayCapacity * 2;
                
                Array.Resize(ref listElement, arrayCapacity);
            }
            listElement[listSize] = element;
            listSize++;
            Count++;
        }
        public void AddRange(MyList myList)
        {
            for (int i = 0; i < myList.Count; i++) 
            {
                AddElementToList(myList.listElement[i]);
            }
        }
        public void DeleteFromList(int index)
        {
            if (index >= 0 && index < listSize)
            {
                for (int i = index; i < listSize - 1; i++)
                {
                    listElement[i] = listElement[i + 1];
                }
                listSize--;
                listElement[listSize] = 0;
                Count--;
            }
            else
            {
                Console.WriteLine("Index is not valid");
            }
        }
        public void LoadList()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(listElement[i]);
            }
        }
        public void MyListRangePrint()
        {
            List<int> mylistRange = new List<int>();
            mylistRange.AddRange(listElement);
            if (mylistRange.Count == 0)
            {
                Console.WriteLine("List Range is Empty");
            }
            else
            {
                for(int i = 0;i < Count; i++)
                {
                    Console.WriteLine(mylistRange[i]);
                }
            }
        }
    }
}

