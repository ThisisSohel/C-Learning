

class Program
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader streamReader = new StreamReader(@"C:\Sample Files\Data2.txt");
            Console.WriteLine("Enter a number");
            var num = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"The squre of {num} is {num * num}");
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        } 
        catch (Exception ex)
        {
           Console.WriteLine("Error Info: " + ex.Message);
        }
        finally
        {

            Console.WriteLine("Re try with another way");
        }

    }
}