﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class StoreInArray
    {
        int[] elements = new int[10];

        public void ArrayPrint()
        {
            Console.WriteLine("Enter the 5 elements: ");
            for (int i = 0; i < 5; i++)
            {
                elements[i] = Convert.ToInt32(Console.ReadLine());   
            }
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
