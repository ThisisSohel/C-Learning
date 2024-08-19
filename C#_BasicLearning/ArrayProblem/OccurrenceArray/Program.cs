
int[] arr = new int[7];

Console.WriteLine("Enter the array element");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Enter the number to check the occurrence: ");
int numOccurrence = Convert.ToInt32(Console.ReadLine());
int countOccurence = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == numOccurrence)
    {
        countOccurence++;
    }
}
Console.WriteLine($"Number of Occurrence of the number {numOccurrence} is : " +  countOccurence);