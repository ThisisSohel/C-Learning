namespace ExceptionHandlingWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter first number: ");
                    int fN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    int sN = Convert.ToInt32(Console.ReadLine());

                    int result = fN / sN;
                    Console.WriteLine("Result: {0}", result);
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Users\User\Desktop\Log1.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sr = new StreamWriter(filePath);
                        sr.Write(ex.GetType().Name);
                        sr.Write(ex.Message);
                        sr.Close();
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }

                }
            }catch (Exception exception)
            {
                Console.WriteLine("Current Exception: {0}", exception.GetType().Name);
                if(exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: {0}", exception.InnerException.GetType().Name);
                }

            }
        }
    }
}
