

int[] arr = new int[5];

Console.WriteLine("Enter the array element");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine (arr[i] + " ");
}

int maxValue = 0;
int minValue = 0;
int temp;
for (int i = 0;i < arr.Length; i++)
{
    if (arr[i] > maxValue)
    {
        maxValue = arr[i];
    }
    else
    {
        minValue = arr[i];
    }
}
Console.WriteLine("The max array value is: " + maxValue);
Console.WriteLine("The min array value is: " + minValue);