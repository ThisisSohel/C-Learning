class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number to devide 10");
            var num = int.Parse(Console.ReadLine()!);
            int result = 10 / num;
            Console.WriteLine("100 / {0} = {1}", num, result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error Info: " + ex.Message);
        }

        //FileInfo file = null;
        //try
        //{
        //    Console.WriteLine("Enter the file name");
        //    string fileName = Console.ReadLine();
        //    file = new FileInfo(fileName);
        //    file.AppendText("Hello World!");
        //}catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);  
        //}finally
        //{
        //    file = null;
        //}

    }
}