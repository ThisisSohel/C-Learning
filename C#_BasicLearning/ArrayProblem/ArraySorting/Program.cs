

int[] arr = new int[5];
Console.WriteLine("Enter array element.");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int temp;

for (int i = 0;i < arr.Length; i++)
{
   for (int j = i+1 ; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}