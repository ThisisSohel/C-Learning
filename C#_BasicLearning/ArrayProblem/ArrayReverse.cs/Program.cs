

int[] arr = new int[5];
Console.WriteLine("Enter array elements: ");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = arr.Length - 1; i >= 0 ; i--)
{
    Console.Write(arr[i] + " ");
}
