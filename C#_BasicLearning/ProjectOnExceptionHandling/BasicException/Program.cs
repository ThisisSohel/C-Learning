namespace BasicException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                var input = int.Parse(Console.ReadLine());
                int result = 10 / input;
                Console.WriteLine($"Division: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Input a numeric number");
            }

            FileInfo file = null;

            try
            {
                Console.WriteLine("Enter a file name: ");
                string fileName = Console.ReadLine();
                file = new FileInfo(fileName);
                //StreamWriter streamWriter = file.AppendText("Hello World!");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch(Exception ex)
            {
                /*Console.WriteLine(ex);*/
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// This method will work for the summation!
        /// </summary>
        public static void Method()
        {

        }
    }
}
