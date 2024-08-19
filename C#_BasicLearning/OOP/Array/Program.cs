
using Array;

public class Program
{
    public static void Main(string[] args)
    {
        Customer customer1 = new Customer()
        {
            Id = 1,
            Name = "Sakib",
            Salary = 2000
        };
        Customer customer2 = new Customer()
        {
            Id = 11,
            Name = "Suny",
            Salary = 3000
        };
        Customer customer3 = new Customer()
        {
            Id = 12,
            Name = "Rakib",
            Salary = 1000
        };
        Customer[] arr = new Customer[3];
        arr[0] = customer1;
        arr[1] = customer2;
        arr[2] = customer3;

        int numToRemove = 1;
        arr = arr.Where(x => x.Id != numToRemove).ToArray();
        //int arrIndex = arr.IndexOf(arr, customer1);
        arr[0].Name = "Sohel";
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Id = {0} Name {1} Salary {2}", arr[i].Id, arr[i].Name, arr[i].Salary);
        }

    }
}