

int[] arr = new int[5];

Console.WriteLine("Enter the array element: ");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Enter the start number");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the end number");
int endNumber = Convert.ToInt32(Console.ReadLine());
int sum = 0;    
for (int i = startNumber; i <= endNumber; i++)
{
    sum += arr[i];
}
Console.WriteLine($"The sum of array from {startNumber} to {endNumber} is : {sum}");
/// <summary>
/// Add two values
/// 
/// </summary>
/// <param name="a">The first value</param>
/// <param name="b">The second value</param>
/// <return>The added result</return>
/// <remarks></remarks>
/// 

///<summary>
///
/// 
/// </summary>
/// <param a = "1">   </param>
/// <param b = "2">   </param>
/// <return>   </return>
/// 

int[] arr2 = new int[5];

for (int i = 0 ;i <= endNumber; i++)
{
    arr2[i] = Convert.ToInt32(Console.ReadLine());
}

