


using Session07;
using System.Threading.Channels;

var vehicle = new Vehicle();
vehicle.PrintVehicleType();


//int a = 5;
//int b = a;
//b = 10;
//// a = 5, b = 10
//Console.WriteLine(a + " " + b);

//A aa = new A();
//A bb = new A();

//aa.a = 5;
//aa = bb;
//bb.a = 10;

////a = 10, b = 10
//Console.WriteLine(aa.a + " " + bb.a);
/*
   aa : 00x1
   bb: 00x2

   aa.a = 5 (00x1)
   bb.b  = aa.a;
   bb.b(00x2) = 10;
  
 */
//class Random
//{
//    public int a;
//}

//class A
//{
//    public int a;
//}
//class B
//{
//    public int b;
//}


//Point p1 = new Point()
//{
//    x = 10,
//    y = 5
//};

//Point p2 = p1;
//p2.x = 11;
//p2.y = 10;

//Console.WriteLine($"p1: ({p1.x}, {p1.y}), p2: ({p2.x}, {p2.y})");
///*

//   p1 : 00x1   ----
//   p2 = p1
//   p2 : 00x1
//*/

//class Point
//{
//    public int x;
//    public int y;
//}


//int start = 1;
//int end = 10;

//while (start <= end)
//{
//    if (start % 3 == 0)
//    {
//        Console.WriteLine(start);
//    }
//    start++;
//}

//int[] arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


//int[] revArr = new int[arr.Length];

//int j = 0;
//for (int i = arr.Length - 1 ; i >= 0 ; i--)
//{
//    revArr[j] = arr[i];
//    j++;
//}

//for(int i = 0; i < revArr.Length; i++)
//{
//    Console.WriteLine(revArr[i]);
//}

/*
Algorithm: Sequential - Bubble - Sort(A)
fori ← 1 to length [A] do
    for j ← length[A] down - to i + 1 do
            if A[A] < A[j - 1] then
               Exchange A[j] ⟷ A[j - 1]
 */

int[] arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int temp = 0;
for (int i = 0; i < arr.Length; i++)
{
    for(int j = i+1; j < arr.Length; j++)
    {
        if (arr[i] < arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}