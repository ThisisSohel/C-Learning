using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayCopy
    {
        public void ArrayCopyToArray() 
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            Console.WriteLine("Enter 5 array Element: ");
            for (int i = 0; i < 5; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                arr2[i] = arr1[i];
            }
            for (int i = 0;i < 5; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
    }
}
