

//int[,] arr = new int[3,2];

//Console.WriteLine("Enter array elements");

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr.Length; j++)
//    {

//    }
//    arr[i] = Convert.ToChar(Console.ReadLine());
//}
//for (int i = 0;i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);  
//}

//int[] arr = new int[3] { 1, 2, 3 };

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//int[] aar2 = new int[10];

//for (int i = 0;i < aar2.Length; i++)
//{
//    aar2[i] = Convert.ToInt32(Console.ReadLine());
//}
string[] str = new string[3] { "1", "2", "3" };
ArrayMethod(str);

//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine(str[i]);
//}


void ArrayMethod(string[] receiveArray)
{
    for (int i = 0; i < receiveArray.Length; i++)
    {
        Console.WriteLine(receiveArray[i]);
    }
}

