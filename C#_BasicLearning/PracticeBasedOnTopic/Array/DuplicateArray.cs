using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class DuplicateArray
    {
        public void DupliacateFind()
        {
            int[] arr = new int[10];
            int count = 0;
            Console.WriteLine("Enter 5 array Element: ");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = i +1 ; j < 5; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Dupliacte value is: "+ count);   
        }
    }
}
